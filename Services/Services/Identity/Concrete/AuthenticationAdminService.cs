using AutoMapper;
using DAL.Context;
using DAL.UnitOfWork.Implementation;
using DAL.UnitOfWork.Interfaces;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using System.Reflection;
using System.Security.Claims;

namespace ServiceLayer.Services.Identity.Concrete
{
    public class AuthenticationAdminService : IAuthenticationAdminService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IToastNotification _toasty;

        public AuthenticationAdminService(UserManager<AppUser> userManager, IMapper mapper, IToastNotification toasty, RoleManager<AppRole> roleManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _toasty = toasty;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IdentityResult> ExtendClaimAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username); // Busca al usuario por su nombre de usuario.

            // Obtiene los reclamos actuales del usuario y busca uno específico que contenga "Observer".
            var claims = await _userManager.GetClaimsAsync(user!);
            var existingClaim = claims.FirstOrDefault(x => x.Type.Contains("Observer"));

            var newExtendedClaim = new Claim("AdminObserverExpireDate", DateTime.Now.AddDays(5).ToString()); // Crea un nuevo reclamo extendido

            return await _userManager.ReplaceClaimAsync(user!, existingClaim!, newExtendedClaim); // Reemplaza el reclamo existente con el nuevo reclamo.
        }

        public async Task<List<UserVM>> GetUserListAsync()
        {
            // Recupera la lista de usuarios desde la base de datos.
            var userList = await _userManager.Users.ToListAsync();

            // Convierte la lista de entidades de usuario en una lista de objetos de vista (UserVM) utilizando AutoMapper.
            var userListVM = _mapper.Map<List<UserVM>>(userList);

            // Para cada usuario, recupera sus roles y reclamos, y los asigna al modelo de vista.
            for (int i = 0; i < userList.Count; i++)
            {
                var userRoles = await _userManager.GetRolesAsync(userList[i]);
                userListVM[i].UserRoles = userRoles;

                userListVM[i].Roles = userRoles.FirstOrDefault() ?? "Sin rol";

                var userClaims = await _userManager.GetClaimsAsync(userList[i]);
                userListVM[i].UserClaims = userClaims;
            }

            return userListVM; // Devuelve la lista de usuarios con sus roles y reclamos asignados.
        }

        public async Task<IdentityResult> UpdateUserRoleAsync(string userName, string role)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = $"El usuario con nombre {userName} no fue encontrado." });
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            if (currentRoles.Any())
            {
                var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
                if (!removeResult.Succeeded)
                {
                    return IdentityResult.Failed(new IdentityError { Description = "Error al remover el rol actual del usuario." });
                }
            }

            var addResult = await _userManager.AddToRoleAsync(user, role);
            if (!addResult.Succeeded)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Error al asignar el nuevo rol al usuario." });
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteUserAsync(string userName)
        {
            // Buscar al usuario por su nombre de usuario
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                // Si el usuario no existe, retornar un error
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "El usuario no existe."
                });
            }

            // Eliminar el usuario
            var deleteResult = await _userManager.DeleteAsync(user);

            if (!deleteResult.Succeeded)
            {
                // Si hubo un error al eliminar al usuario, retornar un error
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Hubo un problema al intentar eliminar el usuario."
                });
            }

            // Si la eliminación fue exitosa
            return IdentityResult.Success;
        }

        public async Task<List<string>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync(); // Obtener todos los roles desde la base de datos

            if (roles == null || roles.Count == 0)
            {
                return new List<string>(); // Retorna una lista vacía si no hay roles
            }

            return roles.Select(r => r.Name).ToList(); // Devuelve solo los nombres de los roles
        }






        // 🔹 Obtener permisos de un rol
        public async Task<List<string>> ObtenerPermisosDeRol(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return new List<string>();

            var claims = await _roleManager.GetClaimsAsync(role);
            return claims.Select(c => c.Type).ToList();
        }

        // 🔹 Asignar un permiso a un rol
        public async Task<bool> AsignarPermisoARol(string roleId, string modulo, string permiso)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return false;

            string claimType = $"Permiso.{modulo}.{permiso}";

            // Verificar si ya existe el permiso
            var claims = await _roleManager.GetClaimsAsync(role);
            if (claims.Any(c => c.Type == claimType)) return false;

            var resultado = await _roleManager.AddClaimAsync(role, new Claim(claimType, "true"));
            return resultado.Succeeded;
        }

        // 🔹 Revocar un permiso de un rol
        public async Task<bool> RevocarPermisoDeRol(string roleId, string modulo, string permiso)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return false;

            string claimType = $"Permiso.{modulo}.{permiso}";

            var claims = await _roleManager.GetClaimsAsync(role);
            var claimToRemove = claims.FirstOrDefault(c => c.Type == claimType);
            if (claimToRemove == null) return false;

            var resultado = await _roleManager.RemoveClaimAsync(role, claimToRemove);
            return resultado.Succeeded;
        }

    

            //public async Task<List<string>> GetPermissionsForRoleAsync(string roleName)
            //{
            //    // Encuentra el rol por su nombre
            //    var role = await _roleManager.FindByNameAsync(roleName);

            //    if (role == null)
            //    {
            //        throw new SystemException($"Role {roleName} not found");
            //    }

            //    // Obtén los permisos asociados a ese rol desde RoleClaims
            //    var permissions = await _unitOfWork.GetGenericRepository<AppRole>().GetAllList()
            //        .Where(rc => rc.RoleId == role.Id)
            //        .Select(rc => rc.ClaimType)
            //        .ToListAsync();

            //    return permissions;
            //}
        


        // Método para asignar todos los permisos a todos los roles
        //public async Task AsignarTodosLosPermisos()
        //{
        //    // Definir todos los módulos disponibles
        //    var modulos = new List<string>
        //    {
        //        "Dashboard", "Cuenta Corriente", "Miembros-ListadoDetallado", "Miembros-ExMiembros", "Pagos",
        //        "Mi Organismo", "User Settings", "User List", "Ayuda"
        //    };

        //    // Obtener todos los permisos desde la base de datos
        //    var permisos = await _unitOfWork.GetGenericRepository<Permission>().GetAllList().ToListAsync();  // Suponiendo que tienes un DbContext y la tabla Permissions

        //    // Obtener todos los roles en el sistema
        //    var roles = await _roleManager.Roles.ToListAsync();

        //    foreach (var role in roles)
        //    {
        //        // Por cada rol, asignar todos los permisos para cada módulo
        //        foreach (var modulo in modulos)
        //        {
        //            foreach (var permiso in permisos)
        //            {
        //                // Crear el claim correspondiente (tipo: "Permiso.[Modulo].[PermisoName]")
        //                var claimType = $"Permiso.{modulo}.{permiso.PermissionName}";

        //                // Verificar si el rol ya tiene este permiso, para no agregar duplicados
        //                var roleClaims = await _roleManager.GetClaimsAsync(role);
        //                if (!roleClaims.Any(c => c.Type == claimType))
        //                {
        //                    // Si no tiene el claim, lo agregamos
        //                    var result = await _roleManager.AddClaimAsync(role, new Claim(claimType, "true"));

        //                    // Si hay un error al agregar el claim, puedes hacer algo (como loguear el error)
        //                    if (!result.Succeeded)
        //                    {
        //                        // Aquí podrías loguear o manejar el error según tu caso
        //                        Console.WriteLine($"Error al asignar el permiso {claimType} al rol {role.Name}");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}



    }
}

using Entity.Identity.Entities.Enumerators;
using Entity.Identity.ViewModels.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Entity.Identity.Entities.ImageUploadModel;

namespace ServiceLayer.Helpers.Generic.Image
{
    public class ImageHelper : IImageHelper
    {
        private readonly IHostEnvironment _hostEnvironment; // Proporciona información sobre el entorno de la aplicación.
        private readonly string wwwRoot; // Ruta física al directorio wwwroot.
        private const string imageFolder = "images"; // Carpeta principal para almacenar imágenes.
        private const string identityFolder = "user"; // Carpeta para imágenes de usuarios.
        private const string aboutFolder = "aboutUs"; // Carpeta para imágenes de la sección "about us".
        private const string portfolioFolder = "portfolios"; // Carpeta para imágenes de portafolios.
        private const string teamFolder = "team"; // Carpeta para imágenes del equipo.
        private const string testimonalFolder = "testimonals"; // Carpeta para imágenes de testimonios.

        public ImageHelper(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment; // Inyección de dependencia para obtener el entorno.
            wwwRoot = _hostEnvironment.ContentRootPath + "/wwwroot/"; // Define la ruta completa al directorio wwwroot.
        }

        public async Task<ImageUploadModel> ImageUpload(IFormFile imageFile, ImageType imageType, string? folderName)
        {
            if (folderName == null) // Si no se especifica una carpeta, se define según el tipo de imagen.
            {
                switch (imageType)
                {
                    case ImageType.about:
                        folderName = aboutFolder; // Usa la carpeta aboutUs.
                        break;
                    case ImageType.identity:
                        folderName = identityFolder; // Usa la carpeta user.
                        break;
                    case ImageType.team:
                        folderName = teamFolder; // Usa la carpeta team.
                        break;
                    case ImageType.testimonal:
                        folderName = testimonalFolder; // Usa la carpeta testimonals.
                        break;
                    case ImageType.portfolio:
                        folderName = portfolioFolder; // Usa la carpeta portfolios.
                        break;
                }
            }

            // Crea la carpeta si no existe en la ruta especificada.
            if (!Directory.Exists($"{wwwRoot}/{imageFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{wwwRoot}/{imageFolder}/{folderName}");
            }

            // Obtiene la extensión del archivo en minúsculas.
            string fileExtension = Path.GetExtension(imageFile.FileName).ToLower();
            // Verifica que la extensión sea válida (.jpg o .jpeg).
            if (fileExtension != ".jpg" && fileExtension != ".jpeg")
            {
                return new ImageUploadModel { Error = "Solo se adminten archivos en formato JPG o JPEG." }; // Retorna un error si no es válido.
            }

            // Crea un nombre único para el archivo usando la carpeta y un timestamp.
            DateTime dateTime = DateTime.Now;
            var newfileName = folderName + "_" + dateTime.Microsecond.ToString() + fileExtension;

            // Construye la ruta completa para guardar la imagen.
            string path = Path.Combine($"{wwwRoot}/{imageFolder}/{folderName}", newfileName);

            // Usa un stream para guardar el archivo físicamente en la ruta especificada.
            await using var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
            await imageFile.CopyToAsync(stream); // Copia el contenido del archivo al stream.
            await stream.FlushAsync(); // Limpia cualquier dato residual en el stream.

            // Retorna un modelo con el nombre del archivo y el tipo de contenido.
            return new ImageUploadModel { Filename = $"{folderName}/{newfileName}", FileType = imageFile.ContentType };
        }

        public string DeleteImage(string imageName)
        {
            // Construye la ruta completa del archivo que se desea eliminar.
            var fileToDelete = Path.Combine($"{wwwRoot}/{imageFolder}/{imageName}");
            if (File.Exists(fileToDelete)) // Verifica si el archivo existe.
            {
                File.Delete(fileToDelete); // Elimina el archivo si existe.
            }

            return "La imagen fue eliminada"; // Retorna un mensaje de confirmación.
        }
    }
}


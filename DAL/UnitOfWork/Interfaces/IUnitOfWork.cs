using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

namespace DAL.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        // Método sincrónico para confirmar los cambios realizados en la unidad de trabajo.
        void Commit();

        // Método asincrónico para confirmar los cambios realizados en la unidad de trabajo.
        // Este es útil en operaciones que pueden llevar tiempo y no se bloquea el hilo principal.
        Task<bool> CommitAsync();

        // Método que obtiene un repositorio genérico para manejar entidades de tipo T.
        // Permite acceder a las operaciones CRUD para cualquier entidad.
        IGenericRepository<T> GetGenericRepository<T>() where T : class;

        // Método asincrónico para liberar recursos utilizados por la unidad de trabajo.
        ValueTask DisposeAsync();

        // Método asincrónico para iniciar una transacción.
        // Este es el primer paso en una transacción, asegurando que las operaciones se realicen de manera atómica.
        Task BeginTransactionAsync();

        // Método asincrónico para confirmar una transacción.
        // Si todas las operaciones dentro de la transacción fueron exitosas, se guarda la transacción.
        Task CommitTransactionAsync();

        // Método asincrónico para revertir una transacción.
        // Si algo salió mal durante la transacción, este método permite deshacer las operaciones realizadas hasta el momento.
        Task RollbackTransactionAsync();

        DbContext GetDbContext(); // Exponer el contexto aquí

    }
}

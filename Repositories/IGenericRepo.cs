using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

// interface class for the generic repository pattern - defines GenericRepo methodss

namespace TelemetryPortal_MVC.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAllGenericAsync();
        Task<T> GetGenericByIdAsync(Guid id);
        Task AddGenericAsync(T entity);
        Task UpdateGenericAsync(T entity);
        Task DeleteGenericAsync(Guid id);
        Task<bool> GenericExistsAsync(Guid id);

    }
}

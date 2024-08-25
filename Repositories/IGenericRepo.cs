using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

/**defines GenericRepo methods
 The interface for the newly created Generic Repository class.*/

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

using IntroToASPMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroToASPMVC.Data
{
    public interface IGenericRepo<T> where T : BaseModel
    {
        Task AddEntityAsync(T entity);
        Task DeleteEntityAsync(T entity);
        Task<bool> EntityExistsAsync(int id);
        Task<ICollection<T>> GetEntitiesAsync();
        Task<T> GetEntityAsync(int id);
        Task UpdateEntityAsync(T entity);
    }
}
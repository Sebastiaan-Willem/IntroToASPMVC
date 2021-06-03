using IntroToASPMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Data
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseModel
    {
        protected AspContext _context;
        public GenericRepo(AspContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateEntityAsync(T entity)
        {
             
            //Attach makes EF track this object (and thus will update it after a savechanges)
            _context.Attach(entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEntityAsync(T entity)
        {
            _context.Attach(entity);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetEntitiesAsync()
        {
            //Set allows us to specify which DbSet we have to return 
            var dbSet = _context.Set<T>();
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetEntityAsync(int id)
        {
            var dbset = _context.Set<T>();
            return await dbset.FindAsync(id);
        }

        public async Task<bool> EntityExistsAsync(int id)
        {
            var dbset = _context.Set<T>();
            return await dbset.AnyAsync(x => x.Id == id);
        }
    }
}

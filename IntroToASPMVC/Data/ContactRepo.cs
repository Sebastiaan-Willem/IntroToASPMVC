using IntroToASPMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Data
{
    public class ContactRepo : GenericRepo<Contact>, IContactRepo
    {

        public ContactRepo(AspContext context) : base(context)
        {

        }

        public override async Task<ICollection<Contact>> GetEntitiesAsync()
        {
            //Set allows us to specify which DbSet we have to return 

            return await _context.Contacts
                .Include(x => x.Address)
                .ToListAsync();
        }

        public override async Task<Contact> GetEntityAsync(int id)
        {

            return await _context.Contacts
                .Include(x => x.Address)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

    }
}

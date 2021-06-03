using IntroToASPMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public interface IContactService
    {
        Task AddContactAsync(Contact contact);
        Task DeleteContactAsync(Contact contact);
        Task<Contact> GetContactAsync(int id);
        Task<ICollection<Contact>> GetContactsAsync();
        Task UpdateContactAsync(Contact contact);
    }
}
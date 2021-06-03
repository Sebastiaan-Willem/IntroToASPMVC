using IntroToASPMVC.Data;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace IntroToASPMVC.Services
{
    public class ContactService : IContactService
    {
        private IContactRepo _repo;
        private IGenericRepo<Address> _addressRepo;

        public ContactService(IContactRepo repo, IGenericRepo<Address> addressRepo)
        {
            _repo = repo;
            _addressRepo = addressRepo;
        }
        public async Task<ICollection<Contact>> GetContactsAsync()
        {
            return await _repo.GetEntitiesAsync();
        }

        public async Task<Contact> GetContactAsync(int id)
        {
            return await _repo.GetEntityAsync(id);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            //use distributed transaction to make sure BOTH database calls are succesful before applying.
            // All or Nothing concept to prevent corrupt/incomplete database updates over multiple tables

            //using (var scope = new TransactionScope(TransactionScopeOption.Required, 
            //    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            //{
                await _repo.UpdateEntityAsync(contact);                
                await _addressRepo.UpdateEntityAsync(contact.Address);

            //   scope.Complete();
            //}
                
        }

        public async Task AddContactAsync(Contact contact)
        {
            await _repo.AddEntityAsync(contact);
        }

        public async Task DeleteContactAsync(Contact contact)
        {
            await _repo.DeleteEntityAsync(contact);
        }

    }
}

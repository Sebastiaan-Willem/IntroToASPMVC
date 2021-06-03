using IntroToASPMVC.Data;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public class AddressService : IAddressService
    {
        private IGenericRepo<Address> _repo;

        public AddressService(IGenericRepo<Address> repo)
        {
            _repo = repo;
        }
        public async Task<ICollection<Address>> GetAddressesAsync()
        {
            return await _repo.GetEntitiesAsync();
        }

        public async Task<Address> GetAddressAsync(int id)
        {
            return await _repo.GetEntityAsync(id);
        }

        public async Task UpdateAddressAsync(Address address)
        {
            await _repo.UpdateEntityAsync(address);
        }

        public async Task AddAddressAsync(Address address)
        {
            await _repo.AddEntityAsync(address);
        }

        public async Task DeleteAddressAsync(Address address)
        {
            await _repo.DeleteEntityAsync(address);
        }
    }
}

using IntroToASPMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public interface IAddressService
    {
        Task AddAddressAsync(Address address);
        Task DeleteAddressAsync(Address address);
        Task<Address> GetAddressAsync(int id);
        Task<ICollection<Address>> GetAddressesAsync();
        Task UpdateAddressAsync(Address address);
    }
}
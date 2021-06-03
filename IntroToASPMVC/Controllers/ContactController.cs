using AutoMapper;
using IntroToASPMVC.DTOs;
using IntroToASPMVC.Models;
using IntroToASPMVC.Services;
using IntroToASPMVC.ViewModels.Contacts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contactService;
        private IAddressService _addressService;
        private IMapper _mapper;

        public ContactController(IMapper mapper, IContactService cService, IAddressService aService)
        {
            _mapper = mapper;
            _contactService = cService;
            _addressService = aService;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Contact> contacts = await _contactService.GetContactsAsync();

            var model = new ContactViewModel
            {
                Contacts = _mapper.Map<ICollection<ContactDTO>>(contacts)
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var contact = await _contactService.GetContactAsync(id);
            
            var viewModel = _mapper.Map<ContactDetailViewModel>(contact);
            //Address data explicitly mapped -> see AutoMapperProfile
            

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactCreateViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (isModelValid)
            {
                Contact contact = _mapper.Map<Contact>(vm);

                await _contactService.AddContactAsync(contact);

                return RedirectToAction(nameof(Index));

            }

            return View(vm);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Contact contact = await _contactService.GetContactAsync(id);

            if (contact == null)
            {
                return NotFound();
            }
            ContactEditViewModel vm = _mapper.Map<ContactEditViewModel>(contact);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContactEditViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (isModelValid)
            {
                Contact contact = _mapper.Map<Contact>(vm);
                await _contactService.UpdateContactAsync(contact);

                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Contact contact = await _contactService.GetContactAsync(id);
            ContactDeleteViewModel vm = _mapper.Map<ContactDeleteViewModel>(contact);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ContactDeleteViewModel vm)
        {
            if (vm == null)
            {
                return NotFound();
            }

            Contact contact = _mapper.Map<Contact>(vm);
            await _contactService.DeleteContactAsync(contact);

            return RedirectToAction(nameof(Index));
        }
    }
}

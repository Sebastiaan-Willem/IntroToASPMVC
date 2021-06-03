using AutoMapper;
using IntroToASPMVC.Models;
using IntroToASPMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Controllers
{
    public class CursistController : Controller
    {
        private IMapper _mapper;
        public CursistController(IMapper mapper)
        {
            _mapper = mapper;
        }

        
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Create()
        {
            return View();
        }

        //overloaded Create to receive information from the form in the View
        // [HttpPost] so compiler isn't confused about which Create to call on page load
        [HttpPost]
        public IActionResult Create(CursistViewModel vm)
        {
            //tests the vm for validation (based on Data Annotations)
            bool isValid = TryValidateModel(vm);

            if (isValid)
            {
                Cursist cursist = _mapper.Map<Cursist>(vm); 

                //todo: save data to database (via service)

                return RedirectToAction(nameof(Index));
            }

            //return view again with errors(not default) if data was not valid
            //Errors are only shown when you add them manually in the View (see Views -> Cursist -> Create)
            return View(vm);
        }
    }
}

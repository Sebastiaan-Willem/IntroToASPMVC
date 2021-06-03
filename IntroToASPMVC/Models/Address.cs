using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Address : BaseModel
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Unit { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
     
    }
}

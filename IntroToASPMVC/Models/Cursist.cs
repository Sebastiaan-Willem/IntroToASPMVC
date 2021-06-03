using IntroToASPMVC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Cursist: BaseModel
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public ICollection<string> Courses { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Equipment : BaseModel
    {
        public string Name { get; set; }
        public int Durability { get; set; }

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Weapon: Equipment
    {
        public int Damage { get; set; }
        public bool IsRanged{ get; set; }
    }
}

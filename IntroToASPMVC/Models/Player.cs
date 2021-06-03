using IntroToASPMVC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Player: BaseModel
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Mana { get; set; } = 50;
        public PlayerClass PlayerClass { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29
{
    class Warrior : Hero
    {
        public Warrior()
        {
            strength = 10;
            agility = 5;
            cunning = 2;
            superPower = "Super Strength";
            //Klassen warrior, som ärver från Hero, som ärver från Character. Dens attribut och superkraft.
        }
    }
}

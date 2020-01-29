using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29
{
    class Healer : Hero
    {
        public Healer()
        {
            strength = 5;
            agility = 2;
            cunning = 10;
            superPower = "Healing Words";
            //Klassen Healer, som ärver från Hero, som ärver från Character. Dens attribut och superkraft.
        }
    }
}

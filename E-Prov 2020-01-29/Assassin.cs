using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29
{
    class Assassin : Villain
    {
        public Assassin()
        {
            strength = 2;
            agility = 10;
            cunning = 5;
            superPower = "Fast Attacks";
            //Klassen Assassin, som ärver från Villain, som ärver från Character. Dens attribut och superkraft.
        }
    }
}

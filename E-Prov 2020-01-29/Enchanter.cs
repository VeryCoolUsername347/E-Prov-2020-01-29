using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29
{
    class Enchanter : Villain
    {
        public Enchanter()
        {
            strength = 2;
            agility = 5;
            cunning = 10;
            superPower = "Empower Attack";
            //Klassen Enchanter, som ärver från Villain, som ärver från Character. Dens attribut och superkraft.
        }
    }
}

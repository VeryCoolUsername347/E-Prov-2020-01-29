using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020_01_29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pickingSide = true;
            bool pickingClass = true;
            string playerAlignment = "";
            string playerClass = "";
            //De olika strings och bools jag behöver, kan även lägga till fler ifall jag behöver mer av andra datatyper
            while (pickingSide)
            {
                //detta är en while loop som instruerar spelaren att völja sida, antigen god eller ond och fortsätter köras tills spelaren valt.
                Console.WriteLine("Hello! Please pick a side!");
                Console.WriteLine("v = Villain, h = Hero");
                playerAlignment = Console.ReadLine(); 
                //Här anger spelaren sitt val som sedan verifieras med en if-sats som har en toLower.
                if (playerAlignment.ToLower() == "v")
                {
                    Console.WriteLine("You have chosen: Villain!");
                    pickingSide = false;
                    Console.ReadLine();
                }
                else if (playerAlignment.ToLower() == "h")
                {
                    Console.WriteLine("You have chosen: Heroes!");
                    pickingSide = false;
                    Console.ReadLine();
                }
                else
                {
                    //Else är bara att den instruerar om att det inte lyckades och spelaren måste pröva igen, tills det är exakt ett av de rätta "svaren"
                    Console.WriteLine("Incorrect input, please try again.");
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
            }
            //Därefter har jag kopierat nästan exakt samma while loop, fast istället för att välja alignment eller parti, så väljer man sin styrka.
            while (pickingClass)
            {
                Console.WriteLine("Hello! Please pick a class!");
                Console.WriteLine("d = Damage, s = Support");
                playerClass = Console.ReadLine();
                if (playerClass.ToLower() == "d")
                {
                    Console.WriteLine("You have chosen: Damage!");
                    pickingClass = false;
                    Console.ReadLine();
                }
                else if (playerClass.ToLower() == "s")
                {
                    Console.WriteLine("You have chosen: Support!");
                    pickingClass = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect input, please try again.");
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
            }
            Console.Clear();
            //Här så kollar koden vad exakt det är som spelaren har valt och matar sedan ut det samtidigt som den skapar en ny instans av den klassen.
            if (playerAlignment.ToLower() == "v" && playerClass.ToLower() == "d")
            {
                Console.WriteLine("You are a villainous assassin.");
                Console.ReadLine();
                Assassin a1 = new Assassin();
            }
            else if (playerAlignment.ToLower() == "v" && playerClass.ToLower() == "s")
            {
                Console.WriteLine("You are a villainous enchanter.");
                Console.ReadLine();
                Enchanter e1 = new Enchanter();
            }
            else if (playerAlignment.ToLower() == "h" && playerClass.ToLower() == "d")
            {
                Console.WriteLine("You are a heroic warrior.");
                Console.ReadLine();
                Warrior w1 = new Warrior();
            }
            else if (playerAlignment.ToLower() == "h" && playerClass.ToLower() == "s")
            {
                Console.WriteLine("You are a heroic healer.");
                Console.ReadLine();
                Healer h1 = new Healer();
            }
            Console.Clear();
            Console.WriteLine("Character creation complete!");
            //Här är du klar.
            Console.ReadLine();
        }
    }
}
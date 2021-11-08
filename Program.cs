using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lists");
            Console.WriteLine("(inventory system)");
            Console.WriteLine();

            string currentItem;
            string[] inventory1 = new string[10];
            //string[] inventory1;

            // init
            currentItem = "smokes"; // (metal gear)
            // empty inventory

            for (int i = 0; i <= inventory1.Length - 1; i++)
            {
                inventory1[i] = "";
            }

            // simulated/pretend gameplay
            // player picks up "health potion"
            inventory1[0] = "health potion"; // works, but doesn't... what if 0 is teken???


            // player drops/use "health potion"
            // ???


            Console.WriteLine("lists");
            Console.WriteLine("(inventory system)");
            Console.WriteLine();

            List<string> inventory; // declaration
            inventory = new List<string>(); // instantiation -- NO SIZE???


            Console.WriteLine("inventory size =" + inventory.Count);
            // pick up "health potion"
            inventory.Add("health potion");
            Console.WriteLine("inventory size =" + inventory.Count);
            inventory.Add("health potion");
            Console.WriteLine("inventory size =" + inventory.Count);

            // show inventory?
            //Console.WriteLine(inventory); // ???
            for (int i = 0; i<= inventory.Count - 1; i++) // 0..??
            {
                Console.WriteLine(inventory[i]);
            }

            // drop "health potion"
            inventory.Remove("health potion");


            //show inventory:
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }

           

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array.Resize(ref args, args.Length + 2);
            //args[0] = "apples=10";
            //args[1] = "oranges5";
            if (args.Length == 2)
            {
                string[] param1 = args[0].Split('=');
                if (param1.Length != 2)
                {
                    Console.WriteLine("Parameter1 does not include an = sign");
                }

                else
                {
                    string[] param2 = args[1].Split('=');
                    if (param2.Length != 2)
                    {
                        Console.WriteLine("Parameter2 does not include an = sign");
                    }
                    else
                    {
                        fruit fruit1 = new fruit(param1[0].ToString(), Int32.Parse(param1[1].ToString()));
                        fruit fruit2 = new fruit(param2[0].ToString(), Int32.Parse(param2[1].ToString()));
                        fruit1.calculatecost();
                        fruit2.calculatecost();
                        Console.WriteLine(fruit1.fruitname + " : " + fruit1.cost.ToString());
                        Console.WriteLine(fruit2.fruitname + " : " + fruit2.cost.ToString());
                        Double TotalCost = fruit1.cost + fruit2.cost;
                        Console.WriteLine("Total : " + TotalCost.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of arguments passed");
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}

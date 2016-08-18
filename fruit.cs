using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class fruit
    {
        public string fruitname;
        public Int32 itemcount;
        public Double price;
        public Double cost;

        public fruit()
        {
            fruitname = "";
            itemcount = 0;
        }

        public fruit(string name, int count)
        {
            fruitname = name;
            itemcount = count;
            setprice();
        }

        void setprice()
        {
            switch (fruitname.ToLower())
            {
                case "apples":
                    price = 0.60;
                    break;
                case "oranges":
                    price = 0.25;
                    break;
                default:
                    price = 0;
                    break;

            }
        }

        public void calculatecost()
        {
            cost = itemcount * price;
        }

    }
}

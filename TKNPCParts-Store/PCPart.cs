using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKNPCParts_Layout
{
    internal class PCPart
    {
        public static List<PCPart> partsList = new List<PCPart>();

        public string Name { get; }
        public string Description { get; }
        public int Price { get; }

        public PCPart(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void AddToCart(PCPart part)
        {
            partsList.Add(part);
        }
    }
}

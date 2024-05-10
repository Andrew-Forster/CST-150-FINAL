using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_4___IP.Models
{
    public class InvItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Icon { get; set; }

        public InvItem(string name, string description, string price, string quantity, string icon)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Icon = icon;
        }
    }
}

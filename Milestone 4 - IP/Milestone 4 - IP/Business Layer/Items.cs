using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Milestone_4___IP.Models;

namespace Milestone_4___IP.Business_Layer
{
    internal class Items
    {


        public List<InvItem> ItemsInit(List<InvItem> invItems)
        {
            invItems.Add(new InvItem("Water Bottle", "Reusable water bottle with a secure lid.", "10", "1200", "🌊"));
            invItems.Add(new InvItem("Smartphone", "High-end smartphone with advanced features.", "600", "50", "📞"));
            invItems.Add(new InvItem("Laptop", "Powerful laptop for work and entertainment.", "900", "3700", "💻"));
            invItems.Add(new InvItem("Sunglasses", "Stylish sunglasses with UV protection.", "30", "75", "🕶"));
            invItems.Add(new InvItem("Headphones", "Wireless headphones with noise cancellation.", "130", "40000", "🎧"));

            //invItems.Add(new InvItem("Backpack", "Durable backpack with multiple compartments.", "50", "60", "🎒"));
            //invItems.Add(new InvItem("Sneakers", "Comfortable sneakers for everyday wear.", "70", "80", "👟"));
            //invItems.Add(new InvItem("Watch", "Elegant watch with a classic design.", "100", "70", "⌚"));
            //invItems.Add(new InvItem("Camera", "Compact camera for capturing memories.", "200", "45", "📷"));
            //invItems.Add(new InvItem("Umbrella", "Compact umbrella for rainy days.", "20", "90", "☔"));

            return invItems;
        }

        public List<InvItem> AddItem(List<InvItem> invItems, string name, string description, string price, string quantity, string icon)
        {
            invItems.Add(new InvItem(name, description, price, quantity, icon));
            return invItems;
        }

        public List<InvItem> RemoveItem(List<InvItem> invItems, string name)
        {
            for (int i = 0; i < invItems.Count; i++)
            {
                if (invItems[i].Name == name)
                {
                    invItems.RemoveAt(i);
                    break;
                }
            }
            return invItems;
        }

        public List<InvItem> UpdateItem(List<InvItem> invItems, string name, string description, string price, string quantity, string icon, int i)
        {
            invItems[i].Name = name;
            invItems[i].Description = description;
            invItems[i].Price = price;
            invItems[i].Quantity = quantity;
            invItems[i].Icon = icon;


            return invItems;
        }


    }
}

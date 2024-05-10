using Milestone_2___Inventory_Project;
using Milestone_4___IP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_4___IP.Business_Layer
{
    internal class Utils
    {

        private int items { get; set; }

        public Utils()
        {
            items = 0;
        }

        public Utils(int items)
        {
            this.items = items;
        }

        // Duplicate name checker
        public bool isDuplicateName(string newName, List<InvItem> itemNames)
        {
            //Removes spaces and makes the string lowercase
            newName = newName.Replace(" ", "").ToLower();

            for (int i = 0; i < itemNames.Count; i++)
            {
                if (newName == itemNames[i].Name.Replace(" ", "").ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public string isValidInput(string name, string description, string price, string quantity, string icon, bool editing, List<InvItem> list)
        {
            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(description) || String.IsNullOrWhiteSpace(price) || String.IsNullOrWhiteSpace(quantity) || String.IsNullOrWhiteSpace(icon))
            {
                return "Please fill in all fields.";
            }
            else if (isDuplicateName(name, list) && !editing)
            {
                return "Item already exists.";
            }
            else if (!double.TryParse(price, out double n) || !int.TryParse(quantity, out int m))
            {
                return "Price and quantity must be numbers.";
            }
            else if (double.Parse(price) < 0 || int.Parse(quantity) < 0)
            {
                return "Price and quantity must be positive.";
            }
            else if (icon.Length > 3)
            {
                return "You may only have 3 characters in the icons field.";
            }
            else
            {
                return "Success";
            }
        }

        public int CountOccurrences(string text, char character)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;
        }

        public string[][] SearchFor(string[][] list, string searchTerm)
        {
            ManageFile read = new ManageFile();
            string[][] results = read.SetHeaders();
            int resultsIndex = 0;

            if (string.IsNullOrWhiteSpace(searchTerm) || list == null)
            {
                list = read.SetHeaders();
                return MainForm.setResultsOutput;
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == null)
                {
                    break;
                }

                for (int j = 0; j < list[i].Length; j++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                        
                    if (list[i][j].ToLower().Contains(searchTerm.ToLower()) && list[i][j] != null)
                    {
                        results[resultsIndex + 1] = list[i];
                        resultsIndex++;
                        break;
                    }
                }
            }


            
            return results;

        }

    }
}

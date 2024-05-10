using Milestone_4___IP.Models;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Milestone_4___IP.Business_Layer
{
    internal class ManageFile
    {

        string[][] resultsOutput = new string[31][];

        const int padSpace = 15;

        string[] headers = { "Name", "Description", "Price", "Quantity", "Icon" };


        public string[] ReadFileData(string txtFile)
        {
            string[] lines;
            int lineI = 1;
            lines = File.ReadAllLines(txtFile);
            resultsOutput[0] = new string[5];
            for (int i = 0; i < 5; i++)
            {
                resultsOutput[0][i] = headers[i];
            }
            foreach (string line in lines)
            {
                resultsOutput[lineI] = new string[5];
                string[] inventoryList = line.Split(',');

                for (int i = 0; i < inventoryList.Length; i++)
                {
                    inventoryList[i] = inventoryList[i].Trim();
                    resultsOutput[lineI][i] = inventoryList[i];

                }
                lineI++;
            }
            return lines;
        }

        public string[][] GetResultsOutput()
        {
            return resultsOutput;
        }

        public void WriteFileData(string txtFile, List<InvItem> save)
        {
            using (StreamWriter writer = new StreamWriter(txtFile))
            {
                for (int i = 0; i < save.Count; i++)
                {
                    string line = save[i].Name + "," + save[i].Description + "," + save[i].Price + "," + save[i].Quantity + "," + save[i].Icon;
                    writer.WriteLine(line);
                }
            }
        }

        public string[][] SetHeaders()
        {
            resultsOutput[0] = new string[5];
            for (int i = 0; i < 5; i++)
            {
                resultsOutput[0][i] = headers[i];
            }
            return resultsOutput;
        }
    }
}

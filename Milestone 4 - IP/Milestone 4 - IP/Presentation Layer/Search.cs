using Milestone_4___IP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4___IP.Presentation_Layer
{
    public partial class Search : Form
    {
        string[][] mySearch;
        public Search(string[][] search)
        {
            InitializeComponent();
            mySearch = search;
        }

        private void Search_Load(object sender, EventArgs e)
        {

            dgvSearch.Rows.Clear();
            dgvSearch.Refresh();

            if (mySearch == null)
            {
                return;
            }

            dgvSearch.ColumnCount = mySearch[0].Length;

            for (int i = 0; i < mySearch[0].Length; i++)
            {
                dgvSearch.Columns[i].Name = mySearch[0][i];
            }

            for (int i = 1; i < mySearch.Length; i++)
            {
                // Ensure the inner array is not null to avoid NullReferenceException
                if (mySearch[i] != null)
                {
                    // Add the entire inner array as a row rather than adding each element as a new row
                    dgvSearch.Rows.Add(mySearch[i]);
                }
            }
        }
    }
}

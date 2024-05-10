using Milestone_4___IP.Business_Layer;
using Milestone_4___IP.Models;
using Milestone_4___IP.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Milestone_2___Inventory_Project
{
    public partial class UserControlUploadInv : UserControl
    {

        // Utils class
        Utils utils;

        public UserControlUploadInv()
        {
            InitializeComponent();
            utils = new Utils();
            btnCancelInvUpload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFileName.Visible = false;
            lblResults.Visible = false;
            btnRemoveRow.Visible = false;
            btnSearch.Visible = false;
            tbSearch.Visible = false;
            lblSearch.Visible = false;
            btnRemoveRow.Text = "Remove Row 1";
        }

        string currentText = "";
        string initialText = "";
        int val = 0;
        int maxWidth = 0;
        int minWidth = 0;
        int i = 0;


        private async Task AnimateButton(Button button, string textChange, int textDelay, bool addText)
        {
            initialText = (val == 0) ? button.Text : initialText;
            val = (val == 0) ? button.Text.Length * 5 : val;
            maxWidth = (maxWidth == 0) ? initialText.Length * 5 + textChange.Length * 5 : maxWidth;
            minWidth = (minWidth == 0) ? button.Width + maxWidth - textChange.Length * 5 : minWidth;


            if (addText)
            {
                for (; i < maxWidth || addText == false; i++)
                {
                    await Task.Delay(1);
                    button.Width += 2;
                    button.Location = new Point(button.Location.X + -2, button.Location.Y);
                    if (i == val && i < textChange.Length * 5)
                    {
                        button.Text += textChange[val / 5];
                        val += 5;
                    }
                }

            }
            else
            {

                for (; button.Width >= minWidth || addText == true; i--)
                {
                    await Task.Delay(1);
                    button.Width += -2;
                    button.Location = new Point(button.Location.X + 2, button.Location.Y);
                    // First Hover
                    currentText = button.Text;
                    if (i == val && i >= initialText.Length * 5)
                    {
                        if (val != initialText.Length * 5)
                        {
                            button.Text = currentText.Remove(currentText.Length - 1, 1);
                            val -= 5;
                        }
                        await Task.Delay(textDelay);
                    }
                }
            }

        }

        private async void btnCancelInvUpload_onHover(object sender, EventArgs e)
        {
            await AnimateButton(btnCancelInvUpload, "  Cancel", 20, true);
        }
        private async void btnCancelInvUpload_onHoverLeave(object sender, EventArgs e)
        {
            await AnimateButton(btnCancelInvUpload, "  Cancel", 5, false);
        }


        private void btnCancelInvUpload_Click(object sender, EventArgs e)
        {
            (this.FindForm() as MainForm)?.FileCancelClick();
            lblResults.Visible = false;
            dvgItemsAdd.Columns.Clear();
            dvgItemsAdd.Visible = false;
            btnRemoveRow.Visible = false;
            btnSearch.Visible = false;
            lblFileName.Visible = false;
            tbSearch.Visible = false;
            lblSearch.Visible = false;
            btnSelectFile.Text = "Select File";
            btnSelectFile.BackColor = Color.LightSkyBlue;
            btnRemoveRow.Text = "Remove Row 1";
        }





        private void btnSelectTxtFile(object sender, EventArgs e)
        {


            if (MainForm.btnClicked == true)
            {
                (this.FindForm() as MainForm)?.FileSelectClick();
                if (MainForm.btnClicked == false)
                {
                    lblFileName.Visible = true;
                    dvgItemsAdd.Visible = true;
                    btnRemoveRow.Visible = true;
                    btnSearch.Visible = true;
                    tbSearch.Visible = true;
                    lblSearch.Visible = true;
                    dvgItemsAdd.ColumnCount = MainForm.setResultsOutput[0].Length;

                    for (int i = 0; i < MainForm.setResultsOutput[0].Length; i++)
                    {
                        dvgItemsAdd.Columns[i].Name = MainForm.setResultsOutput[0][i];
                    }

                    for (int i = 1; i < MainForm.setResultsOutput.Length; i++)
                    {
                        // Ensure the inner array is not null to avoid NullReferenceException
                        if (MainForm.setResultsOutput[i] != null)
                        {
                            // Add the entire inner array as a row rather than adding each element as a new row
                            dvgItemsAdd.Rows.Add(MainForm.setResultsOutput[i]);
                        }
                    }

                    lblFileName.Text = MainForm.setSelectedFile;
                    //Confirm Upload Button
                    btnSelectFile.Text = "Confirm Upload";
                    btnSelectFile.BackColor = Color.LightGreen;
                    SetFormat();
                }
            }
            else
            {
                string[] str = GetDataGrid();
                if (ThrowMessage(str) != "Success")
                {
                    lblResults.Visible = true;
                    lblResults.Text = ThrowMessage(str);
                    lblResults.ForeColor = Color.Red;
                    return;
                }
                (this.FindForm() as MainForm)?.FileUploadClick();
                (this.FindForm() as MainForm)?.FileCancelClick();
                lblResults.Visible = false;
                dvgItemsAdd.Visible = false;
                btnRemoveRow.Visible = false;
                btnSearch.Visible = false;
                tbSearch.Visible = false;
                tbSearch.Text = "";
                lblSearch.Visible = false;
                btnRemoveRow.Text = "Remove Row 1";
                dvgItemsAdd.Columns.Clear();
                lblFileName.Visible = false;
                btnSelectFile.Text = "Select File";
                btnSelectFile.BackColor = Color.LightSkyBlue;
            }


        }

        int rowIndex = 0;
        private void dvgItemsAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = dvgItemsAdd.CurrentRow.Index;
            btnRemoveRow.Text = "Remove Row " + (rowIndex + 1);
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {

            if (!(rowIndex >= 0))
            {
                MessageBox.Show("Please select a row to remove.");
            }
            else if (!dvgItemsAdd.Rows[rowIndex].IsNewRow)
            {
                // Remove the selected row
                dvgItemsAdd.Rows.RemoveAt(rowIndex);
            }
            else
            {
                // Handle case where the selected row is the new row placeholder
                // (not necessary if the new row is handled separately)
                MessageBox.Show("Cannot delete the new row placeholder.");
            }
        }


        public string[] GetDataGrid()
        {
            string[] dataGrid = new string[dvgItemsAdd.Rows.Count];

            for (int rows = 0; rows < dvgItemsAdd.Rows.Count; rows++)
            {
                if (dvgItemsAdd.Rows[rows].IsNewRow)
                {
                    // Handle uncommitted new rows
                    continue;
                }
                // Create a StringBuilder to efficiently build the row string
                StringBuilder rowBuilder = new StringBuilder();

                for (int col = 0; col < dvgItemsAdd.Rows[rows].Cells.Count; col++)
                {
                    DataGridViewCell cell = dvgItemsAdd.Rows[rows].Cells[col];
                        string cellValue;
                    if (cell.Value == null)
                    {
                        cellValue = "";
                    }
                    else
                    {
                        cellValue = cell.Value.ToString() ?? "";
                    }

                    cellValue = cellValue.Replace(",", "");
                    cellValue = cellValue.Trim();
                    cellValue = cellValue.Replace("$", "");

                    if (cellValue != "")
                    {
                        // Add the cell value to the row string
                        rowBuilder.Append(cellValue);

                        // If this is not the last cell in the row, add a comma
                        if (col < dvgItemsAdd.Rows[rows].Cells.Count - 1)
                        {
                            rowBuilder.Append(",");
                        }
                    }
                    else
                    {
                        rowBuilder.Append(" ");

                        if (col < dvgItemsAdd.Rows[rows].Cells.Count - 1)
                        {
                            rowBuilder.Append(",");
                        }
                    }
                }

                // Store the constructed row string in the dataGrid array
                dataGrid[rows] = rowBuilder.ToString();
            }
            return dataGrid;
        }

        public string ThrowMessage(string[] str)
        {
            foreach (string line in str)
            {
                if (string.IsNullOrWhiteSpace(line) || utils.CountOccurrences(line, ',') != 4)
                {
                    continue;
                }
                string[] inventoryList = line.Split(',');

                // inventoryList refers to each individual item property within 1 item
                for (int i = 0; i < inventoryList.Length; i++)
                {
                    inventoryList[i] = inventoryList[i].Trim();

                }

                string exception = utils.isValidInput(inventoryList[0], inventoryList[1], inventoryList[2], inventoryList[3], inventoryList[4], false, MainForm.InvItems);

                if (exception != "Success")
                {
                    return exception;
                }

            }
            return "Success";
        }

        public void SetFormat()
        {
            int priceColumnIndex = dvgItemsAdd.Columns["Price"].Index;
            foreach (DataGridViewRow row in dvgItemsAdd.Rows)
            {
                if (decimal.TryParse(row.Cells[priceColumnIndex].Value?.ToString(), out decimal price))
                {
                    row.Cells[priceColumnIndex].Value = price;
                }
            }

            // Convert "Quantity" column to int
            int quantityColumnIndex = dvgItemsAdd.Columns["Quantity"].Index;
            foreach (DataGridViewRow row in dvgItemsAdd.Rows)
            {
                if (int.TryParse(row.Cells[quantityColumnIndex].Value?.ToString(), out int quantity))
                {
                    row.Cells[quantityColumnIndex].Value = quantity;
                }
            }

            // Now apply formatting
            dvgItemsAdd.Columns[priceColumnIndex].DefaultCellStyle.Format = "c";
            dvgItemsAdd.Columns[quantityColumnIndex].DefaultCellStyle.Format = "#,##0";

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string[][] search = utils.SearchFor(MainForm.setResultsOutput, tbSearch.Text);
            dvgItemsAdd.Rows.Clear();
            dvgItemsAdd.Refresh();

            if (search == null)
            {
                return;
            }

            dvgItemsAdd.ColumnCount = search[0].Length;

            for (int i = 0; i < search[0].Length; i++)
            {
                dvgItemsAdd.Columns[i].Name = search[0][i];
            }

            for (int i = 1; i < search.Length; i++)
            {
                // Ensure the inner array is not null to avoid NullReferenceException
                if (search[i] != null)
                {
                    // Add the entire inner array as a row rather than adding each element as a new row
                    dvgItemsAdd.Rows.Add(search[i]);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[][] search = utils.SearchFor(MainForm.setResultsOutput, tbSearch.Text);

            Search searchForm = new(search);
            searchForm.ShowDialog();
        }

    }
}

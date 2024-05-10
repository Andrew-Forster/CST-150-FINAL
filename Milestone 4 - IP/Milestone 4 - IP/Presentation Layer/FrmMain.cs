/* Andrew Forster
 * CST-150
 * Milestone 2
 * 2/2/2024
 * 
 */

using Milestone_4___IP.Business_Layer;
using Milestone_4___IP.Models;
using System.Formats.Tar;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Milestone_2___Inventory_Project
{
    public partial class MainForm : Form
    {

        //--------------------//
        //   Item Variables   //
        //--------------------//

        int currentSlot = 0;
        // Editing Item?
        int editingItem = -1;

        // List of items
        List<InvItem> invItems = new List<InvItem>();

        Button[] itemButtons = new Button[10];


        private readonly float originalFormWidth;
        private readonly float originalFormHeight;
        private readonly Dictionary<Control, Size> originalControlSizes = new Dictionary<Control, Size>();
        private readonly Dictionary<Control, Point> originalControlLocations = new Dictionary<Control, Point>();

        // Classes

        // Items class
        Items inv = new Items();

        // Utils class
        Utils utils = new Utils();



        // Holds the ID of the item in the slot
        int[] slotsOccupied = new int[10];


        public static List<InvItem> ?InvItems;


        public MainForm()
        {
            InitializeComponent();
            Init();

            originalFormWidth = this.Width;
            originalFormHeight = this.Height;

            foreach (Control control in this.Controls)
            {
                originalControlSizes[control] = control.Size;
                originalControlLocations[control] = control.Location;
            }
            itemButtons = [item1, item2, item3, item4, item5, item6, item7, item8, item9, item10];

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

        }

        private void Init()
        {

            lblItemInfo.Visible = false;
            lblSlotInfo.Visible = false;
            btnEditItem.Visible = false;
            cbItems.Visible = false;
            PanelItemEditor.Visible = false;
            btnChangeItem.Visible = false;
            lblMsg.Visible = false;

            userControlUploadInv.Visible = false;

            // Set the slots to empty
            for (int i = 0; i <= 9; i++)
            {
                slotsOccupied[i] = -1;
            }

            invItems = inv.ItemsInit(invItems);

        }

        // Refreshes the combobox with the current items
        private void ComboBoxRefresh()
        {
            string[] numberedItemNames = new string[invItems.Count];

            for (int i = 0; i < invItems.Count; i++)
            {
                // Prepend each itm with its number in the list
                // Adjusting the numbering to start from 1 instead of 0
                numberedItemNames[i] = $"{i + 1}. {invItems[i]?.Name}";
            }

            cbItems.DataSource = null;
            cbItems.DataSource = numberedItemNames;
            cbItems.Refresh();
        }

        public void SlotClick(int num)
        {
            btnChangeItem.Visible = false;
            ComboBoxRefresh();
            currentSlot = num;
            int numString = num + 1;
            lblSlotInfo.Text = "Slot " + numString + " Info";
            SlotInfo();

            //Checks if the slot is empty
            if (slotsOccupied[currentSlot] == -1)
            {
                PanelItemEditor.Visible = true;
            }

            resetTextboxes();

        }


        public void SlotInfo()
        {
            //Gets the current item ID thats in the slot
            int current = slotsOccupied[currentSlot];
            cbItems.Visible = true;
            lblSlotInfo.Visible = true;
            lblSlotInfo.Text = "Slot " + currentSlot + " Info";
            lblItemEdit.Text = "Add Item:";
           

            //Checks if the slot is empty, if so does not display any item info
            if (current != -1)
            {
                lblItemInfo.Visible = true;
                PanelItemEditor.Visible = false;
                btnEditItem.Visible = true;

                //Gets the item info and displays it from the corresponding arrays
                lblItemInfo.Text = "Item: " +
                    invItems[current].Name + "\nDescription: "
                    + invItems[current].Description + "\nPrice: $"
                    + invItems[current].Price + "\nAmount: "
                    + invItems[current].Quantity + "\nIcon: "
                    + invItems[current].Icon;

                // Displays the corresponding item icon in all slots
                for (int i = 0; i < slotsOccupied.Length; i++)
                {
                    if (slotsOccupied[i] != -1)
                    {
                        itemButtons[i].Text = invItems[slotsOccupied[i]].Icon;
                    }
                }

            }
            else
            {
                lblItemInfo.Visible = false;
                btnEditItem.Visible = false;
            }


        }

        public void resetTextboxes()
        {
            lblMsg.Visible = false;
            tbName.Text = "";
            tbDescription.Text = "";
            tbPrice.Text = "";
            tbQuanity.Text = "";
            tbIcon.Text = "";
        }

        private void DisplayError(string error)
        {
            lblMsg.Text = error;
            lblMsg.Visible = true;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(521, 225);
            lblMsg.BringToFront();
        }

        private void DisplaySuccess(string success)
        {
            lblMsg.Text = success;
            lblMsg.Visible = true;
            lblMsg.ForeColor = Color.Green;
            lblMsg.Location = new Point(521, 225);
            lblMsg.BringToFront();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            PanelItemEditor.Visible = true;
            lblItemEdit.Text = "Add Item:";

        }

        private void btnSubmitItem_Click(object sender, EventArgs e)
        {
            string check = utils.isValidInput(tbName.Text, tbDescription.Text, tbPrice.Text, tbQuanity.Text, tbIcon.Text, editingItem != -1, invItems);

            if (!check.Equals("Success"))
            {
                DisplayError(check);
            }
            //If the user is editing an item, result will differ from adding an item
            else if (editingItem != -1)
            {
                // Edits the item using the Inventory class
                invItems = inv.UpdateItem(invItems, tbName.Text, tbDescription.Text, tbPrice.Text, tbQuanity.Text, tbIcon.Text, editingItem);
                DisplaySuccess("Item Edited!");
                PanelItemEditor.Visible = false;
                editingItem = -1;

            }
            //Adding an item vvv
            else
            {
                PanelItemEditor.Visible = false;

                invItems = inv.AddItem(invItems, tbName.Text, tbDescription.Text, tbPrice.Text, tbQuanity.Text, tbIcon.Text);


                //Sets the slot to the current item as long as the slot has been clicked
                if (currentSlot != -1)
                {
                    slotsOccupied[currentSlot] = invItems.Count - 1;

                }
                //Set the textboxes to empty
                resetTextboxes();

                DisplaySuccess("Item Added!");


            }
            //REFRESHES THE COMBOBOX TO DISPLAY THE NEW ITEMS (IMPORTANT)
            SlotInfo();
            ComboBoxRefresh();
        }
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            PanelItemEditor.Visible = true;
            lblItemEdit.Text = "Edit Item:";
            //Fills the textboxes with the item that is being edited, and sets the editingItem to the current item for future reference
            editingItem = slotsOccupied[currentSlot];
            tbName.Text = invItems[editingItem].Name;
            tbDescription.Text = invItems[editingItem].Description;
            tbPrice.Text = invItems[editingItem].Price;
            tbQuanity.Text = invItems[editingItem].Quantity;
            tbIcon.Text = invItems[editingItem].Icon;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

            //Cancels the editing or adding of an item
            PanelItemEditor.Visible = false;
            if (editingItem != -1 || slotsOccupied[currentSlot] == 0)
            {
                lblSlotInfo.Visible = false;
                lblItemInfo.Visible = false;
                btnEditItem.Visible = false;
                cbItems.Visible = false;
                btnChangeItem.Visible = false;
            }
            editingItem = -1;
            currentSlot = 0;
            resetTextboxes();
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChangeItem.Visible = true;
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            //Checks if the user left the combobox empty or inputed an item that does not exist
            if (cbItems.SelectedIndex < 0)
            {
                DisplayError("Please select an item.");
                lblMsg.Location = new Point(781, 36);
                return;
            }
            if (cbItems.SelectedIndex == slotsOccupied[currentSlot])
            {
                DisplayError("Item is already in slot.");
                lblMsg.Location = new Point(781, 36);
            }
            else
            {
                // Simply changes the item in the slot to the item selected in the combobox
                slotsOccupied[currentSlot] = cbItems.SelectedIndex;
                SlotClick(currentSlot);
                SlotInfo();
                DisplaySuccess("Item Changed!");
                lblMsg.Location = new Point(781, 36);
            }

        }

        private void item1_Click(object sender, EventArgs e)
        {
            SlotClick(0);
        }


        private void item2_Click(object sender, EventArgs e)
        {
            SlotClick(1);
        }

        private void item3item3_Click(object sender, EventArgs e)
        {
            SlotClick(2);
        }

        private void item4_Click(object sender, EventArgs e)
        {
            SlotClick(3);
        }

        private void item5_Click(object sender, EventArgs e)
        {
            SlotClick(4);
        }

        private void item6_Click(object sender, EventArgs e)
        {
            SlotClick(5);
        }

        private void item7_Click(object sender, EventArgs e)
        {
            SlotClick(6);
        }

        private void item8_Click(object sender, EventArgs e)
        {
            SlotClick(7);
        }

        private void item9_Click(object sender, EventArgs e)
        {
            SlotClick(8);
        }

        private void item10_Click(object sender, EventArgs e)
        {
            SlotClick(9);
        }

        // File Upload
        private void btnUpload_Click(object sender, EventArgs e)
        {
            InvItems = invItems;
            resetTextboxes();
            userControlUploadInv.Visible = true;
            userControlUploadInv.Dock = DockStyle.Fill;

            this.Dock = DockStyle.Fill;
            userControlUploadInv.Location = new Point(0, 0);

            lblItemInfo.Visible = false;
            lblSlotInfo.Visible = false;
            btnEditItem.Visible = false;
            cbItems.Visible = false;
            PanelItemEditor.Visible = false;
            btnChangeItem.Visible = false;

            invPanel.Visible = false;
            lblInventory.Visible = false;
            btnAddItem.Visible = false;
        }
        public void FileCancelClick()
        {
            userControlUploadInv.Visible = false;

            invPanel.Visible = true;
            lblInventory.Visible = true;
            btnAddItem.Visible = true;

            btnClicked = true;
            setbtnClicked = btnClicked;

        }

        public string[][] resultsOutput { get; private set; }
        public string selectedFile { get; private set; }
        public static string[][] setResultsOutput;
        public static string setSelectedFile = "";

        public bool setbtnClicked { get; private set; }
        public static bool btnClicked = true;
        string[] lines;


        public void FileSelectClick()
        {
            // Initializes the OpenFileDialog
            ofdSelectFile.InitialDirectory = Application.StartupPath + @"Data";
            ofdSelectFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofdSelectFile.Title = "Select a Text File";
            ofdSelectFile.DefaultExt = "txt";

            // Variables
            string txtFile = "";
            string dirLocation = "";





            if (this.ofdSelectFile.ShowDialog() == DialogResult.OK && File.Exists(ofdSelectFile.FileName))
            {
                // Get the file name and directory location
                txtFile = ofdSelectFile.FileName;
                // Get the full path of the file
                dirLocation = Path.GetFullPath(ofdSelectFile.FileName);
                // Display the file name and directory location
                selectedFile = "Selected File: " + txtFile;

                ManageFile read = new ManageFile();

                lines = read.ReadFileData(txtFile);
                resultsOutput = read.GetResultsOutput();

            }
            else
            {
                return;
            }


            btnClicked = false;
            setResultsOutput = resultsOutput;
            setSelectedFile = selectedFile.ToString();
            setbtnClicked = btnClicked;

        }
        public async void FileUploadClick()
        {
            string[] str = userControlUploadInv.GetDataGrid();

            userControlUploadInv.Visible = false;

            invPanel.Visible = true;
            lblInventory.Visible = true;
            btnAddItem.Visible = true;


            // lines refers to 1 item with all its properties

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
                // Adds the item to the inventory from the items class
                invItems = inv.AddItem(invItems, inventoryList[0], inventoryList[1], inventoryList[2], inventoryList[3], inventoryList[4]);

                for (int i = 0; i < slotsOccupied.Length; i++)
                {
                    if (slotsOccupied[i] == -1)
                    {
                        await Task.Delay(300);
                        slotsOccupied[i] = invItems.Count - 1;
                        currentSlot = i;
                        break;
                    }
                }
                SlotInfo();

                int itemNum = invItems.Count;
                DisplaySuccess("Item " + itemNum + " added.");
                //REFRESHES THE COMBOBOX TO DISPLAY THE NEW ITEMS (IMPORTANT)
                ComboBoxRefresh();
            }


        }

        // Resize Event

        private void MainForm_Resize(object sender, EventArgs e)
        {
            float scaleFactorWidth = this.Width / originalFormWidth;
            float scaleFactorHeight = this.Height / originalFormHeight;

            // Apply scaling to each control
            foreach (Control control in this.Controls)
            {
                // Scaling size
                Size originalSize = originalControlSizes[control];
                control.Size = new Size((int)(originalSize.Width * scaleFactorWidth), (int)(originalSize.Height * scaleFactorHeight));

                // Scaling location
                Point originalLocation = originalControlLocations[control];
                control.Location = new Point((int)(originalLocation.X * scaleFactorWidth), (int)(originalLocation.Y * scaleFactorHeight));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveInventory();
        }

        private void SaveInventory()
        {
            string txtFile = "../../../SavedInventory.txt";

            List<InvItem> invItems = this.invItems;

            // Remove First 5 Items
            invItems.RemoveRange(0, 5);

            ManageFile write = new ManageFile();
            write.WriteFileData(txtFile, invItems);
        }
    }
}

namespace Milestone_2___Inventory_Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            item1 = new Button();
            invPanel = new Panel();
            item10 = new Button();
            item9 = new Button();
            item8 = new Button();
            item7 = new Button();
            item6 = new Button();
            item5 = new Button();
            item4 = new Button();
            item3 = new Button();
            item2 = new Button();
            lblItemInfo = new Label();
            btnAddItem = new Button();
            btnEditItem = new Button();
            lblInventory = new Label();
            cbItems = new ComboBox();
            lblSlotInfo = new Label();
            btnChangeItem = new Button();
            btnUpload = new Button();
            userControlUploadInv = new UserControlUploadInv();
            PanelItemEditor = new Panel();
            tbDescription = new TextBox();
            btnCancel = new Button();
            btnSubmitItem = new Button();
            tbIcon = new TextBox();
            tbQuanity = new TextBox();
            tbPrice = new TextBox();
            lblIcon = new Label();
            lblQuanity = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            lblItemEdit = new Label();
            tbName = new TextBox();
            lblName = new Label();
            lblMsg = new Label();
            ofdSelectFile = new OpenFileDialog();
            invPanel.SuspendLayout();
            PanelItemEditor.SuspendLayout();
            SuspendLayout();
            // 
            // item1
            // 
            item1.Anchor = AnchorStyles.Bottom;
            item1.BackColor = Color.Transparent;
            item1.FlatStyle = FlatStyle.Popup;
            item1.Font = new Font("Segoe UI", 18F);
            item1.Location = new Point(10, 10);
            item1.Name = "item1";
            item1.Size = new Size(50, 50);
            item1.TabIndex = 1;
            item1.UseVisualStyleBackColor = false;
            item1.Click += item1_Click;
            // 
            // invPanel
            // 
            invPanel.Anchor = AnchorStyles.None;
            invPanel.BackColor = Color.Transparent;
            invPanel.Controls.Add(item10);
            invPanel.Controls.Add(item9);
            invPanel.Controls.Add(item8);
            invPanel.Controls.Add(item7);
            invPanel.Controls.Add(item6);
            invPanel.Controls.Add(item5);
            invPanel.Controls.Add(item4);
            invPanel.Controls.Add(item3);
            invPanel.Controls.Add(item2);
            invPanel.Controls.Add(item1);
            invPanel.Location = new Point(8, 473);
            invPanel.Name = "invPanel";
            invPanel.Size = new Size(795, 70);
            invPanel.TabIndex = 2;
            // 
            // item10
            // 
            item10.Anchor = AnchorStyles.Bottom;
            item10.BackColor = Color.Transparent;
            item10.FlatStyle = FlatStyle.Popup;
            item10.Font = new Font("Segoe UI", 18F);
            item10.Location = new Point(730, 10);
            item10.Name = "item10";
            item10.Size = new Size(50, 50);
            item10.TabIndex = 5;
            item10.UseVisualStyleBackColor = false;
            item10.Click += item10_Click;
            // 
            // item9
            // 
            item9.Anchor = AnchorStyles.Bottom;
            item9.BackColor = Color.Transparent;
            item9.FlatStyle = FlatStyle.Popup;
            item9.Font = new Font("Segoe UI", 18F);
            item9.Location = new Point(650, 10);
            item9.Name = "item9";
            item9.Size = new Size(50, 50);
            item9.TabIndex = 5;
            item9.UseVisualStyleBackColor = false;
            item9.Click += item9_Click;
            // 
            // item8
            // 
            item8.Anchor = AnchorStyles.Bottom;
            item8.BackColor = Color.Transparent;
            item8.FlatStyle = FlatStyle.Popup;
            item8.Font = new Font("Segoe UI", 18F);
            item8.Location = new Point(570, 10);
            item8.Name = "item8";
            item8.Size = new Size(50, 50);
            item8.TabIndex = 5;
            item8.UseVisualStyleBackColor = false;
            item8.Click += item8_Click;
            // 
            // item7
            // 
            item7.Anchor = AnchorStyles.Bottom;
            item7.BackColor = Color.Transparent;
            item7.FlatStyle = FlatStyle.Popup;
            item7.Font = new Font("Segoe UI", 18F);
            item7.Location = new Point(490, 10);
            item7.Name = "item7";
            item7.Size = new Size(50, 50);
            item7.TabIndex = 5;
            item7.UseVisualStyleBackColor = false;
            item7.Click += item7_Click;
            // 
            // item6
            // 
            item6.Anchor = AnchorStyles.Bottom;
            item6.BackColor = Color.Transparent;
            item6.FlatStyle = FlatStyle.Popup;
            item6.Font = new Font("Segoe UI", 18F);
            item6.Location = new Point(410, 10);
            item6.Name = "item6";
            item6.Size = new Size(50, 50);
            item6.TabIndex = 6;
            item6.UseVisualStyleBackColor = false;
            item6.Click += item6_Click;
            // 
            // item5
            // 
            item5.Anchor = AnchorStyles.Bottom;
            item5.BackColor = Color.Transparent;
            item5.FlatStyle = FlatStyle.Popup;
            item5.Font = new Font("Segoe UI", 18F);
            item5.Location = new Point(330, 10);
            item5.Name = "item5";
            item5.Size = new Size(50, 50);
            item5.TabIndex = 5;
            item5.UseVisualStyleBackColor = false;
            item5.Click += item5_Click;
            // 
            // item4
            // 
            item4.Anchor = AnchorStyles.Bottom;
            item4.BackColor = Color.Transparent;
            item4.FlatStyle = FlatStyle.Popup;
            item4.Font = new Font("Segoe UI", 18F);
            item4.Location = new Point(250, 10);
            item4.Name = "item4";
            item4.Size = new Size(50, 50);
            item4.TabIndex = 4;
            item4.UseVisualStyleBackColor = false;
            item4.Click += item4_Click;
            // 
            // item3
            // 
            item3.Anchor = AnchorStyles.Bottom;
            item3.BackColor = Color.Transparent;
            item3.FlatStyle = FlatStyle.Popup;
            item3.Font = new Font("Segoe UI", 18F);
            item3.Location = new Point(170, 10);
            item3.Name = "item3";
            item3.Size = new Size(50, 50);
            item3.TabIndex = 3;
            item3.UseVisualStyleBackColor = false;
            item3.Click += item3item3_Click;
            // 
            // item2
            // 
            item2.Anchor = AnchorStyles.Bottom;
            item2.BackColor = Color.Transparent;
            item2.FlatStyle = FlatStyle.Popup;
            item2.Font = new Font("Segoe UI", 18F);
            item2.Location = new Point(90, 10);
            item2.Name = "item2";
            item2.Size = new Size(50, 50);
            item2.TabIndex = 2;
            item2.UseVisualStyleBackColor = false;
            item2.Click += item2_Click;
            // 
            // lblItemInfo
            // 
            lblItemInfo.Anchor = AnchorStyles.None;
            lblItemInfo.AutoSize = true;
            lblItemInfo.BackColor = Color.Transparent;
            lblItemInfo.Location = new Point(427, 251);
            lblItemInfo.Name = "lblItemInfo";
            lblItemInfo.Size = new Size(88, 100);
            lblItemInfo.TabIndex = 5;
            lblItemInfo.Text = "Name: \r\nDescription:\r\nPrice: \r\nQuanity:\r\nWeight:";
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAddItem.BackColor = Color.Transparent;
            btnAddItem.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnAddItem.FlatAppearance.BorderSize = 3;
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.Location = new Point(815, 483);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(287, 50);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Anchor = AnchorStyles.Bottom;
            btnEditItem.BackColor = Color.FromArgb(255, 192, 128);
            btnEditItem.Location = new Point(444, 384);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(94, 29);
            btnEditItem.TabIndex = 2;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = false;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // lblInventory
            // 
            lblInventory.Anchor = AnchorStyles.None;
            lblInventory.AutoSize = true;
            lblInventory.BackColor = Color.Transparent;
            lblInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInventory.ForeColor = SystemColors.Control;
            lblInventory.Location = new Point(8, 450);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(118, 20);
            lblInventory.TabIndex = 1;
            lblInventory.Text = "Your Inventory:";
            // 
            // cbItems
            // 
            cbItems.Anchor = AnchorStyles.None;
            cbItems.FormattingEnabled = true;
            cbItems.Location = new Point(948, 5);
            cbItems.Name = "cbItems";
            cbItems.Size = new Size(161, 28);
            cbItems.TabIndex = 5;
            cbItems.Text = "Change item in slot";
            cbItems.SelectedIndexChanged += cbItems_SelectedIndexChanged;
            // 
            // lblSlotInfo
            // 
            lblSlotInfo.Anchor = AnchorStyles.None;
            lblSlotInfo.AutoSize = true;
            lblSlotInfo.BackColor = Color.Transparent;
            lblSlotInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSlotInfo.ForeColor = SystemColors.ActiveCaptionText;
            lblSlotInfo.Location = new Point(429, 225);
            lblSlotInfo.Name = "lblSlotInfo";
            lblSlotInfo.Size = new Size(86, 20);
            lblSlotInfo.TabIndex = 5;
            lblSlotInfo.Text = "Slot # Info:";
            // 
            // btnChangeItem
            // 
            btnChangeItem.Anchor = AnchorStyles.None;
            btnChangeItem.BackColor = Color.LightSkyBlue;
            btnChangeItem.Location = new Point(781, 4);
            btnChangeItem.Name = "btnChangeItem";
            btnChangeItem.Size = new Size(161, 29);
            btnChangeItem.TabIndex = 7;
            btnChangeItem.Text = "Change Item";
            btnChangeItem.UseVisualStyleBackColor = false;
            btnChangeItem.Click += btnChangeItem_Click;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.None;
            btnUpload.BackColor = Color.RoyalBlue;
            btnUpload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpload.ForeColor = SystemColors.ButtonHighlight;
            btnUpload.Location = new Point(813, 549);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(287, 40);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload Inventory";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // userControlUploadInv
            // 
            userControlUploadInv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControlUploadInv.BackColor = SystemColors.AppWorkspace;
            userControlUploadInv.Location = new Point(1310, 688);
            userControlUploadInv.Name = "userControlUploadInv";
            userControlUploadInv.Size = new Size(748, 383);
            userControlUploadInv.TabIndex = 9;
            // 
            // PanelItemEditor
            // 
            PanelItemEditor.Anchor = AnchorStyles.None;
            PanelItemEditor.BackColor = Color.Transparent;
            PanelItemEditor.Controls.Add(tbDescription);
            PanelItemEditor.Controls.Add(btnCancel);
            PanelItemEditor.Controls.Add(btnSubmitItem);
            PanelItemEditor.Controls.Add(tbIcon);
            PanelItemEditor.Controls.Add(tbQuanity);
            PanelItemEditor.Controls.Add(tbPrice);
            PanelItemEditor.Controls.Add(lblIcon);
            PanelItemEditor.Controls.Add(lblQuanity);
            PanelItemEditor.Controls.Add(lblPrice);
            PanelItemEditor.Controls.Add(lblDescription);
            PanelItemEditor.Controls.Add(lblItemEdit);
            PanelItemEditor.Controls.Add(tbName);
            PanelItemEditor.Controls.Add(lblName);
            PanelItemEditor.Location = new Point(429, 225);
            PanelItemEditor.Name = "PanelItemEditor";
            PanelItemEditor.Size = new Size(534, 195);
            PanelItemEditor.TabIndex = 10;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(106, 66);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(193, 27);
            tbDescription.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(268, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(248, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmitItem
            // 
            btnSubmitItem.Anchor = AnchorStyles.Bottom;
            btnSubmitItem.BackColor = Color.LightGreen;
            btnSubmitItem.Location = new Point(14, 154);
            btnSubmitItem.Name = "btnSubmitItem";
            btnSubmitItem.Size = new Size(248, 29);
            btnSubmitItem.TabIndex = 12;
            btnSubmitItem.Text = "Submit Item";
            btnSubmitItem.UseVisualStyleBackColor = false;
            btnSubmitItem.Click += btnSubmitItem_Click;
            // 
            // tbIcon
            // 
            tbIcon.Location = new Point(386, 26);
            tbIcon.Name = "tbIcon";
            tbIcon.Size = new Size(130, 27);
            tbIcon.TabIndex = 10;
            // 
            // tbQuanity
            // 
            tbQuanity.Location = new Point(386, 92);
            tbQuanity.Name = "tbQuanity";
            tbQuanity.Size = new Size(130, 27);
            tbQuanity.TabIndex = 9;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(386, 59);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(130, 27);
            tbPrice.TabIndex = 8;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Segoe UI", 9F);
            lblIcon.ForeColor = SystemColors.ActiveCaptionText;
            lblIcon.Location = new Point(319, 33);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(40, 20);
            lblIcon.TabIndex = 6;
            lblIcon.Text = "Icon:";
            // 
            // lblQuanity
            // 
            lblQuanity.AutoSize = true;
            lblQuanity.Font = new Font("Segoe UI", 9F);
            lblQuanity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuanity.Location = new Point(319, 95);
            lblQuanity.Name = "lblQuanity";
            lblQuanity.Size = new Size(63, 20);
            lblQuanity.TabIndex = 5;
            lblQuanity.Text = "Quanity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(319, 66);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = SystemColors.ActiveCaptionText;
            lblDescription.Location = new Point(7, 69);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblItemEdit
            // 
            lblItemEdit.AutoSize = true;
            lblItemEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemEdit.ForeColor = SystemColors.ActiveCaptionText;
            lblItemEdit.Location = new Point(0, 0);
            lblItemEdit.Name = "lblItemEdit";
            lblItemEdit.Size = new Size(88, 20);
            lblItemEdit.TabIndex = 0;
            lblItemEdit.Text = "Item Editor";
            // 
            // tbName
            // 
            tbName.Location = new Point(106, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(193, 27);
            tbName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(7, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Location = new Point(521, 225);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(113, 20);
            lblMsg.TabIndex = 15;
            lblMsg.Text = "Messages Here!";
            // 
            // ofdSelectFile
            // 
            ofdSelectFile.FileName = "Please Select a File";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1112, 598);
            Controls.Add(lblMsg);
            Controls.Add(PanelItemEditor);
            Controls.Add(userControlUploadInv);
            Controls.Add(btnUpload);
            Controls.Add(btnChangeItem);
            Controls.Add(lblSlotInfo);
            Controls.Add(cbItems);
            Controls.Add(lblInventory);
            Controls.Add(btnAddItem);
            Controls.Add(lblItemInfo);
            Controls.Add(invPanel);
            Controls.Add(btnEditItem);
            MinimumSize = new Size(1130, 645);
            Name = "MainForm";
            Text = "Cool Inventory System";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            Resize += MainForm_Resize;
            invPanel.ResumeLayout(false);
            PanelItemEditor.ResumeLayout(false);
            PanelItemEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button item1;
        private Panel invPanel;
        private Button item3;
        private Button item2;
        private Button item8;
        private Button item7;
        private Button item6;
        private Button item5;
        private Button item4;
        private Button item10;
        private Button item9;
        private Label lblItemInfo;
        private Button btnAddItem;
        private Button btnEditItem;
        private Label lblInventory;
        private ComboBox cbItems;
        private Label lblSlotInfo;
        private Button btnChangeItem;
        private Button btnUpload;
        private UserControlUploadInv userControlUploadInv;
        private Panel PanelItemEditor;
        private Button btnCancel;
        private Button btnSubmitItem;
        private TextBox tbIcon;
        private TextBox tbQuanity;
        private TextBox tbPrice;
        private Label lblIcon;
        private Label lblQuanity;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblName;
        private TextBox tbName;
        private Label lblItemEdit;
        private OpenFileDialog ofdSelectFile;
        private TextBox tbDescription;
        private Label lblMsg;
    }
}

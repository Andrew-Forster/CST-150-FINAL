namespace Milestone_2___Inventory_Project
{
    partial class UserControlUploadInv
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnSelectFile = new Button();
            lblInvUpload = new Label();
            lblResults = new Label();
            lblResultsHeader = new Label();
            lblFileName = new Label();
            btnCancelInvUpload = new Button();
            dvgItemsAdd = new DataGridView();
            btnRemoveRow = new Button();
            tbSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgItemsAdd).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.LightSkyBlue;
            btnSelectFile.Font = new Font("Segoe UI", 10F);
            btnSelectFile.Location = new Point(10, 64);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(275, 48);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select a Text File";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectTxtFile;
            // 
            // lblInvUpload
            // 
            lblInvUpload.AutoSize = true;
            lblInvUpload.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInvUpload.Location = new Point(10, 13);
            lblInvUpload.Name = "lblInvUpload";
            lblInvUpload.Size = new Size(296, 37);
            lblInvUpload.TabIndex = 1;
            lblInvUpload.Text = "Inventory File Upload";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(291, 78);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(70, 22);
            lblResults.TabIndex = 2;
            lblResults.Text = "Error";
            // 
            // lblResultsHeader
            // 
            lblResultsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultsHeader.Location = new Point(10, 154);
            lblResultsHeader.Name = "lblResultsHeader";
            lblResultsHeader.Size = new Size(339, 35);
            lblResultsHeader.TabIndex = 3;
            lblResultsHeader.Text = "The following items will be added:";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.Blue;
            lblFileName.Location = new Point(10, 115);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(69, 19);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "File Name\r\n";
            // 
            // btnCancelInvUpload
            // 
            btnCancelInvUpload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelInvUpload.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelInvUpload.Font = new Font("Azonix", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelInvUpload.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelInvUpload.Location = new Point(871, 3);
            btnCancelInvUpload.Name = "btnCancelInvUpload";
            btnCancelInvUpload.Size = new Size(36, 33);
            btnCancelInvUpload.TabIndex = 5;
            btnCancelInvUpload.Text = "X";
            btnCancelInvUpload.UseVisualStyleBackColor = false;
            btnCancelInvUpload.Click += btnCancelInvUpload_Click;
            btnCancelInvUpload.MouseEnter += btnCancelInvUpload_onHover;
            btnCancelInvUpload.MouseLeave += btnCancelInvUpload_onHoverLeave;
            // 
            // dvgItemsAdd
            // 
            dvgItemsAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgItemsAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgItemsAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgItemsAdd.Location = new Point(10, 203);
            dvgItemsAdd.Name = "dvgItemsAdd";
            dvgItemsAdd.RowHeadersWidth = 51;
            dvgItemsAdd.Size = new Size(887, 246);
            dvgItemsAdd.TabIndex = 6;
            dvgItemsAdd.CellContentClick += dvgItemsAdd_CellContentClick;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveRow.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoveRow.FlatStyle = FlatStyle.Popup;
            btnRemoveRow.Location = new Point(706, 132);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(189, 29);
            btnRemoveRow.TabIndex = 7;
            btnRemoveRow.Text = "Remove Row";
            btnRemoveRow.UseVisualStyleBackColor = false;
            btnRemoveRow.Click += btnRemoveRow_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(706, 170);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(155, 27);
            tbSearch.TabIndex = 8;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(647, 173);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(867, 167);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "✔️";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // UserControlUploadInv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(tbSearch);
            Controls.Add(btnRemoveRow);
            Controls.Add(dvgItemsAdd);
            Controls.Add(lblResults);
            Controls.Add(btnCancelInvUpload);
            Controls.Add(lblFileName);
            Controls.Add(lblResultsHeader);
            Controls.Add(lblInvUpload);
            Controls.Add(btnSelectFile);
            Name = "UserControlUploadInv";
            Size = new Size(909, 463);
            ((System.ComponentModel.ISupportInitialize)dvgItemsAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblInvUpload;
        private Label lblResults;
        private Label lblResultsHeader;
        private Label lblFileName;
        private Button btnCancelInvUpload;
        private DataGridView dvgItemsAdd;
        private Button btnRemoveRow;
        private TextBox tbSearch;
        private Label lblSearch;
        private Button btnSearch;
    }
}

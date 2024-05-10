namespace Milestone_4___IP.Presentation_Layer
{
    partial class Search
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // dgvSearch
            // 
            dgvSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(1, 0);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.Size = new Size(681, 358);
            dgvSearch.TabIndex = 0;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 358);
            Controls.Add(dgvSearch);
            Name = "Search";
            Text = "Your Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSearch;
    }
}
namespace RomThing
{
    partial class RomThing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomThing));
			this.txtROMDirectory = new System.Windows.Forms.TextBox();
			this.btnOpenDirectory = new System.Windows.Forms.Button();
			this.filterCheckList = new System.Windows.Forms.CheckedListBox();
			this.btnApplyFilters = new System.Windows.Forms.Button();
			this.listROMs = new System.Windows.Forms.CheckedListBox();
			this.btnDeleteROMs = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtROMDirectory
			// 
			this.txtROMDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtROMDirectory.Enabled = false;
			this.txtROMDirectory.Location = new System.Drawing.Point(12, 12);
			this.txtROMDirectory.Name = "txtROMDirectory";
			this.txtROMDirectory.ReadOnly = true;
			this.txtROMDirectory.Size = new System.Drawing.Size(423, 20);
			this.txtROMDirectory.TabIndex = 2;
			// 
			// btnOpenDirectory
			// 
			this.btnOpenDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenDirectory.Location = new System.Drawing.Point(441, 12);
			this.btnOpenDirectory.Name = "btnOpenDirectory";
			this.btnOpenDirectory.Size = new System.Drawing.Size(111, 20);
			this.btnOpenDirectory.TabIndex = 4;
			this.btnOpenDirectory.Text = "Choose Directory";
			this.btnOpenDirectory.UseVisualStyleBackColor = true;
			this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
			// 
			// filterCheckList
			// 
			this.filterCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterCheckList.FormattingEnabled = true;
			this.filterCheckList.HorizontalScrollbar = true;
			this.filterCheckList.IntegralHeight = false;
			this.filterCheckList.Location = new System.Drawing.Point(363, 38);
			this.filterCheckList.Name = "filterCheckList";
			this.filterCheckList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.filterCheckList.Size = new System.Drawing.Size(189, 193);
			this.filterCheckList.TabIndex = 5;
			// 
			// btnApplyFilters
			// 
			this.btnApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApplyFilters.Enabled = false;
			this.btnApplyFilters.Location = new System.Drawing.Point(363, 237);
			this.btnApplyFilters.Name = "btnApplyFilters";
			this.btnApplyFilters.Size = new System.Drawing.Size(189, 33);
			this.btnApplyFilters.TabIndex = 6;
			this.btnApplyFilters.Text = "Apply Filters";
			this.btnApplyFilters.UseVisualStyleBackColor = true;
			this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
			// 
			// listROMs
			// 
			this.listROMs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listROMs.FormattingEnabled = true;
			this.listROMs.HorizontalScrollbar = true;
			this.listROMs.IntegralHeight = false;
			this.listROMs.Location = new System.Drawing.Point(12, 38);
			this.listROMs.Name = "listROMs";
			this.listROMs.Size = new System.Drawing.Size(345, 271);
			this.listROMs.TabIndex = 7;
			// 
			// btnDeleteROMs
			// 
			this.btnDeleteROMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteROMs.Enabled = false;
			this.btnDeleteROMs.Location = new System.Drawing.Point(363, 276);
			this.btnDeleteROMs.Name = "btnDeleteROMs";
			this.btnDeleteROMs.Size = new System.Drawing.Size(189, 33);
			this.btnDeleteROMs.TabIndex = 8;
			this.btnDeleteROMs.Text = "Delete ROMs";
			this.btnDeleteROMs.UseVisualStyleBackColor = true;
			this.btnDeleteROMs.Click += new System.EventHandler(this.btnDeleteROMs_Click);
			// 
			// RomThing
			// 
			this.AcceptButton = this.btnOpenDirectory;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 321);
			this.Controls.Add(this.btnDeleteROMs);
			this.Controls.Add(this.listROMs);
			this.Controls.Add(this.btnApplyFilters);
			this.Controls.Add(this.filterCheckList);
			this.Controls.Add(this.btnOpenDirectory);
			this.Controls.Add(this.txtROMDirectory);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(580, 360);
			this.Name = "RomThing";
			this.Text = "ROMThing";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtROMDirectory;
        private System.Windows.Forms.Button btnOpenDirectory;
		private System.Windows.Forms.CheckedListBox filterCheckList;
		private System.Windows.Forms.Button btnApplyFilters;
		private System.Windows.Forms.CheckedListBox listROMs;
		private System.Windows.Forms.Button btnDeleteROMs;
	}
}


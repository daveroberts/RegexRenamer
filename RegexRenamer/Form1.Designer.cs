namespace RegexRenamer
{
	partial class frmRegexRenamer
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
            this.lblCurDirTitle = new System.Windows.Forms.Label();
            this.lblCurrentDirectory = new System.Windows.Forms.Label();
            this.grdFiles = new System.Windows.Forms.DataGridView();
            this.rename = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblRenameTo = new System.Windows.Forms.Label();
            this.lblPatternInstructions = new System.Windows.Forms.Label();
            this.lblRenameToInstructions = new System.Windows.Forms.Label();
            this.lblConvertInstructions = new System.Windows.Forms.Label();
            this.lblConvertHowMany = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurDirTitle
            // 
            this.lblCurDirTitle.AutoSize = true;
            this.lblCurDirTitle.Location = new System.Drawing.Point(12, 42);
            this.lblCurDirTitle.Name = "lblCurDirTitle";
            this.lblCurDirTitle.Size = new System.Drawing.Size(86, 13);
            this.lblCurDirTitle.TabIndex = 2;
            this.lblCurDirTitle.Text = "Current Directory";
            // 
            // lblCurrentDirectory
            // 
            this.lblCurrentDirectory.AutoSize = true;
            this.lblCurrentDirectory.Location = new System.Drawing.Point(104, 42);
            this.lblCurrentDirectory.Name = "lblCurrentDirectory";
            this.lblCurrentDirectory.Size = new System.Drawing.Size(112, 13);
            this.lblCurrentDirectory.TabIndex = 3;
            this.lblCurrentDirectory.Text = "Current Directory Here";
            // 
            // grdFiles
            // 
            this.grdFiles.AllowUserToAddRows = false;
            this.grdFiles.AllowUserToDeleteRows = false;
            this.grdFiles.AllowUserToResizeRows = false;
            this.grdFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rename,
            this.filename,
            this.match,
            this.newfilename});
            this.grdFiles.Location = new System.Drawing.Point(12, 175);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeadersVisible = false;
            this.grdFiles.Size = new System.Drawing.Size(498, 241);
            this.grdFiles.TabIndex = 4;
            this.grdFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFiles_CellClick);
            // 
            // rename
            // 
            this.rename.HeaderText = "";
            this.rename.Name = "rename";
            this.rename.Width = 20;
            // 
            // filename
            // 
            this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filename.HeaderText = "Filename";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            // 
            // match
            // 
            this.match.HeaderText = "Match";
            this.match.Name = "match";
            this.match.ReadOnly = true;
            this.match.Width = 50;
            // 
            // newfilename
            // 
            this.newfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newfilename.HeaderText = "New Filename";
            this.newfilename.Name = "newfilename";
            this.newfilename.ReadOnly = true;
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Location = new System.Drawing.Point(12, 83);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(243, 20);
            this.txtPattern.TabIndex = 5;
            this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
            // 
            // txtNewName
            // 
            this.txtNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewName.Location = new System.Drawing.Point(261, 83);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(249, 20);
            this.txtNewName.TabIndex = 6;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(408, 13);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Drop a file or folder onto this form.  It will be populated with all the files in" +
    " the directory.";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(12, 67);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 8;
            this.lblPattern.Text = "Pattern";
            // 
            // lblRenameTo
            // 
            this.lblRenameTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenameTo.AutoSize = true;
            this.lblRenameTo.Location = new System.Drawing.Point(258, 67);
            this.lblRenameTo.Name = "lblRenameTo";
            this.lblRenameTo.Size = new System.Drawing.Size(63, 13);
            this.lblRenameTo.TabIndex = 9;
            this.lblRenameTo.Text = "Rename To";
            // 
            // lblPatternInstructions
            // 
            this.lblPatternInstructions.AutoSize = true;
            this.lblPatternInstructions.Location = new System.Drawing.Point(12, 106);
            this.lblPatternInstructions.Name = "lblPatternInstructions";
            this.lblPatternInstructions.Size = new System.Drawing.Size(227, 13);
            this.lblPatternInstructions.TabIndex = 10;
            this.lblPatternInstructions.Text = "Windows Style Regex.  Can use # for numbers";
            // 
            // lblRenameToInstructions
            // 
            this.lblRenameToInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenameToInstructions.AutoSize = true;
            this.lblRenameToInstructions.Location = new System.Drawing.Point(258, 117);
            this.lblRenameToInstructions.Name = "lblRenameToInstructions";
            this.lblRenameToInstructions.Size = new System.Drawing.Size(218, 13);
            this.lblRenameToInstructions.TabIndex = 11;
            this.lblRenameToInstructions.Text = "Use \\1 or \\2 to substitute matches for # or ( )";
            // 
            // lblConvertInstructions
            // 
            this.lblConvertInstructions.AutoSize = true;
            this.lblConvertInstructions.Location = new System.Drawing.Point(12, 130);
            this.lblConvertInstructions.Name = "lblConvertInstructions";
            this.lblConvertInstructions.Size = new System.Drawing.Size(88, 13);
            this.lblConvertInstructions.TabIndex = 12;
            this.lblConvertInstructions.Text = "Ready to rename";
            // 
            // lblConvertHowMany
            // 
            this.lblConvertHowMany.AutoSize = true;
            this.lblConvertHowMany.Location = new System.Drawing.Point(97, 130);
            this.lblConvertHowMany.Name = "lblConvertHowMany";
            this.lblConvertHowMany.Size = new System.Drawing.Size(35, 13);
            this.lblConvertHowMany.TabIndex = 13;
            this.lblConvertHowMany.Text = "label1";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(12, 146);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type in a pattern to match filenames.  Type in a new name.  Hit convert.";
            // 
            // frmRegexRenamer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblConvertHowMany);
            this.Controls.Add(this.lblConvertInstructions);
            this.Controls.Add(this.lblRenameToInstructions);
            this.Controls.Add(this.lblPatternInstructions);
            this.Controls.Add(this.lblRenameTo);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.grdFiles);
            this.Controls.Add(this.lblCurrentDirectory);
            this.Controls.Add(this.lblCurDirTitle);
            this.Name = "frmRegexRenamer";
            this.Text = "Regex Renamer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCurDirTitle;
		private System.Windows.Forms.Label lblCurrentDirectory;
		private System.Windows.Forms.DataGridView grdFiles;
		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.TextBox txtNewName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn rename;
		private System.Windows.Forms.DataGridViewTextBoxColumn filename;
		private System.Windows.Forms.DataGridViewTextBoxColumn match;
		private System.Windows.Forms.DataGridViewTextBoxColumn newfilename;
		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.Label lblPattern;
		private System.Windows.Forms.Label lblRenameTo;
		private System.Windows.Forms.Label lblPatternInstructions;
		private System.Windows.Forms.Label lblRenameToInstructions;
		private System.Windows.Forms.Label lblConvertInstructions;
		private System.Windows.Forms.Label lblConvertHowMany;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Label label1;
	}
}


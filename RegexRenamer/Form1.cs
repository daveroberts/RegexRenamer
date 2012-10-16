using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RegexRenameLib;

namespace RegexRenamer
{
	public partial class frmRegexRenamer : Form
	{
		private string _directory;
		public frmRegexRenamer()
		{
			InitializeComponent();
			_directory = Directory.GetCurrentDirectory();
			RefreshGrid();
		}
		private void frm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		private void frm_DragDrop(object sender, DragEventArgs e)
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
			if (a != null)
			{
				string s = a.GetValue(0).ToString();
				bool isDirectory = Directory.Exists(s);
				if (isDirectory)
				{
					_directory = s;
				}
				bool isFile = File.Exists(s);
				if (isFile)
				{
					string filepart = s.Substring(s.LastIndexOf("\\") + 1);
					string pattern = patternMacro(filepart);
					txtPattern.Text = pattern;
					txtNewName.Text = filepart;
					_directory = s.Substring(0, s.LastIndexOf("\\"));
				}
				if (!isDirectory && !isFile)
				{
					// Something odd, just ignore
				}
				this.Activate();	// in the case Explorer overlaps this form
			}
			RefreshGrid();
		}
		private string patternMacro(string pattern)
		{
			return pattern.Replace("#", "([0-9]+)");
		}
		private void RefreshGrid()
		{
			lblCurrentDirectory.Text = _directory;
			grdFiles.Rows.Clear();
			DirectoryInfo di = new DirectoryInfo(_directory);
			FileInfo[] files = di.GetFiles();
			int numMatches = 0;
			foreach(FileInfo fi in files)
			{
				DataGridViewRow r = new DataGridViewRow();
				DataGridViewCheckBoxCell checkmark = new DataGridViewCheckBoxCell();
				r.Cells.Add(checkmark);
				DataGridViewTextBoxCell filename = new DataGridViewTextBoxCell();
				filename.Value = fi.Name;
				r.Cells.Add(filename);
				DataGridViewTextBoxCell newfilename = new DataGridViewTextBoxCell();
				string pattern = patternMacro(txtPattern.Text);
				bool matches = Renamer.matches(fi.Name, pattern);
				DataGridViewTextBoxCell colMatch = new DataGridViewTextBoxCell();
				if (matches)
				{
					colMatch.Value = "Yes";
					newfilename.Value = Renamer.newname(fi.Name, pattern, txtNewName.Text);
					if (!((string)newfilename.Value).Equals("") && !((string)newfilename.Value).Equals(fi.Name))
					{
						numMatches++;
					}
				}
				else
				{
					colMatch.Value = "No";
					newfilename.Value = "";
				}
				r.Cells.Add(colMatch);
				r.Cells.Add(newfilename);
				grdFiles.Rows.Add(r);
			}
			if (numMatches == 1)
			{
				lblConvertHowMany.Text = "1 file";
			}
			else
			{
				lblConvertHowMany.Text = numMatches + " files";
			}
			btnRename.Enabled = (numMatches > 0);
		}
		private void txtPattern_TextChanged(object sender, EventArgs e)
		{
			RefreshGrid();
		}
		private void txtNewName_TextChanged(object sender, EventArgs e)
		{
			RefreshGrid();
		}
		private void btnRename_Click(object sender, EventArgs e)
		{
			if (!btnRename.Enabled)
			{
				return;
			}
			int count = 0;
			foreach (DataGridViewRow r in grdFiles.Rows)
			{
				DataGridViewCell cellMatch = r.Cells["match"];
				bool match = false;
				if (((string)cellMatch.Value).Equals("Yes"))
				{
					match = true;
				}
				DataGridViewCell cellFilename = r.Cells["filename"];
				string filename = (string)cellFilename.Value;
				DataGridViewCell cellNewFilename = r.Cells["newfilename"];
				string newFilename = (string)cellNewFilename.Value;
				if (match && !newFilename.Equals(filename) && !newFilename.Equals(""))
				{
					File.Move(_directory + "\\" + filename, _directory + "\\" + newFilename);
					count++;
				}
			}
			MessageBox.Show("Renamed " + count + " file(s)");
			RefreshGrid();
		}

        private void grdFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellString;
            try
            {
                DataGridViewTextBoxCell cell = (System.Windows.Forms.DataGridViewTextBoxCell)grdFiles.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cellString = (String)cell.Value;
                if (cellString == "") { return; }
                txtPattern.Text = cellString;
            }
            catch { }
        }
	}
}

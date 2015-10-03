using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomThing {
	public partial class RomThing : Form {
		public string ROMPath;
		public bool PathChosen = false;
		public List<string> ROMs;
		public List<string> filters;
		public string FILTER_PATH = "config.txt";

		public RomThing() {
			InitializeComponent();
		}

		private void populateROMList() {
			if (PathChosen) {
				ROMs = Directory.EnumerateFiles(ROMPath).ToList();
				listROMs.Items.Clear();
				for (var i = 0; i < ROMs.Count(); i++) {
					ROMs[i] = Path.GetFileName(ROMs[i]);
					listROMs.Items.Add(ROMs[i]);
				}
			}
		}

		private void applyFilters() {
			if (PathChosen) {
				for (int i = 0; i < listROMs.Items.Count; i++) {
					listROMs.SetItemChecked(i, false);
					foreach (string filter in filterCheckList.CheckedItems) {
						if (ROMs[i].Contains(filter)) {
							listROMs.SetItemChecked(i, true);
							break;
						}
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			filters = new List<string>();
			if (File.Exists(FILTER_PATH)) {
				var filterFile = File.ReadAllLines(FILTER_PATH);
				foreach(string line in filterFile) {
					if (line.StartsWith(";") || line.Trim() == String.Empty) {
						// Ignore line
					} else {
						filters.Add(line);
					}
				}
			} else {
				MessageBox.Show(FILTER_PATH + " was not found in the application directory, using default filters...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				// Bad dumps
				filters.Add("[b1");
				filters.Add("[b2");
				filters.Add("[b3");
				filters.Add("[b4");
				filters.Add("[b5");
				filters.Add("[b6");
				filters.Add("[b7");
				filters.Add("[b8");
				filters.Add("[b9");
				filters.Add("[bI");

				// Hacked (intros etc)
				filters.Add("[h1");
				filters.Add("[h2");
				filters.Add("[h3");
				filters.Add("[h4");
				filters.Add("[h5");
				filters.Add("[h6");
				filters.Add("[h7");
				filters.Add("[h8");
				filters.Add("[h9");
				filters.Add("[hI");

				// "Fixed"
				filters.Add("[f1");
				filters.Add("[f2");
				filters.Add("[f3");
				filters.Add("[f4");
				filters.Add("[f5");
				filters.Add("[f6");
				filters.Add("[f7");
				filters.Add("[f8");
				filters.Add("[f9");
				filters.Add("[fI");

				// Overdumps
				filters.Add("[o1");
				filters.Add("[o2");
				filters.Add("[o3");
				filters.Add("[o4");
				filters.Add("[o5");
				filters.Add("[o6");
				filters.Add("[o7");
				filters.Add("[o8");
				filters.Add("[o9");

				// Pirated
				filters.Add("[p1");
				filters.Add("[p2");
				filters.Add("[p3");
				filters.Add("[p4");
				filters.Add("[p5");
				filters.Add("[p6");
				filters.Add("[p7");
				filters.Add("[p8");
				filters.Add("[p9");

				// Trainers
				filters.Add("[t1");
				filters.Add("[t2");
				filters.Add("[t3");
				filters.Add("[t4");
				filters.Add("[t5");
				filters.Add("[t6");
				filters.Add("[t7");
				filters.Add("[t8");
				filters.Add("[t9");

				// Non-English translations
				filters.Add("[T+Bra");
				filters.Add("[T+Chi");
				filters.Add("[T+Dan");
				filters.Add("[T+Fin");
				filters.Add("[T+Fre");
                filters.Add("[T+Ger");
				filters.Add("[T+Ita");
				filters.Add("[T+Kor");
				filters.Add("[T+Lat");
				filters.Add("[T+Nor");
				filters.Add("[T+Pol");
				filters.Add("[T+Por");
				filters.Add("[T+Rus");
				filters.Add("[T+Spa");
				filters.Add("[T+Swe");
				filters.Add("[T+Spa");
				filters.Add("[T+Thai");

				// Unfinished non-English translations
				filters.Add("[T-Bra");
				filters.Add("[T-Chi");
				filters.Add("[T-Dan");
				filters.Add("[T-Fin");
				filters.Add("[T-Fre");
				filters.Add("[T-Ger");
				filters.Add("[T-Ita");
				filters.Add("[T-Kor");
				filters.Add("[T-Lat");
				filters.Add("[T-Nor");
				filters.Add("[T-Pol");
				filters.Add("[T-Por");
				filters.Add("[T-Rus");
				filters.Add("[T-Spa");
				filters.Add("[T-Swe");
				filters.Add("[T-Spa");
				filters.Add("[T-Thai");
			}
			foreach (string filter in filters) {
				filterCheckList.Items.Add(filter);
			}
			for (var i = 0; i < filterCheckList.Items.Count; i++) {
				filterCheckList.SetItemChecked(i, true);
			}
		}

		private void btnOpenDirectory_Click(object sender, EventArgs e) {
			FolderBrowserDialog dlgOpenDirectory = new FolderBrowserDialog();
			if (dlgOpenDirectory.ShowDialog() == DialogResult.OK) {
				PathChosen = true;
				ROMPath = dlgOpenDirectory.SelectedPath;
				txtROMDirectory.Text = ROMPath;

				populateROMList();
				applyFilters();

				// Update buttons
				btnApplyFilters.Enabled = true;
				btnDeleteROMs.Enabled = true;
				this.AcceptButton = btnDeleteROMs;
			}
		}

		private void btnApplyFilters_Click(object sender, EventArgs e) {
			applyFilters();
		}

		private void btnDeleteROMs_Click(object sender, EventArgs e) {
			if (listROMs.CheckedItems.Count > 0) {
				var result = MessageBox.Show("This will permanently delete the " + listROMs.CheckedItems.Count + " selected files, are you sure you wish to do this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes) {
					foreach (string ROMtoDelete in listROMs.CheckedItems) {
						File.Delete(ROMPath + "\\" + ROMtoDelete);
					}
					populateROMList();
					applyFilters();
				}
			} else {
				MessageBox.Show("There are no ROMs selected to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}

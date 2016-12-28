using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MedTrackingGui {
	public partial class SearchEmployee : Form {
		private void EnableSearchButton() {
			btnSearch.Enabled = tbName.TextLength > 0 || tbSurname.TextLength > 0 || tbPhone.TextLength > 0;
		}

		public SearchEmployee() {
			InitializeComponent();
		}

		private void tbName_TextChanged(object sender, EventArgs e) {
			EnableSearchButton();
		}

		private void tbSurname_TextChanged(object sender, EventArgs e) {
			EnableSearchButton();
		}

		private void tbPhone_TextChanged(object sender, EventArgs e) {
			EnableSearchButton();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			var name = tbName.Text;
			var surname = tbSurname.Text;
			var phone = tbPhone.Text;

			var parameters = new List<Tuple<string, string, SqlDbType>>(3) {
				new Tuple<string, string, SqlDbType>(@"Name", name, SqlDbType.VarChar),
				new Tuple<string, string, SqlDbType>(@"Surname", surname, SqlDbType.VarChar),
				new Tuple<string, string, SqlDbType>(@"Phone", phone, SqlDbType.VarChar)
			};

			var result = DBOperations.ExecuteStoredProcedure(@"SearchEmployee", parameters);

			lvEmployees.Items.Clear();

			for (int i = 0; i < result.Count; i++) {
				lvEmployees.Items.Add(new ListViewItem(new[] {
					(i + 1).ToString(),
					result[i][2].ToString(),
					result[i][3].ToString(),
					result[i][4].ToString()
				}));
			}
		}
	}
}

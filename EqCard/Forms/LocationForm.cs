using EqCard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqCard.Forms
{
	public partial class LocationForm : Form
	{
		public LocationForm()
		{
			InitializeComponent();
			dataGridView_Location.AutoGenerateColumns = true;
			dataGridView_Location.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_Location.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Text = "Места расположения оборудования";
			GetAllLocation(dataGridView_Location);
		}



		private void GetAllLocation(DataGridView dataGridView_Location)  //  получение списка расположения оборудования
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				//var locations = ecc.Locations.
				//	Select(l => new 
				//	{ 
				//		l.LocationName,
				//		l.LocationComment
				//	});
				var locations = ecc.Locations;

				dataGridView_Location.DataSource = locations.ToList();
				//dataGridView_Location.Columns[0].HeaderText = "Расположение";
				//dataGridView_Location.Columns[0].Width = 20;
				dataGridView_Location.Columns[1].HeaderText = "Расположение";
				dataGridView_Location.Columns[2].HeaderText = "Примечание";
			}
		}

		private void button_LocationExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_LocationAdd_Click(object sender, EventArgs e)
		{
			if(textBox_LocationName.Text != string.Empty)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					var location = ecc.Locations
						.Where(l => l.LocationName == textBox_LocationName.Text)
						.FirstOrDefault();
					if (location == null)
					{
						Location locationForAdd = new Location
						{
							LocationName = textBox_LocationName.Text,
							LocationComment = textBox_LocationComment.Text
						};
						ecc.Locations.Add(locationForAdd);
						ecc.SaveChanges();
						GetAllLocation(dataGridView_Location);
						MessageBox.Show("Добавлено новое расположение.");
					}
					else MessageBox.Show("Расположение существует.");
				}
				textBox_LocationName.Text = string.Empty;
				textBox_LocationComment.Text = string.Empty;
			}
			else MessageBox.Show("Введите название расположения.");
		}

		private void button_LocationDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView_Location.SelectedRows.Count > 0)
			{
				Location locationForDelete = GetLocationById(Convert.ToInt32(dataGridView_Location.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var location = ecc.Locations
						.Where(l => l.LocationName == locationForDelete.LocationName &&
										l.LocationComment == locationForDelete.LocationComment)
						.FirstOrDefault();
					if (location !=null)
					{
						ecc.Locations.Remove(location);
						ecc.SaveChanges();
						GetAllLocation(dataGridView_Location);
						MessageBox.Show("Расположение удалено.");
					}
					textBox_LocationName.Text = string.Empty;
					textBox_LocationComment.Text = string.Empty;
				}
			}
		}

		private Location GetLocationById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Locations.Find(id);
			}
		}

		private void dataGridView_Location_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Location locationForEdit = GetLocationById(Convert.ToInt32(dataGridView_Location.CurrentRow.Cells["Id"].Value));
			textBox_LocationName.Text = locationForEdit.LocationName;
			textBox_LocationComment.Text = locationForEdit.LocationComment;
		}

		private void button_LocationEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_Location.SelectedRows.Count>0)
			{
				Location locationForEdit = GetLocationById(Convert.ToInt32(dataGridView_Location.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var location = ecc.Locations
						.Where(l => l.Id == locationForEdit.Id)
						.FirstOrDefault();
					location.LocationName = textBox_LocationName.Text;
					location.LocationComment = textBox_LocationComment.Text;
					ecc.SaveChanges();
					GetAllLocation(dataGridView_Location);
					MessageBox.Show("Расположение изменено.");
				}
				textBox_LocationName.Text = string.Empty;
				textBox_LocationComment.Text = string.Empty;
			}
		}
	}
}

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
				var locations = ecc.Locations.
					Select(l => new 
					{ 
						l.LocationName,
						l.LocationComment
					});
				dataGridView_Location.DataSource = locations.ToList();
				dataGridView_Location.Columns[0].HeaderText = "Расположение";
				dataGridView_Location.Columns[1].HeaderText = "Примечание";
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
					var location = ecc.Locations.Where(l => l.LocationName == textBox_LocationName.Text).FirstOrDefault();
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
	}
}

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
	public partial class EquipmentForm : Form
	{
		public EquipmentForm()
		{
			InitializeComponent();

			dataGridView_Equipment.AutoGenerateColumns = true;
			dataGridView_Equipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_Equipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			Text = "Оборудование";


		}

		private void EquipmentForm_Load(object sender, EventArgs e)
		{
			GetAllEquipment(dataGridView_Equipment);
			FillEquipmentLocationConbo();


		}

		private void FillEquipmentLocationConbo()
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				var eqLocations = ecc.Locations.ToList();
				foreach (var eqLocation in eqLocations)
					comboBox_EqLocation.Items.Add(eqLocation.LocationName);
			}
		}

		private void GetAllEquipment(DataGridView dataGridView_Equipment)  //  получение списка
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				var equipments = ecc.Equipments
					.Select(eq => new
					{
						eq.Id,
						eq.EqName,
						eq.Location.LocationName,
						eq.EqComment
					});
				dataGridView_Equipment.DataSource = equipments.ToList();
				dataGridView_Equipment.Columns[1].HeaderText = "Название";
				dataGridView_Equipment.Columns[2].HeaderText = "Расположение";
				dataGridView_Equipment.Columns[3].HeaderText = "Примечания";
			}
		}

		private void button_EquipmentExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_EquipmentAdd_Click(object sender, EventArgs e)
		{

			if (textBox_EqName.Text != string.Empty &&
				 comboBox_EqLocation.SelectedItem != null)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					var equipment = ecc.Equipments
						.Where(eq => eq.EqName == textBox_EqName.Text &&
									 eq.Location.LocationName == comboBox_EqLocation.SelectedItem.ToString())
						.FirstOrDefault();
					if (equipment == null)
					{
						Equipment equipmentForAdd = new Equipment
						{
							EqName = textBox_EqName.Text,
							LocationId = GetLocationByName(comboBox_EqLocation.SelectedItem.ToString()).Id,
							EqComment = textBox_EquipmentComment.Text
						};
						ecc.Equipments.Add(equipmentForAdd);
						ecc.SaveChanges();
						GetAllEquipment(dataGridView_Equipment);
						MessageBox.Show("Оборудование добавлено.");
					}
					else MessageBox.Show("Оборудование уже существует.");

				}
				textBox_EqName.Text = string.Empty;
				comboBox_EqLocation.SelectedIndex = -1;
				textBox_EquipmentComment.Text = string.Empty;
			}
			else MessageBox.Show("Введите название оборудования.");
		}

		private Location GetLocationByName(string locationName)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Locations
						 .Where(l => l.LocationName == locationName)
						 .FirstOrDefault();
			}
		}

		private void button_EquipmentEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_Equipment.SelectedRows.Count > 0)
			{
				Equipment equipmentForEdit = GetEquipmentById(Convert.ToInt32(dataGridView_Equipment.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var equipment = ecc.Equipments.Where(eq => eq.Id == equipmentForEdit.Id).FirstOrDefault();
					equipment.EqName = textBox_EqName.Text;
					equipment.EqComment = textBox_EquipmentComment.Text;
					equipment.LocationId = GetLocationByName(comboBox_EqLocation.SelectedItem.ToString()).Id;
					ecc.SaveChanges();
					GetAllEquipment(dataGridView_Equipment);
					MessageBox.Show("Оборудование изменено.");
				}
				textBox_EqName.Text = string.Empty;
				comboBox_EqLocation.SelectedIndex = -1;
				textBox_EquipmentComment.Text = string.Empty;
			}
		}

		private void dataGridView_Equipment_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Equipment equipmentForEdit = GetEquipmentById(Convert.ToInt32(dataGridView_Equipment.CurrentRow.Cells["Id"].Value));
			textBox_EqName.Text = equipmentForEdit.EqName;
			comboBox_EqLocation.SelectedItem = GetLocationById(equipmentForEdit.LocationId).LocationName;
			textBox_EquipmentComment.Text = equipmentForEdit.EqComment;
		}

		private Location GetLocationById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Locations.Where(l => l.Id == id).FirstOrDefault();
			}
		}

		private Equipment GetEquipmentById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Equipments.Find(id);
			}
		}

		private void button_EquipmentDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView_Equipment.SelectedRows.Count > 0)
			{
				Equipment equipmentForDelete = GetEquipmentById(Convert.ToInt32(dataGridView_Equipment.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var equipment = ecc.Equipments
											 .Where(eq => eq.EqName == equipmentForDelete.EqName && 
															  eq.LocationId == equipmentForDelete.LocationId)
											 .FirstOrDefault();
					if (equipment != null)
					{
						ecc.Equipments.Remove(equipment);
						ecc.SaveChanges();
						GetAllEquipment(dataGridView_Equipment);
						MessageBox.Show("Оборудование удалено.");
					}
					textBox_EqName.Text = string.Empty;
					comboBox_EqLocation.SelectedIndex = -1;
					textBox_EquipmentComment.Text = string.Empty;
				}
			}
		}
	}
}

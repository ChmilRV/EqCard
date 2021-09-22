using EqCard.Forms;
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

namespace EqCard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			dataGridView_EqRecordCard.AutoGenerateColumns = true;
			dataGridView_EqRecordCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_EqRecordCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			FillEquipmentCombo();
			FillSpareCombo();


		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			FillEquipmentCombo();
			FillSpareCombo();
			
		}

		private void FillSpareCombo()
		{
			comboBox_Spare.Items.Clear();
			using (EqCardContext ecc = new EqCardContext())
			{
				var spares = ecc.Spares.ToList();
				foreach (var spare in spares)
					comboBox_Spare.Items.Add(spare.SpareName);
			}
		}

		private void comboBox_Equipment_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetAllEqRecordCard();
		}




		private void GetAllEqRecordCard()
		{

			using (EqCardContext ecc = new EqCardContext())
			{
				var eqRecordCards = ecc.EqRecordCards
											  .Where(erc=>erc.Equipment.EqName==comboBox_Equipment.SelectedItem.ToString())
											  .Select(s=>new
											  {
												  s.Id,
												  s.Spare.SpareName,
												  s.SpareCount,
												  s.EqRecordCardComment
											  });


				dataGridView_EqRecordCard.DataSource = eqRecordCards.ToList();
				dataGridView_EqRecordCard.Columns[1].HeaderText = "Наименование";
				dataGridView_EqRecordCard.Columns[2].HeaderText = "Количество";
				dataGridView_EqRecordCard.Columns[3].HeaderText = "Примечания";


			}



		}

		private Equipment GetEquipmentByName(string eqName)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Equipments
						 .Where(eq => eq.EqName == eqName)
						 .FirstOrDefault();
			}
		}

		private void FillEquipmentCombo()
		{
			comboBox_Equipment.Items.Clear();
			using (EqCardContext ecc = new EqCardContext())
			{
				var equipments = ecc.Equipments.ToList();
				foreach (var equipment in equipments)
					comboBox_Equipment.Items.Add(equipment.EqName);
			}
		}




		private void toolStripMenu_Location_Click(object sender, EventArgs e)
		{
			LocationForm locationForm = new LocationForm();
			locationForm.ShowDialog();
		}

		private void button_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenu_SpareCategory_Click(object sender, EventArgs e)
		{
			SpareCategoryForm spareCategoryForm = new SpareCategoryForm();
			spareCategoryForm.ShowDialog();
		}

		private void toolStripMenuItem_SpareEdit_Click(object sender, EventArgs e)
		{
			SpareForm spareForm = new SpareForm();
			spareForm.ShowDialog();
		}

		private void toolStripMenu_EquipmentEdit_Click(object sender, EventArgs e)
		{
			EquipmentForm equipmentForm = new EquipmentForm();
			equipmentForm.ShowDialog();
		}

		
		private void tabPage_EqRecordCard_Enter(object sender, EventArgs e)
		{
			FillEquipmentCombo();
			
		}

		private void button_SpareToRecCardAdd_Click(object sender, EventArgs e)
		{
			if (comboBox_Equipment.SelectedIndex != -1)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					int tempSpareId = GetSpareByName(comboBox_Spare.SelectedItem.ToString()).Id;
					int tempEquipmentId = GetEquipmentByName(comboBox_Equipment.SelectedItem.ToString()).Id;
					var eqRecordCard = ecc.EqRecordCards
												 .Where(erc => erc.SpareId == tempSpareId &&
																	erc.EquipmentId == tempEquipmentId)
												 .FirstOrDefault();
					if (eqRecordCard == null)
					{
						EqRecordCard eqRecordCardForAdd = new EqRecordCard
						{
							EquipmentId = GetEquipmentByName(comboBox_Equipment.SelectedItem.ToString()).Id,
							SpareId = GetSpareByName(comboBox_Spare.SelectedItem.ToString()).Id,
							SpareCount = (int)numericUpDown_SpareCount.Value,
							EqRecordCardComment = textBox_EqRecordCardComment.Text
						};
						ecc.EqRecordCards.Add(eqRecordCardForAdd);
						ecc.SaveChanges();
						GetAllEqRecordCard();
						MessageBox.Show("Добавлена запасная часть.");
					}
					else MessageBox.Show("Запасная часть уже существует.");
				}
				comboBox_Spare.SelectedIndex = -1;
				numericUpDown_SpareCount.Value = 0;
				textBox_EqRecordCardComment.Text = string.Empty;
			}
			else MessageBox.Show("hhhhhhhhhhhhh");
		}

		private Spare GetSpareByName(string spareName)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Spares
						 .Where(s => s.SpareName == spareName)
						 .FirstOrDefault();
			}
		}
	}
}

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

			timer1.Interval = 1000;
			timer1.Start();


			dataGridView_EqRecordCard.AutoGenerateColumns = true;
			dataGridView_EqRecordCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_EqRecordCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridView_EqRepairRecord.AutoGenerateColumns = true;
			dataGridView_EqRepairRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_EqRepairRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



			


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
											  .Where(erc=>erc.Equipment.EqName==comboBox_RecordEquipment.SelectedItem.ToString())
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
			comboBox_RecordEquipment.Items.Clear();
			comboBox_RepairEquipment.Items.Clear();
			using (EqCardContext ecc = new EqCardContext())
			{
				var equipments = ecc.Equipments.ToList();
				foreach (var equipment in equipments)
				{
					comboBox_RecordEquipment.Items.Add(equipment.EqName);
					comboBox_RepairEquipment.Items.Add(equipment.EqName);
				}
					
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
			if (comboBox_RecordEquipment.SelectedItem != null)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					int tempSpareId = GetSpareByName(comboBox_Spare.SelectedItem.ToString()).Id;
					int tempEquipmentId = GetEquipmentByName(comboBox_RecordEquipment.SelectedItem.ToString()).Id;
					var eqRecordCard = ecc.EqRecordCards
												 .Where(erc => erc.SpareId == tempSpareId &&
																	erc.EquipmentId == tempEquipmentId)
												 .FirstOrDefault();
					if (eqRecordCard == null)
					{
						EqRecordCard eqRecordCardForAdd = new EqRecordCard
						{
							EquipmentId = GetEquipmentByName(comboBox_RecordEquipment.SelectedItem.ToString()).Id,
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

		}

		

		private void button_SpareToRecCardEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_EqRecordCard.SelectedRows.Count>0)
			{
				EqRecordCard eqRecordCardForEdit = GetEqRecordCardById(Convert.ToInt32(dataGridView_EqRecordCard.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var eqRecordCard = ecc.EqRecordCards
												 .Where(erc => erc.Id == eqRecordCardForEdit.Id)
												 .FirstOrDefault();
					eqRecordCard.EquipmentId = GetEquipmentByName(comboBox_RecordEquipment.SelectedItem.ToString()).Id;
					eqRecordCard.SpareId = GetSpareByName(comboBox_Spare.SelectedItem.ToString()).Id;
					eqRecordCard.SpareCount = (int)numericUpDown_SpareCount.Value;
					eqRecordCard.EqRecordCardComment = textBox_EqRecordCardComment.Text;
					ecc.SaveChanges();
					GetAllEqRecordCard();
					MessageBox.Show("Запись изменена.");
				}
				comboBox_RecordEquipment.SelectedIndex = -1;
				comboBox_Spare.SelectedIndex = -1;
				numericUpDown_SpareCount.Value = 0;
				textBox_EqRecordCardComment.Text = string.Empty;
			}

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

		private void dataGridView_EqRecordCard_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			EqRecordCard eqRecordCardForEdit = GetEqRecordCardById(Convert.ToInt32(dataGridView_EqRecordCard.CurrentRow.Cells["Id"].Value));
			comboBox_RecordEquipment.SelectedItem = GetEquipmentById(eqRecordCardForEdit.EquipmentId).EqName;
			comboBox_Spare.SelectedItem = GetSpareById(eqRecordCardForEdit.SpareId).SpareName;
			numericUpDown_SpareCount.Value = eqRecordCardForEdit.SpareCount;
			textBox_EqRecordCardComment.Text = eqRecordCardForEdit.EqRecordCardComment;
		}

		private Spare GetSpareById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Spares
						 .Where(s => s.Id == id)
						 .FirstOrDefault();
			}
		}

		private Equipment GetEquipmentById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Equipments
						 .Where(eq => eq.Id == id)
						 .FirstOrDefault();
			}
		}

		private EqRecordCard GetEqRecordCardById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.EqRecordCards
						 .Where(erc => erc.Id == id)
						 .FirstOrDefault();
			}
		}

		private void button_SpareToRecCardDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView_EqRecordCard.SelectedRows.Count>0)
			{
				EqRecordCard eqRecordCardForDelete = GetEqRecordCardById(Convert.ToInt32(dataGridView_EqRecordCard.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var eqRecordCard = ecc.EqRecordCards
												 .Where(erc => erc.EquipmentId == eqRecordCardForDelete.EquipmentId &&
																	erc.SpareId == eqRecordCardForDelete.SpareId &&
																	erc.SpareCount == eqRecordCardForDelete.SpareCount)
												 .FirstOrDefault();
					if (eqRecordCard!=null)
					{
						ecc.EqRecordCards.Remove(eqRecordCard);
						ecc.SaveChanges();
						GetAllEqRecordCard();
						MessageBox.Show("Запись удалена.");
					}
					comboBox_RecordEquipment.SelectedIndex = -1;
					comboBox_Spare.SelectedIndex = -1;
					numericUpDown_SpareCount.Value = 0;
					textBox_EqRecordCardComment.Text = string.Empty;
				}
			}
		}

		private void tabPage_EqRepairRecord_Enter(object sender, EventArgs e)
		{
			FillEquipmentCombo();
		}

		private void comboBox_RepairEquipment_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetAllRepairRecord();
		}

		private void GetAllRepairRecord()
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				var eqRepairRecords = ecc.EqRepairRecords
											  .Where(err => err.Equipment.EqName == comboBox_RepairEquipment.SelectedItem.ToString())
											  .Select(s => new
											  {
												  s.Id,
												  s.RepairDate,
												  s.RepairDescription,
												  s.RepairComment
											  });
				dataGridView_EqRepairRecord.DataSource = eqRepairRecords.ToList();
				dataGridView_EqRepairRecord.Columns[1].HeaderText = "Дата";
				dataGridView_EqRepairRecord.Columns[2].HeaderText = "Описание";
				dataGridView_EqRepairRecord.Columns[3].HeaderText = "Примечания";
			}
		}

		private void button_RepairAdd_Click(object sender, EventArgs e)
		{
			if (comboBox_RepairEquipment.SelectedItem != null)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					EqRepairRecord eqRepairRecord = new EqRepairRecord
					{
						RepairDate = DateTime.Now,
						RepairDescription = textBox_RepairDescription.Text,
						RepairComment = textBox_RepairComment.Text,
						EquipmentId = GetEquipmentByName(comboBox_RepairEquipment.SelectedItem.ToString()).Id
					};
					ecc.EqRepairRecords.Add(eqRepairRecord);
					ecc.SaveChanges();
					GetAllRepairRecord();
					MessageBox.Show("Запись добавлена.");
				}
				textBox_RepairDescription.Text = string.Empty;
				textBox_RepairComment.Text = string.Empty;
			}
		}

		private void dataGridView_EqRepairRecord_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			EqRepairRecord eqRepairRecordForEdit = GetRepairRecordById(Convert.ToInt32(dataGridView_EqRepairRecord.CurrentRow.Cells["Id"].Value));
			comboBox_RepairEquipment.SelectedItem = GetEquipmentById(eqRepairRecordForEdit.EquipmentId).EqName;
			textBox_RepairDescription.Text = eqRepairRecordForEdit.RepairDescription;
			textBox_RepairComment.Text = eqRepairRecordForEdit.RepairComment;
		}

		private EqRepairRecord GetRepairRecordById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.EqRepairRecords
						 .Where(err => err.Id == id)
						 .FirstOrDefault();
			}
		}

		private void button_RepairEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_EqRepairRecord.SelectedRows.Count > 0)
			{
				EqRepairRecord eqRepairRecordForEdit = GetRepairRecordById(Convert.ToInt32(dataGridView_EqRepairRecord.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var eqRepairRecord = ecc.EqRepairRecords
													.Where(err => err.Id == eqRepairRecordForEdit.Id)
													.FirstOrDefault();
					eqRepairRecord.RepairDescription = textBox_RepairDescription.Text;
					eqRepairRecord.RepairComment = textBox_RepairComment.Text;
					ecc.SaveChanges();
					GetAllRepairRecord();
					MessageBox.Show("Запись изменена.");
				}
				textBox_RepairDescription.Text = string.Empty;
				textBox_RepairComment.Text = string.Empty;
			}


			
		}

		private void button_RepairDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView_EqRepairRecord.SelectedRows.Count > 0)
			{
				EqRepairRecord eqRepairRecordForDelete = GetRepairRecordById(Convert.ToInt32(dataGridView_EqRepairRecord.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var eqRepairRecord = ecc.EqRepairRecords
													.Where(err => err.Id == eqRepairRecordForDelete.Id)
													.FirstOrDefault();
					ecc.EqRepairRecords.Remove(eqRepairRecord);
					ecc.SaveChanges();
					GetAllRepairRecord();
					MessageBox.Show("Запись удалена.");
				}
				textBox_RepairDescription.Text = string.Empty;
				textBox_RepairComment.Text = string.Empty;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
			toolStripStatusLabel_Date.Text = DateTime.Now.ToLongDateString();
			toolStripStatusLabel_Day.Text = DateTime.Now.DayOfWeek.ToString();
		}
	}
}

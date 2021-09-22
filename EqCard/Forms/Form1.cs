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
			


		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			FillEquipmentCombo();
			
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

		//private string GetEquipmentByName(string eqName)
		//{
		//	using (EqCardContext ecc = new EqCardContext())
		//	{
		//		return ecc.Equipments
		//				 .Where(eq => eq.EqName == eqName)
		//				 .FirstOrDefault().EqName;
		//	}
		//}

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

		
	}
}

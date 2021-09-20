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


			dataGridView_EqRepairRecord.AutoGenerateColumns = true;
			dataGridView_EqRepairRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_EqRepairRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			

			dataGridView_Equipment.AutoGenerateColumns = true;
			dataGridView_Equipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_Equipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridView_Spare.AutoGenerateColumns = true;
			dataGridView_Spare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_Spare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridView_SpareCategory.AutoGenerateColumns = true;
			dataGridView_SpareCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_SpareCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			
			


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetAllEqRepairRecord(dataGridView_EqRepairRecord);

			
			GetAllEquipment(dataGridView_Equipment);

			GetAllStorage(dataGridView_Spare);
			GetAllSpareCategory(dataGridView_SpareCategory);

			

		}

		private void GetAllEqRepairRecord(DataGridView dataGridView_EqRepairRecord)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				dataGridView_EqRepairRecord.DataSource = ecc.EqRepairRecords.ToList();
			}
		}

		

		private void GetAllEquipment(DataGridView dataGridView_Equipment)  //  получение списка оборудования
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				dataGridView_Equipment.DataSource = ecc.Equipments.ToList();
			}
		}

		private void GetAllStorage(DataGridView dataGridView_Spare)  // получение списка склада
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				dataGridView_Spare.DataSource = ecc.Spares.ToList();
			}
		}

		private void GetAllSpareCategory(DataGridView dataGridView_SpareCategory)  // получение списка категорий оборудования
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				dataGridView_SpareCategory.DataSource = ecc.SpareCategories.ToList();
			}
		}

		private void toolStripMenu_Location_Click(object sender, EventArgs e)
		{
			LocationForm locationForm = new LocationForm();
			locationForm.ShowDialog();
		}
	}
}

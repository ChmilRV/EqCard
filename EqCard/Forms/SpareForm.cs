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
	public partial class SpareForm : Form
	{
		public SpareForm()
		{
			InitializeComponent();

			Text = "Запасные части";
			dataGridView_Spare.AutoGenerateColumns = true;
			dataGridView_Spare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_Spare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}

		private void SpareForm_Load(object sender, EventArgs e)
		{
			GetAllSpare(dataGridView_Spare);
			FillSpareCategoryCombo();
		}

		private void GetAllSpare(DataGridView dataGridView_Spare)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				var spare = ecc.Spares
					.Select(s=>new
					{
						s.Id,
						s.SpareName,
						s.SpareCategories.CategoryName,
						s.NumberInStorage,
						s.SpareComment
					});
				dataGridView_Spare.DataSource = spare.ToList();
				dataGridView_Spare.Columns[1].HeaderText = "Название";
				dataGridView_Spare.Columns[2].HeaderText = "Категория";
				dataGridView_Spare.Columns[3].HeaderText = "Склад, шт";
				dataGridView_Spare.Columns[4].HeaderText = "Примечания";
			}
		}


		private void FillSpareCategoryCombo()
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				var spareCategories = ecc.SpareCategories.ToList();
				foreach (var spareCategory in spareCategories)
					comboBox_SpareCategory.Items.Add(spareCategory.CategoryName);
			}
		}


		private void button_SpareAdd_Click(object sender, EventArgs e)
		{
			if (textBox_SpareName.Text != string.Empty &&
				 comboBox_SpareCategory.SelectedItem != null &&
				 numericUpDown_SpareInStorage.Value >= 0)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					var spare = ecc.Spares
						.Where(s => s.SpareName == textBox_SpareName.Text &&
									 s.SpareCategories.CategoryName == comboBox_SpareCategory.SelectedItem.ToString())
						.FirstOrDefault();
					if (spare == null)
					{
						Spare spareForAdd = new Spare
						{
							SpareName = textBox_SpareName.Text,
							SpareCategoryId = GetSpareCategoryIdByName(comboBox_SpareCategory.SelectedItem.ToString()),
							NumberInStorage = (int)numericUpDown_SpareInStorage.Value,
							SpareComment = textBox_SpareComment.Text
						};
						ecc.Spares.Add(spareForAdd);
						ecc.SaveChanges();
						GetAllSpare(dataGridView_Spare);
						MessageBox.Show("Добавлена запасная часть.");
					}
					else MessageBox.Show("Запасная часть уже существует.");

				}
				textBox_SpareName.Text = string.Empty;
				comboBox_SpareCategory.SelectedIndex = -1;
				numericUpDown_SpareInStorage.Value = 0;
				textBox_SpareComment.Text = string.Empty;
			}
			else MessageBox.Show("Введите название запасной части.");
		}

		private int GetSpareCategoryIdByName(string categoryName)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.SpareCategories
						 .Where(sc => sc.CategoryName == categoryName)
						 .FirstOrDefault().Id;
			}
		}

		private void button_SpareEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_Spare.SelectedRows.Count>0)
			{
				Spare spareForEdit = GetSpareById(Convert.ToInt32(dataGridView_Spare.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var spare = ecc.Spares.Where(sc => sc.Id == spareForEdit.Id).FirstOrDefault();
					spare.SpareName = textBox_SpareName.Text;
					spare.NumberInStorage = (int)numericUpDown_SpareInStorage.Value;
					spare.SpareComment = textBox_SpareComment.Text;
					spare.SpareCategoryId = GetSpareCategoryIdByName(comboBox_SpareCategory.SelectedItem.ToString());
					ecc.SaveChanges();
					GetAllSpare(dataGridView_Spare);
					MessageBox.Show("Запасная часть изменена.");
				}
				textBox_SpareName.Text = string.Empty;
				comboBox_SpareCategory.SelectedIndex = -1;
				numericUpDown_SpareInStorage.Value = 0;
				textBox_SpareComment.Text = string.Empty;
			}
		}

		private void button_SpareDelete_Click(object sender, EventArgs e)
		{

		}

		private void button_SpareExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dataGridView_Spare_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Spare spareForEdit = GetSpareById(Convert.ToInt32(dataGridView_Spare.CurrentRow.Cells["Id"].Value));
			textBox_SpareName.Text = spareForEdit.SpareName;
			comboBox_SpareCategory.SelectedItem = GetSpareCategoryById(spareForEdit.SpareCategoryId);
			numericUpDown_SpareInStorage.Value = spareForEdit.NumberInStorage;
			textBox_SpareComment.Text = spareForEdit.SpareComment;
		}


		private object GetSpareCategoryById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.SpareCategories.Where(sc => sc.Id == id).FirstOrDefault().CategoryName;
			}
		}

		private Spare GetSpareById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.Spares.Find(id);
			}
		}
	}
}

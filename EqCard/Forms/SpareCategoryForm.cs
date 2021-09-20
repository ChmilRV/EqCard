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
	public partial class SpareCategoryForm : Form
	{
		public SpareCategoryForm()
		{
			InitializeComponent();

			dataGridView_SpareCategory.AutoGenerateColumns = true;
			dataGridView_SpareCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_SpareCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Text = "Категории запчастей";
			
		}

		private void SpareCategoryForm_Load(object sender, EventArgs e)
		{
			GetAllSpareCategory(dataGridView_SpareCategory);
		}


		private void GetAllSpareCategory(DataGridView dataGridView_SpareCategory)  // получение списка категорий оборудования
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				//var locations = ecc.Locations.
				//	Select(l => new 
				//	{ 
				//		l.LocationName,
				//		l.LocationComment
				//	});
				var spareCategories = ecc.SpareCategories;

				dataGridView_SpareCategory.DataSource = spareCategories.ToList();
				//dataGridView_Location.Columns[0].HeaderText = "Id";
				//dataGridView_Location.Columns[0].Width = 20;
				dataGridView_SpareCategory.Columns[1].HeaderText = "Название";
				dataGridView_SpareCategory.Columns[2].HeaderText = "Примечание";
			}
		}

		private void button_SpareCategoryAdd_Click(object sender, EventArgs e)
		{
			if (textBox_SpareCategoryName.Text != string.Empty)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					var spareCategory = ecc.SpareCategories
						.Where(sc => sc.CategoryName == textBox_SpareCategoryName.Text)
						.FirstOrDefault();
					if (spareCategory == null)
					{
						SpareCategory spareCategoryForAdd = new SpareCategory
						{
							CategoryName = textBox_SpareCategoryName.Text,
							SpareCategoryComment = textBox_SpareCategoryComment.Text
						};
						ecc.SpareCategories.Add(spareCategoryForAdd);
						ecc.SaveChanges();
						GetAllSpareCategory(dataGridView_SpareCategory);
						MessageBox.Show("Добавлена новая категория.");
					}
					else MessageBox.Show("Категория существует.");
				}
				textBox_SpareCategoryName.Text = string.Empty;
				textBox_SpareCategoryComment.Text = string.Empty;
			}
			else MessageBox.Show("Введите название категории.");
		}

		private void button_SpareCategoryEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView_SpareCategory.SelectedRows.Count > 0)
			{
				SpareCategory spareCategoryForEdit = GetSpareCategoryById(Convert.ToInt32(dataGridView_SpareCategory.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var spareCategory = ecc.SpareCategories
						.Where(sc => sc.Id == spareCategoryForEdit.Id)
						.FirstOrDefault();
					spareCategory.CategoryName = textBox_SpareCategoryName.Text;
					spareCategory.SpareCategoryComment = textBox_SpareCategoryComment.Text;
					ecc.SaveChanges();
					GetAllSpareCategory(dataGridView_SpareCategory);
					MessageBox.Show("Категория изменена.");
				}
				textBox_SpareCategoryName.Text = string.Empty;
				textBox_SpareCategoryComment.Text = string.Empty;
			}
		}

		private void button_SpareCategoryDelete_Click(object sender, EventArgs e)
		{
			if(dataGridView_SpareCategory.SelectedRows.Count > 0)
			{
				SpareCategory spareCategoryForDelete = GetSpareCategoryById(Convert.ToInt32(dataGridView_SpareCategory.CurrentRow.Cells["Id"].Value));
				using (EqCardContext ecc = new EqCardContext())
				{
					var spareCategory = ecc.SpareCategories
						.Where(sc => sc.CategoryName == spareCategoryForDelete.CategoryName &&
										sc.SpareCategoryComment == spareCategoryForDelete.SpareCategoryComment)
						.FirstOrDefault();
					if (spareCategory != null)
					{
						ecc.SpareCategories.Remove(spareCategory);
						ecc.SaveChanges();
						GetAllSpareCategory(dataGridView_SpareCategory);
						MessageBox.Show("Категория удалена.");
					}
					textBox_SpareCategoryName.Text = string.Empty;
					textBox_SpareCategoryComment.Text = string.Empty;
				}
			}
		}

		private SpareCategory GetSpareCategoryById(int id)
		{
			using (EqCardContext ecc = new EqCardContext())
			{
				return ecc.SpareCategories.Find(id);
			}
		}

		private void button_SpareCategoryExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dataGridView_SpareCategory_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SpareCategory spareCategoryForEdit = GetSpareCategoryById(Convert.ToInt32(dataGridView_SpareCategory.CurrentRow.Cells["Id"].Value));
			textBox_SpareCategoryName.Text = spareCategoryForEdit.CategoryName;
			textBox_SpareCategoryComment.Text = spareCategoryForEdit.SpareCategoryComment;
		}

		
	}
}

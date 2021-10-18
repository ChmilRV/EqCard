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
	public partial class SpareReportForm : Form
	{
		public SpareReportForm()
		{
			InitializeComponent();
		}

		private void SpareReportForm_Load(object sender, EventArgs e)
		{
			FillSpareCategoryCombo();
		}

		private void FillSpareCategoryCombo()
		{
			comboBox_SpareCategoryForReport.Items.Clear();
			using (EqCardContext ecc = new EqCardContext())
			{
				var spareCategories = ecc.SpareCategories.ToList();
				foreach (var sc in spareCategories)
				{
					comboBox_SpareCategoryForReport.Items.Add(sc.CategoryName);
				}
			}
		}

		private void button_SpareRecordFormClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_SpareReportGenerate_Click(object sender, EventArgs e)
		{
			if (checkBox_CheckAllSpareCategories.Checked)
			{
				richTextBox_SpareRecord.Text = MakeReportByAllSpareCategories();
			}
			else
			{
				richTextBox_SpareRecord.Text = MakeReportBySelectedSpareCategory();
			}
		}

		private string MakeReportByAllSpareCategories()
		{
			string reportString = string.Empty;
			using (EqCardContext ecc1 = new EqCardContext())
			{
				var categoryList = ecc1.SpareCategories.ToList();
				foreach (var category in categoryList)
				{
					using (EqCardContext ecc2 = new EqCardContext())
					{
						var spares = ecc2.Spares
														  .Where(sp => sp.SpareCategoryId == category.Id)
														  .Select(s => new
														  {
															  s.SpareName,
															  s.NumberInStorage
														  });
						reportString += $"Отчет по категории {category.CategoryName} от {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n";
						foreach (var spare in spares)
						{
							reportString += $"Название {spare.SpareName} \t Количество {spare.NumberInStorage}\n";
						}
					}


				}
			}
			return reportString;
		}

		private string MakeReportBySelectedSpareCategory()
		{
			string reportString = string.Empty;
			if (comboBox_SpareCategoryForReport.SelectedItem != null)
			{
				using (EqCardContext ecc = new EqCardContext())
				{
					var spares = ecc.Spares
											  .Where(sp => sp.SpareCategories.CategoryName == comboBox_SpareCategoryForReport.SelectedItem.ToString())
											  .Select(s => new
											  {
												  s.SpareName,
												  s.NumberInStorage
											  });
					reportString = $"Отчет по категории: {comboBox_SpareCategoryForReport.SelectedItem} от {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n";
					foreach (var spare in spares)
					{
						reportString += $"Название {spare.SpareName} \t Количество {spare.NumberInStorage}\n";
					}
				}
			}
			return reportString;
		}

		private void comboBox_SpareCategoryForReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkBox_CheckAllSpareCategories.Checked = false;
		}

		private void button_SpareReportSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.DefaultExt = "*.rtf";
			saveFileDialog1.Filter = "RTF Files|*.rtf";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox_SpareRecord.SaveFile(saveFileDialog1.FileName);
			}
		}
	}
}

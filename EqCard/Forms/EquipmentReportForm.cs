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
	public partial class EquipmentReportForm : Form
	{
		public EquipmentReportForm()
		{
			InitializeComponent();


		}

		private void EquipmentReportForm_Load(object sender, EventArgs e)
		{
			FillEquipmentCombo();
		}

		private void FillEquipmentCombo()
		{
			comboBox_EquipmentForReport.Items.Clear();
			using (EqCardContext ecc = new EqCardContext())
			{
				var equipments = ecc.Equipments.ToList();
				foreach (var equipment in equipments)
				{
					comboBox_EquipmentForReport.Items.Add(equipment.EqName);
				}
			}
		}

		private void button_EquipmentReportFormClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_EquipmentReportGenerate_Click(object sender, EventArgs e)
		{
			string reportString = string.Empty;
			if (comboBox_EquipmentForReport.SelectedItem != null)
			{

				using (EqCardContext ecc = new EqCardContext())
				{
					//int tempEquipmentId = GetEquipmentByName(comboBox_EquipmentForReport.SelectedItem.ToString()).Id;

					var eqRecordCards = ecc.EqRecordCards
											  .Where(erc => erc.Equipment.EqName == comboBox_EquipmentForReport.SelectedItem.ToString())
											  .Select(s => new
											  {
												  s.Spare.SpareName,
												  s.SpareCount
											  });

					reportString = $"Отчет по оборудованию {comboBox_EquipmentForReport.SelectedItem}\n";

					foreach (var erc in eqRecordCards)
					{
						reportString += $"Название {erc.SpareName} \t Количество {erc.SpareCount}\n";
					}



				}
				richTextBox_EquipmentReport.Text = reportString;
			}

		}

		private void button_EquipmentReportSave_Click(object sender, EventArgs e)
		{
			//SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.DefaultExt = "*.rtf";
			saveFileDialog1.Filter = "RTF Files|*.rtf";

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox_EquipmentReport.SaveFile(saveFileDialog1.FileName);
			}





		}

		//private Equipment GetEquipmentByName(string eqName)
		//{
		//	using (EqCardContext ecc = new EqCardContext())
		//	{
		//		return ecc.Equipments
		//				 .Where(eq => eq.EqName == eqName)
		//				 .FirstOrDefault();
		//	}
		//}
	}
}


namespace EqCard.Forms
{
	partial class SpareReportForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox_SpareRecord = new System.Windows.Forms.RichTextBox();
			this.button_SpareRecordFormClose = new System.Windows.Forms.Button();
			this.comboBox_SpareCategoryForReport = new System.Windows.Forms.ComboBox();
			this.checkBox_CheckAllSpareCategories = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_SpareReportGenerate = new System.Windows.Forms.Button();
			this.button_SpareReportSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox_SpareRecord
			// 
			this.richTextBox_SpareRecord.Location = new System.Drawing.Point(12, 64);
			this.richTextBox_SpareRecord.Name = "richTextBox_SpareRecord";
			this.richTextBox_SpareRecord.Size = new System.Drawing.Size(760, 428);
			this.richTextBox_SpareRecord.TabIndex = 0;
			this.richTextBox_SpareRecord.Text = "";
			// 
			// button_SpareRecordFormClose
			// 
			this.button_SpareRecordFormClose.Location = new System.Drawing.Point(697, 517);
			this.button_SpareRecordFormClose.Name = "button_SpareRecordFormClose";
			this.button_SpareRecordFormClose.Size = new System.Drawing.Size(75, 23);
			this.button_SpareRecordFormClose.TabIndex = 1;
			this.button_SpareRecordFormClose.Text = "Закрыть";
			this.button_SpareRecordFormClose.UseVisualStyleBackColor = true;
			this.button_SpareRecordFormClose.Click += new System.EventHandler(this.button_SpareRecordFormClose_Click);
			// 
			// comboBox_SpareCategoryForReport
			// 
			this.comboBox_SpareCategoryForReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_SpareCategoryForReport.FormattingEnabled = true;
			this.comboBox_SpareCategoryForReport.Location = new System.Drawing.Point(158, 23);
			this.comboBox_SpareCategoryForReport.Name = "comboBox_SpareCategoryForReport";
			this.comboBox_SpareCategoryForReport.Size = new System.Drawing.Size(367, 21);
			this.comboBox_SpareCategoryForReport.TabIndex = 2;
			this.comboBox_SpareCategoryForReport.SelectedIndexChanged += new System.EventHandler(this.comboBox_SpareCategoryForReport_SelectedIndexChanged);
			// 
			// checkBox_CheckAllSpareCategories
			// 
			this.checkBox_CheckAllSpareCategories.AutoSize = true;
			this.checkBox_CheckAllSpareCategories.Location = new System.Drawing.Point(546, 26);
			this.checkBox_CheckAllSpareCategories.Name = "checkBox_CheckAllSpareCategories";
			this.checkBox_CheckAllSpareCategories.Size = new System.Drawing.Size(91, 17);
			this.checkBox_CheckAllSpareCategories.TabIndex = 3;
			this.checkBox_CheckAllSpareCategories.Text = "Выбрать все";
			this.checkBox_CheckAllSpareCategories.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Категория";
			// 
			// button_SpareReportGenerate
			// 
			this.button_SpareReportGenerate.Location = new System.Drawing.Point(668, 22);
			this.button_SpareReportGenerate.Name = "button_SpareReportGenerate";
			this.button_SpareReportGenerate.Size = new System.Drawing.Size(104, 23);
			this.button_SpareReportGenerate.TabIndex = 5;
			this.button_SpareReportGenerate.Text = "Создать отчет";
			this.button_SpareReportGenerate.UseVisualStyleBackColor = true;
			this.button_SpareReportGenerate.Click += new System.EventHandler(this.button_SpareReportGenerate_Click);
			// 
			// button_SpareReportSave
			// 
			this.button_SpareReportSave.Location = new System.Drawing.Point(537, 517);
			this.button_SpareReportSave.Name = "button_SpareReportSave";
			this.button_SpareReportSave.Size = new System.Drawing.Size(100, 23);
			this.button_SpareReportSave.TabIndex = 6;
			this.button_SpareReportSave.Text = "Сохранить";
			this.button_SpareReportSave.UseVisualStyleBackColor = true;
			this.button_SpareReportSave.Click += new System.EventHandler(this.button_SpareReportSave_Click);
			// 
			// SpareReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.button_SpareReportSave);
			this.Controls.Add(this.button_SpareReportGenerate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox_CheckAllSpareCategories);
			this.Controls.Add(this.comboBox_SpareCategoryForReport);
			this.Controls.Add(this.button_SpareRecordFormClose);
			this.Controls.Add(this.richTextBox_SpareRecord);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SpareReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Отчет по запчастям";
			this.Load += new System.EventHandler(this.SpareReportForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox_SpareRecord;
		private System.Windows.Forms.Button button_SpareRecordFormClose;
		private System.Windows.Forms.ComboBox comboBox_SpareCategoryForReport;
		private System.Windows.Forms.CheckBox checkBox_CheckAllSpareCategories;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_SpareReportGenerate;
		private System.Windows.Forms.Button button_SpareReportSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}
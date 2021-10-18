
namespace EqCard.Forms
{
	partial class EquipmentReportForm
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
			this.richTextBox_EquipmentReport = new System.Windows.Forms.RichTextBox();
			this.button_EquipmentReportFormClose = new System.Windows.Forms.Button();
			this.comboBox_EquipmentForReport = new System.Windows.Forms.ComboBox();
			this.button_EquipmentReportGenerate = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button_EquipmentReportSave = new System.Windows.Forms.Button();
			this.checkBox_CheckAllEquipments = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox_EquipmentReport
			// 
			this.richTextBox_EquipmentReport.Location = new System.Drawing.Point(12, 68);
			this.richTextBox_EquipmentReport.Name = "richTextBox_EquipmentReport";
			this.richTextBox_EquipmentReport.Size = new System.Drawing.Size(760, 432);
			this.richTextBox_EquipmentReport.TabIndex = 0;
			this.richTextBox_EquipmentReport.Text = "";
			// 
			// button_EquipmentReportFormClose
			// 
			this.button_EquipmentReportFormClose.Location = new System.Drawing.Point(697, 526);
			this.button_EquipmentReportFormClose.Name = "button_EquipmentReportFormClose";
			this.button_EquipmentReportFormClose.Size = new System.Drawing.Size(75, 23);
			this.button_EquipmentReportFormClose.TabIndex = 1;
			this.button_EquipmentReportFormClose.Text = "Закрыть";
			this.button_EquipmentReportFormClose.UseVisualStyleBackColor = true;
			this.button_EquipmentReportFormClose.Click += new System.EventHandler(this.button_EquipmentReportFormClose_Click);
			// 
			// comboBox_EquipmentForReport
			// 
			this.comboBox_EquipmentForReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_EquipmentForReport.FormattingEnabled = true;
			this.comboBox_EquipmentForReport.Location = new System.Drawing.Point(110, 23);
			this.comboBox_EquipmentForReport.Name = "comboBox_EquipmentForReport";
			this.comboBox_EquipmentForReport.Size = new System.Drawing.Size(395, 21);
			this.comboBox_EquipmentForReport.TabIndex = 2;
			this.comboBox_EquipmentForReport.SelectedIndexChanged += new System.EventHandler(this.comboBox_EquipmentForReport_SelectedIndexChanged);
			// 
			// button_EquipmentReportGenerate
			// 
			this.button_EquipmentReportGenerate.Location = new System.Drawing.Point(657, 27);
			this.button_EquipmentReportGenerate.Name = "button_EquipmentReportGenerate";
			this.button_EquipmentReportGenerate.Size = new System.Drawing.Size(115, 23);
			this.button_EquipmentReportGenerate.TabIndex = 3;
			this.button_EquipmentReportGenerate.Text = "Создать отчет";
			this.button_EquipmentReportGenerate.UseVisualStyleBackColor = true;
			this.button_EquipmentReportGenerate.Click += new System.EventHandler(this.button_EquipmentReportGenerate_Click);
			// 
			// button_EquipmentReportSave
			// 
			this.button_EquipmentReportSave.Location = new System.Drawing.Point(514, 526);
			this.button_EquipmentReportSave.Name = "button_EquipmentReportSave";
			this.button_EquipmentReportSave.Size = new System.Drawing.Size(109, 23);
			this.button_EquipmentReportSave.TabIndex = 4;
			this.button_EquipmentReportSave.Text = "Сохранить";
			this.button_EquipmentReportSave.UseVisualStyleBackColor = true;
			this.button_EquipmentReportSave.Click += new System.EventHandler(this.button_EquipmentReportSave_Click);
			// 
			// checkBox_CheckAllEquipments
			// 
			this.checkBox_CheckAllEquipments.AutoSize = true;
			this.checkBox_CheckAllEquipments.Location = new System.Drawing.Point(532, 25);
			this.checkBox_CheckAllEquipments.Name = "checkBox_CheckAllEquipments";
			this.checkBox_CheckAllEquipments.Size = new System.Drawing.Size(91, 17);
			this.checkBox_CheckAllEquipments.TabIndex = 5;
			this.checkBox_CheckAllEquipments.Text = "Выбрать все";
			this.checkBox_CheckAllEquipments.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Оборудование:";
			// 
			// EquipmentReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox_CheckAllEquipments);
			this.Controls.Add(this.button_EquipmentReportSave);
			this.Controls.Add(this.button_EquipmentReportGenerate);
			this.Controls.Add(this.comboBox_EquipmentForReport);
			this.Controls.Add(this.button_EquipmentReportFormClose);
			this.Controls.Add(this.richTextBox_EquipmentReport);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EquipmentReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Отчет по оборудованию";
			this.Load += new System.EventHandler(this.EquipmentReportForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox_EquipmentReport;
		private System.Windows.Forms.Button button_EquipmentReportFormClose;
		private System.Windows.Forms.ComboBox comboBox_EquipmentForReport;
		private System.Windows.Forms.Button button_EquipmentReportGenerate;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button_EquipmentReportSave;
		private System.Windows.Forms.CheckBox checkBox_CheckAllEquipments;
		private System.Windows.Forms.Label label1;
	}
}
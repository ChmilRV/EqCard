
namespace EqCard
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView_Location = new System.Windows.Forms.DataGridView();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage_Equipment = new System.Windows.Forms.TabPage();
			this.tabPage_Storage = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenu_Report = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Storage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView_Spare = new System.Windows.Forms.DataGridView();
			this.dataGridView_Equipment = new System.Windows.Forms.DataGridView();
			this.dataGridView_SpareCategory = new System.Windows.Forms.DataGridView();
			this.tabPage_EqRepairRecord = new System.Windows.Forms.TabPage();
			this.dataGridView_EqRepairRecord = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPage_Equipment.SuspendLayout();
			this.tabPage_Storage.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpareCategory)).BeginInit();
			this.tabPage_EqRepairRecord.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRepairRecord)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Location
			// 
			this.dataGridView_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Location.Location = new System.Drawing.Point(18, 23);
			this.dataGridView_Location.Name = "dataGridView_Location";
			this.dataGridView_Location.Size = new System.Drawing.Size(495, 290);
			this.dataGridView_Location.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage_EqRepairRecord);
			this.tabControl.Controls.Add(this.tabPage_Equipment);
			this.tabControl.Controls.Add(this.tabPage_Storage);
			this.tabControl.Location = new System.Drawing.Point(0, 21);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1192, 424);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage_Equipment
			// 
			this.tabPage_Equipment.Controls.Add(this.dataGridView_Equipment);
			this.tabPage_Equipment.Controls.Add(this.dataGridView_Location);
			this.tabPage_Equipment.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Equipment.Name = "tabPage_Equipment";
			this.tabPage_Equipment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Equipment.Size = new System.Drawing.Size(1184, 398);
			this.tabPage_Equipment.TabIndex = 0;
			this.tabPage_Equipment.Text = "Оборудование";
			this.tabPage_Equipment.UseVisualStyleBackColor = true;
			// 
			// tabPage_Storage
			// 
			this.tabPage_Storage.Controls.Add(this.dataGridView_SpareCategory);
			this.tabPage_Storage.Controls.Add(this.dataGridView_Spare);
			this.tabPage_Storage.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Storage.Name = "tabPage_Storage";
			this.tabPage_Storage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Storage.Size = new System.Drawing.Size(1184, 398);
			this.tabPage_Storage.TabIndex = 1;
			this.tabPage_Storage.Text = "Склад";
			this.tabPage_Storage.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 579);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Report,
            this.toolStripMenu_Edit,
            this.ToolStripMenu_Storage,
            this.toolStripMenuItem_About});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenu_Report
			// 
			this.toolStripMenu_Report.Name = "toolStripMenu_Report";
			this.toolStripMenu_Report.Size = new System.Drawing.Size(51, 20);
			this.toolStripMenu_Report.Text = "Отчет";
			// 
			// toolStripMenu_Edit
			// 
			this.toolStripMenu_Edit.Name = "toolStripMenu_Edit";
			this.toolStripMenu_Edit.Size = new System.Drawing.Size(99, 20);
			this.toolStripMenu_Edit.Text = "Редактировать";
			// 
			// ToolStripMenu_Storage
			// 
			this.ToolStripMenu_Storage.Name = "ToolStripMenu_Storage";
			this.ToolStripMenu_Storage.Size = new System.Drawing.Size(52, 20);
			this.ToolStripMenu_Storage.Text = "Склад";
			// 
			// toolStripMenuItem_About
			// 
			this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
			this.toolStripMenuItem_About.Size = new System.Drawing.Size(94, 20);
			this.toolStripMenuItem_About.Text = "О программе";
			// 
			// dataGridView_Spare
			// 
			this.dataGridView_Spare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Spare.Location = new System.Drawing.Point(18, 16);
			this.dataGridView_Spare.Name = "dataGridView_Spare";
			this.dataGridView_Spare.Size = new System.Drawing.Size(571, 291);
			this.dataGridView_Spare.TabIndex = 0;
			// 
			// dataGridView_Equipment
			// 
			this.dataGridView_Equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Equipment.Location = new System.Drawing.Point(567, 23);
			this.dataGridView_Equipment.Name = "dataGridView_Equipment";
			this.dataGridView_Equipment.Size = new System.Drawing.Size(573, 290);
			this.dataGridView_Equipment.TabIndex = 1;
			// 
			// dataGridView_SpareCategory
			// 
			this.dataGridView_SpareCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_SpareCategory.Location = new System.Drawing.Point(634, 16);
			this.dataGridView_SpareCategory.Name = "dataGridView_SpareCategory";
			this.dataGridView_SpareCategory.Size = new System.Drawing.Size(516, 269);
			this.dataGridView_SpareCategory.TabIndex = 1;
			// 
			// tabPage_EqRepairRecord
			// 
			this.tabPage_EqRepairRecord.Controls.Add(this.dataGridView_EqRepairRecord);
			this.tabPage_EqRepairRecord.Location = new System.Drawing.Point(4, 22);
			this.tabPage_EqRepairRecord.Name = "tabPage_EqRepairRecord";
			this.tabPage_EqRepairRecord.Size = new System.Drawing.Size(1184, 398);
			this.tabPage_EqRepairRecord.TabIndex = 2;
			this.tabPage_EqRepairRecord.Text = "Карточка";
			this.tabPage_EqRepairRecord.UseVisualStyleBackColor = true;
			// 
			// dataGridView_EqRepairRecord
			// 
			this.dataGridView_EqRepairRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_EqRepairRecord.Location = new System.Drawing.Point(22, 22);
			this.dataGridView_EqRepairRecord.Name = "dataGridView_EqRepairRecord";
			this.dataGridView_EqRepairRecord.Size = new System.Drawing.Size(882, 277);
			this.dataGridView_EqRepairRecord.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 601);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EqCard";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPage_Equipment.ResumeLayout(false);
			this.tabPage_Storage.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpareCategory)).EndInit();
			this.tabPage_EqRepairRecord.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRepairRecord)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Location;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_Equipment;
		private System.Windows.Forms.TabPage tabPage_Storage;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Report;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Storage;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
		private System.Windows.Forms.DataGridView dataGridView_Spare;
		private System.Windows.Forms.DataGridView dataGridView_Equipment;
		private System.Windows.Forms.DataGridView dataGridView_SpareCategory;
		private System.Windows.Forms.TabPage tabPage_EqRepairRecord;
		private System.Windows.Forms.DataGridView dataGridView_EqRepairRecord;
	}
}


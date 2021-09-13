
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
			this.dataGridView_location = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_Equipment = new System.Windows.Forms.TabPage();
			this.tabPage_Storage = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenu_Report = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Storage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_location)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage_Equipment.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView_location
			// 
			this.dataGridView_location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_location.Location = new System.Drawing.Point(79, 45);
			this.dataGridView_location.Name = "dataGridView_location";
			this.dataGridView_location.Size = new System.Drawing.Size(240, 150);
			this.dataGridView_location.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage_Equipment);
			this.tabControl1.Controls.Add(this.tabPage_Storage);
			this.tabControl1.Location = new System.Drawing.Point(0, 21);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(593, 338);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage_Equipment
			// 
			this.tabPage_Equipment.Controls.Add(this.dataGridView_location);
			this.tabPage_Equipment.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Equipment.Name = "tabPage_Equipment";
			this.tabPage_Equipment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Equipment.Size = new System.Drawing.Size(585, 312);
			this.tabPage_Equipment.TabIndex = 0;
			this.tabPage_Equipment.Text = "Оборудование";
			this.tabPage_Equipment.UseVisualStyleBackColor = true;
			// 
			// tabPage_Storage
			// 
			this.tabPage_Storage.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Storage.Name = "tabPage_Storage";
			this.tabPage_Storage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Storage.Size = new System.Drawing.Size(585, 312);
			this.tabPage_Storage.TabIndex = 1;
			this.tabPage_Storage.Text = "Склад";
			this.tabPage_Storage.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_location)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage_Equipment.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_location;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage_Equipment;
		private System.Windows.Forms.TabPage tabPage_Storage;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Report;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Storage;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
	}
}


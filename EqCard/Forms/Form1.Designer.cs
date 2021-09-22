
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage_EqRecordCard = new System.Windows.Forms.TabPage();
			this.comboBox_Equipment = new System.Windows.Forms.ComboBox();
			this.dataGridView_EqRecordCard = new System.Windows.Forms.DataGridView();
			this.tabPage_Equipment = new System.Windows.Forms.TabPage();
			this.tabPage_Storage = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenu_Report = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Equipment = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_EquipmentEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Location = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Spare = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_SpareEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_SpareCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Storage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			this.button_Exit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPage_EqRecordCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRecordCard)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage_EqRecordCard);
			this.tabControl.Controls.Add(this.tabPage_Equipment);
			this.tabControl.Controls.Add(this.tabPage_Storage);
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(672, 424);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage_EqRecordCard
			// 
			this.tabPage_EqRecordCard.Controls.Add(this.button1);
			this.tabPage_EqRecordCard.Controls.Add(this.comboBox_Equipment);
			this.tabPage_EqRecordCard.Controls.Add(this.dataGridView_EqRecordCard);
			this.tabPage_EqRecordCard.Location = new System.Drawing.Point(4, 22);
			this.tabPage_EqRecordCard.Name = "tabPage_EqRecordCard";
			this.tabPage_EqRecordCard.Size = new System.Drawing.Size(664, 398);
			this.tabPage_EqRecordCard.TabIndex = 2;
			this.tabPage_EqRecordCard.Text = "Карточка";
			this.tabPage_EqRecordCard.UseVisualStyleBackColor = true;
			this.tabPage_EqRecordCard.Enter += new System.EventHandler(this.tabPage_EqRecordCard_Enter);
			// 
			// comboBox_Equipment
			// 
			this.comboBox_Equipment.FormattingEnabled = true;
			this.comboBox_Equipment.Location = new System.Drawing.Point(64, 16);
			this.comboBox_Equipment.Name = "comboBox_Equipment";
			this.comboBox_Equipment.Size = new System.Drawing.Size(272, 21);
			this.comboBox_Equipment.TabIndex = 2;
			this.comboBox_Equipment.SelectedIndexChanged += new System.EventHandler(this.comboBox_Equipment_SelectedIndexChanged);
			// 
			// dataGridView_EqRecordCard
			// 
			this.dataGridView_EqRecordCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_EqRecordCard.Location = new System.Drawing.Point(16, 48);
			this.dataGridView_EqRecordCard.Name = "dataGridView_EqRecordCard";
			this.dataGridView_EqRecordCard.Size = new System.Drawing.Size(464, 277);
			this.dataGridView_EqRecordCard.TabIndex = 0;
			// 
			// tabPage_Equipment
			// 
			this.tabPage_Equipment.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Equipment.Name = "tabPage_Equipment";
			this.tabPage_Equipment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Equipment.Size = new System.Drawing.Size(664, 398);
			this.tabPage_Equipment.TabIndex = 0;
			this.tabPage_Equipment.Text = "Оборудование";
			this.tabPage_Equipment.UseVisualStyleBackColor = true;
			// 
			// tabPage_Storage
			// 
			this.tabPage_Storage.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Storage.Name = "tabPage_Storage";
			this.tabPage_Storage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Storage.Size = new System.Drawing.Size(664, 398);
			this.tabPage_Storage.TabIndex = 1;
			this.tabPage_Storage.Text = "Склад";
			this.tabPage_Storage.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
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
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
			this.toolStripMenu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Equipment,
            this.toolStripMenu_Spare});
			this.toolStripMenu_Edit.Name = "toolStripMenu_Edit";
			this.toolStripMenu_Edit.Size = new System.Drawing.Size(99, 20);
			this.toolStripMenu_Edit.Text = "Редактировать";
			// 
			// toolStripMenu_Equipment
			// 
			this.toolStripMenu_Equipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_EquipmentEdit,
            this.toolStripMenu_Location});
			this.toolStripMenu_Equipment.Name = "toolStripMenu_Equipment";
			this.toolStripMenu_Equipment.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenu_Equipment.Text = "Оборудование";
			// 
			// toolStripMenu_EquipmentEdit
			// 
			this.toolStripMenu_EquipmentEdit.Name = "toolStripMenu_EquipmentEdit";
			this.toolStripMenu_EquipmentEdit.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenu_EquipmentEdit.Text = "База оборудования";
			this.toolStripMenu_EquipmentEdit.Click += new System.EventHandler(this.toolStripMenu_EquipmentEdit_Click);
			// 
			// toolStripMenu_Location
			// 
			this.toolStripMenu_Location.Name = "toolStripMenu_Location";
			this.toolStripMenu_Location.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenu_Location.Text = "Расположение";
			this.toolStripMenu_Location.Click += new System.EventHandler(this.toolStripMenu_Location_Click);
			// 
			// toolStripMenu_Spare
			// 
			this.toolStripMenu_Spare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SpareEdit,
            this.toolStripMenu_SpareCategory});
			this.toolStripMenu_Spare.Name = "toolStripMenu_Spare";
			this.toolStripMenu_Spare.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenu_Spare.Text = "Запчасти";
			// 
			// toolStripMenuItem_SpareEdit
			// 
			this.toolStripMenuItem_SpareEdit.Name = "toolStripMenuItem_SpareEdit";
			this.toolStripMenuItem_SpareEdit.Size = new System.Drawing.Size(189, 22);
			this.toolStripMenuItem_SpareEdit.Text = "База запчастей";
			this.toolStripMenuItem_SpareEdit.Click += new System.EventHandler(this.toolStripMenuItem_SpareEdit_Click);
			// 
			// toolStripMenu_SpareCategory
			// 
			this.toolStripMenu_SpareCategory.Name = "toolStripMenu_SpareCategory";
			this.toolStripMenu_SpareCategory.Size = new System.Drawing.Size(189, 22);
			this.toolStripMenu_SpareCategory.Text = "Категории запчастей";
			this.toolStripMenu_SpareCategory.Click += new System.EventHandler(this.toolStripMenu_SpareCategory_Click);
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
			// button_Exit
			// 
			this.button_Exit.Location = new System.Drawing.Point(592, 504);
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.Size = new System.Drawing.Size(75, 23);
			this.button_Exit.TabIndex = 4;
			this.button_Exit.Text = "Выход";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(560, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.button_Exit);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EqCard";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPage_EqRecordCard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRecordCard)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_Equipment;
		private System.Windows.Forms.TabPage tabPage_Storage;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Report;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Storage;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
		private System.Windows.Forms.TabPage tabPage_EqRecordCard;
		private System.Windows.Forms.DataGridView dataGridView_EqRecordCard;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Equipment;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_EquipmentEdit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Location;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Spare;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SpareEdit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_SpareCategory;
		private System.Windows.Forms.Button button_Exit;
		private System.Windows.Forms.ComboBox comboBox_Equipment;
		private System.Windows.Forms.Button button1;
	}
}


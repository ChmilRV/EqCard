
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
			this.components = new System.ComponentModel.Container();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage_EqRecordCard = new System.Windows.Forms.TabPage();
			this.button_SpareToRecCardEdit = new System.Windows.Forms.Button();
			this.button_SpareToRecCardDelete = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_EqRecordCardComment = new System.Windows.Forms.TextBox();
			this.numericUpDown_SpareCount = new System.Windows.Forms.NumericUpDown();
			this.comboBox_Spare = new System.Windows.Forms.ComboBox();
			this.button_SpareToRecCardAdd = new System.Windows.Forms.Button();
			this.comboBox_RecordEquipment = new System.Windows.Forms.ComboBox();
			this.dataGridView_EqRecordCard = new System.Windows.Forms.DataGridView();
			this.tabPage_EqRepairRecord = new System.Windows.Forms.TabPage();
			this.button_RepairDelete = new System.Windows.Forms.Button();
			this.button_RepairEdit = new System.Windows.Forms.Button();
			this.textBox_RepairComment = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_RepairDescription = new System.Windows.Forms.TextBox();
			this.button_RepairAdd = new System.Windows.Forms.Button();
			this.dataGridView_EqRepairRecord = new System.Windows.Forms.DataGridView();
			this.comboBox_RepairEquipment = new System.Windows.Forms.ComboBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_Day = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenu_Reports = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_EquipmentReport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_SpareReport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Equipment = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_EquipmentEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Location = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Spare = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_SpareEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_SpareCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			this.button_Exit = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl.SuspendLayout();
			this.tabPage_EqRecordCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpareCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRecordCard)).BeginInit();
			this.tabPage_EqRepairRecord.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRepairRecord)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage_EqRecordCard);
			this.tabControl.Controls.Add(this.tabPage_EqRepairRecord);
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(784, 480);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage_EqRecordCard
			// 
			this.tabPage_EqRecordCard.Controls.Add(this.button_SpareToRecCardEdit);
			this.tabPage_EqRecordCard.Controls.Add(this.button_SpareToRecCardDelete);
			this.tabPage_EqRecordCard.Controls.Add(this.label3);
			this.tabPage_EqRecordCard.Controls.Add(this.label2);
			this.tabPage_EqRecordCard.Controls.Add(this.label1);
			this.tabPage_EqRecordCard.Controls.Add(this.textBox_EqRecordCardComment);
			this.tabPage_EqRecordCard.Controls.Add(this.numericUpDown_SpareCount);
			this.tabPage_EqRecordCard.Controls.Add(this.comboBox_Spare);
			this.tabPage_EqRecordCard.Controls.Add(this.button_SpareToRecCardAdd);
			this.tabPage_EqRecordCard.Controls.Add(this.comboBox_RecordEquipment);
			this.tabPage_EqRecordCard.Controls.Add(this.dataGridView_EqRecordCard);
			this.tabPage_EqRecordCard.Location = new System.Drawing.Point(4, 22);
			this.tabPage_EqRecordCard.Name = "tabPage_EqRecordCard";
			this.tabPage_EqRecordCard.Size = new System.Drawing.Size(776, 454);
			this.tabPage_EqRecordCard.TabIndex = 2;
			this.tabPage_EqRecordCard.Text = "Учет";
			this.tabPage_EqRecordCard.UseVisualStyleBackColor = true;
			this.tabPage_EqRecordCard.Enter += new System.EventHandler(this.tabPage_EqRecordCard_Enter);
			// 
			// button_SpareToRecCardEdit
			// 
			this.button_SpareToRecCardEdit.Location = new System.Drawing.Point(645, 354);
			this.button_SpareToRecCardEdit.Name = "button_SpareToRecCardEdit";
			this.button_SpareToRecCardEdit.Size = new System.Drawing.Size(75, 23);
			this.button_SpareToRecCardEdit.TabIndex = 28;
			this.button_SpareToRecCardEdit.Text = "Сохранить";
			this.button_SpareToRecCardEdit.UseVisualStyleBackColor = true;
			this.button_SpareToRecCardEdit.Click += new System.EventHandler(this.button_SpareToRecCardEdit_Click);
			// 
			// button_SpareToRecCardDelete
			// 
			this.button_SpareToRecCardDelete.Location = new System.Drawing.Point(645, 383);
			this.button_SpareToRecCardDelete.Name = "button_SpareToRecCardDelete";
			this.button_SpareToRecCardDelete.Size = new System.Drawing.Size(75, 23);
			this.button_SpareToRecCardDelete.TabIndex = 27;
			this.button_SpareToRecCardDelete.Text = "Удалить";
			this.button_SpareToRecCardDelete.UseVisualStyleBackColor = true;
			this.button_SpareToRecCardDelete.Click += new System.EventHandler(this.button_SpareToRecCardDelete_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 344);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Количество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 384);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Примечания";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Название запасной части";
			// 
			// textBox_EqRecordCardComment
			// 
			this.textBox_EqRecordCardComment.Location = new System.Drawing.Point(200, 384);
			this.textBox_EqRecordCardComment.Multiline = true;
			this.textBox_EqRecordCardComment.Name = "textBox_EqRecordCardComment";
			this.textBox_EqRecordCardComment.Size = new System.Drawing.Size(192, 32);
			this.textBox_EqRecordCardComment.TabIndex = 6;
			// 
			// numericUpDown_SpareCount
			// 
			this.numericUpDown_SpareCount.Location = new System.Drawing.Point(200, 344);
			this.numericUpDown_SpareCount.Name = "numericUpDown_SpareCount";
			this.numericUpDown_SpareCount.Size = new System.Drawing.Size(192, 20);
			this.numericUpDown_SpareCount.TabIndex = 5;
			// 
			// comboBox_Spare
			// 
			this.comboBox_Spare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Spare.FormattingEnabled = true;
			this.comboBox_Spare.Location = new System.Drawing.Point(200, 312);
			this.comboBox_Spare.Name = "comboBox_Spare";
			this.comboBox_Spare.Size = new System.Drawing.Size(192, 21);
			this.comboBox_Spare.Sorted = true;
			this.comboBox_Spare.TabIndex = 4;
			// 
			// button_SpareToRecCardAdd
			// 
			this.button_SpareToRecCardAdd.Location = new System.Drawing.Point(645, 314);
			this.button_SpareToRecCardAdd.Name = "button_SpareToRecCardAdd";
			this.button_SpareToRecCardAdd.Size = new System.Drawing.Size(75, 23);
			this.button_SpareToRecCardAdd.TabIndex = 3;
			this.button_SpareToRecCardAdd.Text = "Добавить";
			this.button_SpareToRecCardAdd.UseVisualStyleBackColor = true;
			this.button_SpareToRecCardAdd.Click += new System.EventHandler(this.button_SpareToRecCardAdd_Click);
			// 
			// comboBox_RecordEquipment
			// 
			this.comboBox_RecordEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_RecordEquipment.FormattingEnabled = true;
			this.comboBox_RecordEquipment.Location = new System.Drawing.Point(146, 21);
			this.comboBox_RecordEquipment.Name = "comboBox_RecordEquipment";
			this.comboBox_RecordEquipment.Size = new System.Drawing.Size(272, 21);
			this.comboBox_RecordEquipment.TabIndex = 2;
			this.comboBox_RecordEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBox_Equipment_SelectedIndexChanged);
			// 
			// dataGridView_EqRecordCard
			// 
			this.dataGridView_EqRecordCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_EqRecordCard.Location = new System.Drawing.Point(16, 48);
			this.dataGridView_EqRecordCard.Name = "dataGridView_EqRecordCard";
			this.dataGridView_EqRecordCard.Size = new System.Drawing.Size(704, 240);
			this.dataGridView_EqRecordCard.TabIndex = 0;
			this.dataGridView_EqRecordCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EqRecordCard_CellClick);
			// 
			// tabPage_EqRepairRecord
			// 
			this.tabPage_EqRepairRecord.Controls.Add(this.button_RepairDelete);
			this.tabPage_EqRepairRecord.Controls.Add(this.button_RepairEdit);
			this.tabPage_EqRepairRecord.Controls.Add(this.textBox_RepairComment);
			this.tabPage_EqRepairRecord.Controls.Add(this.label5);
			this.tabPage_EqRepairRecord.Controls.Add(this.label4);
			this.tabPage_EqRepairRecord.Controls.Add(this.textBox_RepairDescription);
			this.tabPage_EqRepairRecord.Controls.Add(this.button_RepairAdd);
			this.tabPage_EqRepairRecord.Controls.Add(this.dataGridView_EqRepairRecord);
			this.tabPage_EqRepairRecord.Controls.Add(this.comboBox_RepairEquipment);
			this.tabPage_EqRepairRecord.Location = new System.Drawing.Point(4, 22);
			this.tabPage_EqRepairRecord.Name = "tabPage_EqRepairRecord";
			this.tabPage_EqRepairRecord.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_EqRepairRecord.Size = new System.Drawing.Size(776, 454);
			this.tabPage_EqRepairRecord.TabIndex = 1;
			this.tabPage_EqRepairRecord.Text = "Обслуживание";
			this.tabPage_EqRepairRecord.UseVisualStyleBackColor = true;
			this.tabPage_EqRepairRecord.Enter += new System.EventHandler(this.tabPage_EqRepairRecord_Enter);
			// 
			// button_RepairDelete
			// 
			this.button_RepairDelete.Location = new System.Drawing.Point(656, 334);
			this.button_RepairDelete.Name = "button_RepairDelete";
			this.button_RepairDelete.Size = new System.Drawing.Size(75, 23);
			this.button_RepairDelete.TabIndex = 11;
			this.button_RepairDelete.Text = "Удалить";
			this.button_RepairDelete.UseVisualStyleBackColor = true;
			this.button_RepairDelete.Click += new System.EventHandler(this.button_RepairDelete_Click);
			// 
			// button_RepairEdit
			// 
			this.button_RepairEdit.Location = new System.Drawing.Point(656, 277);
			this.button_RepairEdit.Name = "button_RepairEdit";
			this.button_RepairEdit.Size = new System.Drawing.Size(75, 23);
			this.button_RepairEdit.TabIndex = 10;
			this.button_RepairEdit.Text = "Сохранить";
			this.button_RepairEdit.UseVisualStyleBackColor = true;
			this.button_RepairEdit.Click += new System.EventHandler(this.button_RepairEdit_Click);
			// 
			// textBox_RepairComment
			// 
			this.textBox_RepairComment.Location = new System.Drawing.Point(144, 352);
			this.textBox_RepairComment.Multiline = true;
			this.textBox_RepairComment.Name = "textBox_RepairComment";
			this.textBox_RepairComment.Size = new System.Drawing.Size(459, 88);
			this.textBox_RepairComment.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 368);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Примечания";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Описание";
			// 
			// textBox_RepairDescription
			// 
			this.textBox_RepairDescription.Location = new System.Drawing.Point(144, 240);
			this.textBox_RepairDescription.Multiline = true;
			this.textBox_RepairDescription.Name = "textBox_RepairDescription";
			this.textBox_RepairDescription.Size = new System.Drawing.Size(459, 88);
			this.textBox_RepairDescription.TabIndex = 6;
			// 
			// button_RepairAdd
			// 
			this.button_RepairAdd.Location = new System.Drawing.Point(656, 232);
			this.button_RepairAdd.Name = "button_RepairAdd";
			this.button_RepairAdd.Size = new System.Drawing.Size(75, 23);
			this.button_RepairAdd.TabIndex = 5;
			this.button_RepairAdd.Text = "Добавить";
			this.button_RepairAdd.UseVisualStyleBackColor = true;
			this.button_RepairAdd.Click += new System.EventHandler(this.button_RepairAdd_Click);
			// 
			// dataGridView_EqRepairRecord
			// 
			this.dataGridView_EqRepairRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_EqRepairRecord.Location = new System.Drawing.Point(24, 56);
			this.dataGridView_EqRepairRecord.Name = "dataGridView_EqRepairRecord";
			this.dataGridView_EqRepairRecord.Size = new System.Drawing.Size(744, 150);
			this.dataGridView_EqRepairRecord.TabIndex = 4;
			this.dataGridView_EqRepairRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EqRepairRecord_CellClick);
			// 
			// comboBox_RepairEquipment
			// 
			this.comboBox_RepairEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_RepairEquipment.FormattingEnabled = true;
			this.comboBox_RepairEquipment.Location = new System.Drawing.Point(118, 20);
			this.comboBox_RepairEquipment.Name = "comboBox_RepairEquipment";
			this.comboBox_RepairEquipment.Size = new System.Drawing.Size(272, 21);
			this.comboBox_RepairEquipment.TabIndex = 3;
			this.comboBox_RepairEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBox_RepairEquipment_SelectedIndexChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Day});
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_Time
			// 
			this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
			this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel_Date
			// 
			this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
			this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel_Day
			// 
			this.toolStripStatusLabel_Day.Name = "toolStripStatusLabel_Day";
			this.toolStripStatusLabel_Day.Size = new System.Drawing.Size(0, 17);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Reports,
            this.toolStripMenu_Edit,
            this.toolStripMenuItem_About});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenu_Reports
			// 
			this.toolStripMenu_Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_EquipmentReport,
            this.toolStripMenuItem_SpareReport});
			this.toolStripMenu_Reports.Name = "toolStripMenu_Reports";
			this.toolStripMenu_Reports.Size = new System.Drawing.Size(60, 20);
			this.toolStripMenu_Reports.Text = "Отчеты";
			// 
			// toolStripMenuItem_EquipmentReport
			// 
			this.toolStripMenuItem_EquipmentReport.Name = "toolStripMenuItem_EquipmentReport";
			this.toolStripMenuItem_EquipmentReport.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem_EquipmentReport.Text = "Оборудование";
			this.toolStripMenuItem_EquipmentReport.Click += new System.EventHandler(this.toolStripMenuItem_EquipmentReport_Click);
			// 
			// toolStripMenuItem_SpareReport
			// 
			this.toolStripMenuItem_SpareReport.Name = "toolStripMenuItem_SpareReport";
			this.toolStripMenuItem_SpareReport.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem_SpareReport.Text = "Запчасти";
			this.toolStripMenuItem_SpareReport.Click += new System.EventHandler(this.toolStripMenuItem_SpareReport_Click);
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
			// toolStripMenuItem_About
			// 
			this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
			this.toolStripMenuItem_About.Size = new System.Drawing.Size(94, 20);
			this.toolStripMenuItem_About.Text = "О программе";
			// 
			// button_Exit
			// 
			this.button_Exit.Location = new System.Drawing.Point(635, 513);
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.Size = new System.Drawing.Size(145, 23);
			this.button_Exit.TabIndex = 4;
			this.button_Exit.Text = "Выход";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			this.tabPage_EqRecordCard.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpareCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRecordCard)).EndInit();
			this.tabPage_EqRepairRecord.ResumeLayout(false);
			this.tabPage_EqRepairRecord.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_EqRepairRecord)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_EqRepairRecord;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Reports;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Edit;
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
		private System.Windows.Forms.ComboBox comboBox_RecordEquipment;
		private System.Windows.Forms.Button button_SpareToRecCardAdd;
		private System.Windows.Forms.ComboBox comboBox_Spare;
		private System.Windows.Forms.TextBox textBox_EqRecordCardComment;
		private System.Windows.Forms.NumericUpDown numericUpDown_SpareCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_SpareToRecCardEdit;
		private System.Windows.Forms.Button button_SpareToRecCardDelete;
		private System.Windows.Forms.ComboBox comboBox_RepairEquipment;
		private System.Windows.Forms.Button button_RepairAdd;
		private System.Windows.Forms.DataGridView dataGridView_EqRepairRecord;
		private System.Windows.Forms.TextBox textBox_RepairDescription;
		private System.Windows.Forms.TextBox textBox_RepairComment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button_RepairEdit;
		private System.Windows.Forms.Button button_RepairDelete;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Day;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_EquipmentReport;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SpareReport;
	}
}


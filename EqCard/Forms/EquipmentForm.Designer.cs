
namespace EqCard.Forms
{
	partial class EquipmentForm
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
			this.dataGridView_Equipment = new System.Windows.Forms.DataGridView();
			this.button_EquipmentEdit = new System.Windows.Forms.Button();
			this.button_EquipmentDelete = new System.Windows.Forms.Button();
			this.button_EquipmentAdd = new System.Windows.Forms.Button();
			this.button_EquipmentExit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_EquipmentComment = new System.Windows.Forms.TextBox();
			this.comboBox_EqLocation = new System.Windows.Forms.ComboBox();
			this.textBox_EqName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Equipment
			// 
			this.dataGridView_Equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Equipment.Location = new System.Drawing.Point(12, 12);
			this.dataGridView_Equipment.Name = "dataGridView_Equipment";
			this.dataGridView_Equipment.Size = new System.Drawing.Size(573, 233);
			this.dataGridView_Equipment.TabIndex = 2;
			this.dataGridView_Equipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Equipment_CellClick);
			// 
			// button_EquipmentEdit
			// 
			this.button_EquipmentEdit.Location = new System.Drawing.Point(487, 305);
			this.button_EquipmentEdit.Name = "button_EquipmentEdit";
			this.button_EquipmentEdit.Size = new System.Drawing.Size(75, 23);
			this.button_EquipmentEdit.TabIndex = 26;
			this.button_EquipmentEdit.Text = "Сохранить";
			this.button_EquipmentEdit.UseVisualStyleBackColor = true;
			this.button_EquipmentEdit.Click += new System.EventHandler(this.button_EquipmentEdit_Click);
			// 
			// button_EquipmentDelete
			// 
			this.button_EquipmentDelete.Location = new System.Drawing.Point(487, 334);
			this.button_EquipmentDelete.Name = "button_EquipmentDelete";
			this.button_EquipmentDelete.Size = new System.Drawing.Size(75, 23);
			this.button_EquipmentDelete.TabIndex = 25;
			this.button_EquipmentDelete.Text = "Удалить";
			this.button_EquipmentDelete.UseVisualStyleBackColor = true;
			this.button_EquipmentDelete.Click += new System.EventHandler(this.button_EquipmentDelete_Click);
			// 
			// button_EquipmentAdd
			// 
			this.button_EquipmentAdd.Location = new System.Drawing.Point(487, 275);
			this.button_EquipmentAdd.Name = "button_EquipmentAdd";
			this.button_EquipmentAdd.Size = new System.Drawing.Size(75, 23);
			this.button_EquipmentAdd.TabIndex = 24;
			this.button_EquipmentAdd.Text = "Добавить";
			this.button_EquipmentAdd.UseVisualStyleBackColor = true;
			this.button_EquipmentAdd.Click += new System.EventHandler(this.button_EquipmentAdd_Click);
			// 
			// button_EquipmentExit
			// 
			this.button_EquipmentExit.Location = new System.Drawing.Point(487, 363);
			this.button_EquipmentExit.Name = "button_EquipmentExit";
			this.button_EquipmentExit.Size = new System.Drawing.Size(75, 23);
			this.button_EquipmentExit.TabIndex = 23;
			this.button_EquipmentExit.Text = "Выход";
			this.button_EquipmentExit.UseVisualStyleBackColor = true;
			this.button_EquipmentExit.Click += new System.EventHandler(this.button_EquipmentExit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 363);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 29;
			this.label4.Text = "Примечания";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 309);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Расположение";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 279);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Название";
			// 
			// textBox_EquipmentComment
			// 
			this.textBox_EquipmentComment.Location = new System.Drawing.Point(103, 348);
			this.textBox_EquipmentComment.Multiline = true;
			this.textBox_EquipmentComment.Name = "textBox_EquipmentComment";
			this.textBox_EquipmentComment.Size = new System.Drawing.Size(240, 60);
			this.textBox_EquipmentComment.TabIndex = 33;
			// 
			// comboBox_EqLocation
			// 
			this.comboBox_EqLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_EqLocation.FormattingEnabled = true;
			this.comboBox_EqLocation.Location = new System.Drawing.Point(103, 309);
			this.comboBox_EqLocation.Name = "comboBox_EqLocation";
			this.comboBox_EqLocation.Size = new System.Drawing.Size(240, 21);
			this.comboBox_EqLocation.Sorted = true;
			this.comboBox_EqLocation.TabIndex = 32;
			// 
			// textBox_EqName
			// 
			this.textBox_EqName.Location = new System.Drawing.Point(103, 276);
			this.textBox_EqName.Name = "textBox_EqName";
			this.textBox_EqName.Size = new System.Drawing.Size(240, 20);
			this.textBox_EqName.TabIndex = 31;
			// 
			// EquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 450);
			this.Controls.Add(this.textBox_EquipmentComment);
			this.Controls.Add(this.comboBox_EqLocation);
			this.Controls.Add(this.textBox_EqName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_EquipmentEdit);
			this.Controls.Add(this.button_EquipmentDelete);
			this.Controls.Add(this.button_EquipmentAdd);
			this.Controls.Add(this.button_EquipmentExit);
			this.Controls.Add(this.dataGridView_Equipment);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EquipmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EquipmentForm";
			this.Load += new System.EventHandler(this.EquipmentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Equipment;
		private System.Windows.Forms.Button button_EquipmentEdit;
		private System.Windows.Forms.Button button_EquipmentDelete;
		private System.Windows.Forms.Button button_EquipmentAdd;
		private System.Windows.Forms.Button button_EquipmentExit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_EquipmentComment;
		private System.Windows.Forms.ComboBox comboBox_EqLocation;
		private System.Windows.Forms.TextBox textBox_EqName;
	}
}
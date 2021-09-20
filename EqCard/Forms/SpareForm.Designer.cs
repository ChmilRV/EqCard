
namespace EqCard.Forms
{
	partial class SpareForm
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
			this.dataGridView_Spare = new System.Windows.Forms.DataGridView();
			this.button_SpareEdit = new System.Windows.Forms.Button();
			this.button_SpareDelete = new System.Windows.Forms.Button();
			this.button_SpareAdd = new System.Windows.Forms.Button();
			this.button_SpareExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_SpareName = new System.Windows.Forms.TextBox();
			this.comboBox_SpareCategory = new System.Windows.Forms.ComboBox();
			this.numericUpDown_SpareInStorage = new System.Windows.Forms.NumericUpDown();
			this.textBox_SpareComment = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpareInStorage)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Spare
			// 
			this.dataGridView_Spare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Spare.Location = new System.Drawing.Point(12, 12);
			this.dataGridView_Spare.Name = "dataGridView_Spare";
			this.dataGridView_Spare.Size = new System.Drawing.Size(544, 200);
			this.dataGridView_Spare.TabIndex = 1;
			this.dataGridView_Spare.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Spare_CellClick);
			// 
			// button_SpareEdit
			// 
			this.button_SpareEdit.Location = new System.Drawing.Point(481, 273);
			this.button_SpareEdit.Name = "button_SpareEdit";
			this.button_SpareEdit.Size = new System.Drawing.Size(75, 23);
			this.button_SpareEdit.TabIndex = 22;
			this.button_SpareEdit.Text = "Сохранить";
			this.button_SpareEdit.UseVisualStyleBackColor = true;
			this.button_SpareEdit.Click += new System.EventHandler(this.button_SpareEdit_Click);
			// 
			// button_SpareDelete
			// 
			this.button_SpareDelete.Location = new System.Drawing.Point(481, 302);
			this.button_SpareDelete.Name = "button_SpareDelete";
			this.button_SpareDelete.Size = new System.Drawing.Size(75, 23);
			this.button_SpareDelete.TabIndex = 21;
			this.button_SpareDelete.Text = "Удалить";
			this.button_SpareDelete.UseVisualStyleBackColor = true;
			this.button_SpareDelete.Click += new System.EventHandler(this.button_SpareDelete_Click);
			// 
			// button_SpareAdd
			// 
			this.button_SpareAdd.Location = new System.Drawing.Point(481, 243);
			this.button_SpareAdd.Name = "button_SpareAdd";
			this.button_SpareAdd.Size = new System.Drawing.Size(75, 23);
			this.button_SpareAdd.TabIndex = 20;
			this.button_SpareAdd.Text = "Добавить";
			this.button_SpareAdd.UseVisualStyleBackColor = true;
			this.button_SpareAdd.Click += new System.EventHandler(this.button_SpareAdd_Click);
			// 
			// button_SpareExit
			// 
			this.button_SpareExit.Location = new System.Drawing.Point(481, 331);
			this.button_SpareExit.Name = "button_SpareExit";
			this.button_SpareExit.Size = new System.Drawing.Size(75, 23);
			this.button_SpareExit.TabIndex = 19;
			this.button_SpareExit.Text = "Выход";
			this.button_SpareExit.UseVisualStyleBackColor = true;
			this.button_SpareExit.Click += new System.EventHandler(this.button_SpareExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Название";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Категория";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 311);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Количество в складе";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 351);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Примечания";
			// 
			// textBox_SpareName
			// 
			this.textBox_SpareName.Location = new System.Drawing.Point(138, 240);
			this.textBox_SpareName.Name = "textBox_SpareName";
			this.textBox_SpareName.Size = new System.Drawing.Size(240, 20);
			this.textBox_SpareName.TabIndex = 27;
			// 
			// comboBox_SpareCategory
			// 
			this.comboBox_SpareCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_SpareCategory.FormattingEnabled = true;
			this.comboBox_SpareCategory.Location = new System.Drawing.Point(138, 273);
			this.comboBox_SpareCategory.Name = "comboBox_SpareCategory";
			this.comboBox_SpareCategory.Size = new System.Drawing.Size(240, 21);
			this.comboBox_SpareCategory.TabIndex = 28;
			// 
			// numericUpDown_SpareInStorage
			// 
			this.numericUpDown_SpareInStorage.Location = new System.Drawing.Point(138, 311);
			this.numericUpDown_SpareInStorage.Name = "numericUpDown_SpareInStorage";
			this.numericUpDown_SpareInStorage.Size = new System.Drawing.Size(240, 20);
			this.numericUpDown_SpareInStorage.TabIndex = 29;
			this.numericUpDown_SpareInStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox_SpareComment
			// 
			this.textBox_SpareComment.Location = new System.Drawing.Point(138, 351);
			this.textBox_SpareComment.Multiline = true;
			this.textBox_SpareComment.Name = "textBox_SpareComment";
			this.textBox_SpareComment.Size = new System.Drawing.Size(240, 60);
			this.textBox_SpareComment.TabIndex = 30;
			// 
			// SpareForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 432);
			this.Controls.Add(this.textBox_SpareComment);
			this.Controls.Add(this.numericUpDown_SpareInStorage);
			this.Controls.Add(this.comboBox_SpareCategory);
			this.Controls.Add(this.textBox_SpareName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_SpareEdit);
			this.Controls.Add(this.button_SpareDelete);
			this.Controls.Add(this.button_SpareAdd);
			this.Controls.Add(this.button_SpareExit);
			this.Controls.Add(this.dataGridView_Spare);
			this.Name = "SpareForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpareForm";
			this.Load += new System.EventHandler(this.SpareForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpareInStorage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Spare;
		private System.Windows.Forms.Button button_SpareEdit;
		private System.Windows.Forms.Button button_SpareDelete;
		private System.Windows.Forms.Button button_SpareAdd;
		private System.Windows.Forms.Button button_SpareExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_SpareName;
		private System.Windows.Forms.ComboBox comboBox_SpareCategory;
		private System.Windows.Forms.NumericUpDown numericUpDown_SpareInStorage;
		private System.Windows.Forms.TextBox textBox_SpareComment;
	}
}
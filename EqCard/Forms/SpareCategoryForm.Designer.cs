
namespace EqCard.Forms
{
	partial class SpareCategoryForm
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
			this.dataGridView_SpareCategory = new System.Windows.Forms.DataGridView();
			this.button_SpareCategoryEdit = new System.Windows.Forms.Button();
			this.button_SpareCategoryDelete = new System.Windows.Forms.Button();
			this.button_SpareCategoryAdd = new System.Windows.Forms.Button();
			this.button_SpareCategoryExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_SpareCategoryComment = new System.Windows.Forms.TextBox();
			this.textBox_SpareCategoryName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpareCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_SpareCategory
			// 
			this.dataGridView_SpareCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_SpareCategory.Location = new System.Drawing.Point(16, 24);
			this.dataGridView_SpareCategory.Name = "dataGridView_SpareCategory";
			this.dataGridView_SpareCategory.Size = new System.Drawing.Size(516, 269);
			this.dataGridView_SpareCategory.TabIndex = 2;
			this.dataGridView_SpareCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SpareCategory_CellClick);
			// 
			// button_SpareCategoryEdit
			// 
			this.button_SpareCategoryEdit.Location = new System.Drawing.Point(440, 358);
			this.button_SpareCategoryEdit.Name = "button_SpareCategoryEdit";
			this.button_SpareCategoryEdit.Size = new System.Drawing.Size(75, 23);
			this.button_SpareCategoryEdit.TabIndex = 18;
			this.button_SpareCategoryEdit.Text = "Сохранить";
			this.button_SpareCategoryEdit.UseVisualStyleBackColor = true;
			this.button_SpareCategoryEdit.Click += new System.EventHandler(this.button_SpareCategoryEdit_Click);
			// 
			// button_SpareCategoryDelete
			// 
			this.button_SpareCategoryDelete.Location = new System.Drawing.Point(440, 387);
			this.button_SpareCategoryDelete.Name = "button_SpareCategoryDelete";
			this.button_SpareCategoryDelete.Size = new System.Drawing.Size(75, 23);
			this.button_SpareCategoryDelete.TabIndex = 17;
			this.button_SpareCategoryDelete.Text = "Удалить";
			this.button_SpareCategoryDelete.UseVisualStyleBackColor = true;
			this.button_SpareCategoryDelete.Click += new System.EventHandler(this.button_SpareCategoryDelete_Click);
			// 
			// button_SpareCategoryAdd
			// 
			this.button_SpareCategoryAdd.Location = new System.Drawing.Point(440, 328);
			this.button_SpareCategoryAdd.Name = "button_SpareCategoryAdd";
			this.button_SpareCategoryAdd.Size = new System.Drawing.Size(75, 23);
			this.button_SpareCategoryAdd.TabIndex = 16;
			this.button_SpareCategoryAdd.Text = "Добавить";
			this.button_SpareCategoryAdd.UseVisualStyleBackColor = true;
			this.button_SpareCategoryAdd.Click += new System.EventHandler(this.button_SpareCategoryAdd_Click);
			// 
			// button_SpareCategoryExit
			// 
			this.button_SpareCategoryExit.Location = new System.Drawing.Point(440, 416);
			this.button_SpareCategoryExit.Name = "button_SpareCategoryExit";
			this.button_SpareCategoryExit.Size = new System.Drawing.Size(75, 23);
			this.button_SpareCategoryExit.TabIndex = 15;
			this.button_SpareCategoryExit.Text = "Выход";
			this.button_SpareCategoryExit.UseVisualStyleBackColor = true;
			this.button_SpareCategoryExit.Click += new System.EventHandler(this.button_SpareCategoryExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 368);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Примечания";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 328);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Название категории";
			// 
			// textBox_SpareCategoryComment
			// 
			this.textBox_SpareCategoryComment.Location = new System.Drawing.Point(136, 360);
			this.textBox_SpareCategoryComment.Multiline = true;
			this.textBox_SpareCategoryComment.Name = "textBox_SpareCategoryComment";
			this.textBox_SpareCategoryComment.Size = new System.Drawing.Size(280, 48);
			this.textBox_SpareCategoryComment.TabIndex = 22;
			// 
			// textBox_SpareCategoryName
			// 
			this.textBox_SpareCategoryName.Location = new System.Drawing.Point(136, 320);
			this.textBox_SpareCategoryName.Name = "textBox_SpareCategoryName";
			this.textBox_SpareCategoryName.Size = new System.Drawing.Size(280, 20);
			this.textBox_SpareCategoryName.TabIndex = 21;
			// 
			// SpareCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 509);
			this.Controls.Add(this.textBox_SpareCategoryComment);
			this.Controls.Add(this.textBox_SpareCategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_SpareCategoryEdit);
			this.Controls.Add(this.button_SpareCategoryDelete);
			this.Controls.Add(this.button_SpareCategoryAdd);
			this.Controls.Add(this.button_SpareCategoryExit);
			this.Controls.Add(this.dataGridView_SpareCategory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SpareCategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SpareCategoryForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpareCategory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_SpareCategory;
		private System.Windows.Forms.Button button_SpareCategoryEdit;
		private System.Windows.Forms.Button button_SpareCategoryDelete;
		private System.Windows.Forms.Button button_SpareCategoryAdd;
		private System.Windows.Forms.Button button_SpareCategoryExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_SpareCategoryComment;
		private System.Windows.Forms.TextBox textBox_SpareCategoryName;
	}
}
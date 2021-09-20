
namespace EqCard.Forms
{
	partial class LocationForm
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
			this.dataGridView_Location = new System.Windows.Forms.DataGridView();
			this.textBox_LocationName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_LocationComment = new System.Windows.Forms.TextBox();
			this.button_LocationEdit = new System.Windows.Forms.Button();
			this.button_LocationDelete = new System.Windows.Forms.Button();
			this.button_LocationAdd = new System.Windows.Forms.Button();
			this.button_LocationExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Location
			// 
			this.dataGridView_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Location.Location = new System.Drawing.Point(8, 8);
			this.dataGridView_Location.Name = "dataGridView_Location";
			this.dataGridView_Location.Size = new System.Drawing.Size(536, 290);
			this.dataGridView_Location.TabIndex = 1;
			this.dataGridView_Location.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Location_CellClick);
			// 
			// textBox_LocationName
			// 
			this.textBox_LocationName.Location = new System.Drawing.Point(120, 312);
			this.textBox_LocationName.Name = "textBox_LocationName";
			this.textBox_LocationName.Size = new System.Drawing.Size(280, 20);
			this.textBox_LocationName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Расположение";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 352);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Примечания";
			// 
			// textBox_LocationComment
			// 
			this.textBox_LocationComment.Location = new System.Drawing.Point(120, 352);
			this.textBox_LocationComment.Multiline = true;
			this.textBox_LocationComment.Name = "textBox_LocationComment";
			this.textBox_LocationComment.Size = new System.Drawing.Size(280, 48);
			this.textBox_LocationComment.TabIndex = 5;
			// 
			// button_LocationEdit
			// 
			this.button_LocationEdit.Location = new System.Drawing.Point(440, 350);
			this.button_LocationEdit.Name = "button_LocationEdit";
			this.button_LocationEdit.Size = new System.Drawing.Size(75, 23);
			this.button_LocationEdit.TabIndex = 14;
			this.button_LocationEdit.Text = "Сохранить";
			this.button_LocationEdit.UseVisualStyleBackColor = true;
			this.button_LocationEdit.Click += new System.EventHandler(this.button_LocationEdit_Click);
			// 
			// button_LocationDelete
			// 
			this.button_LocationDelete.Location = new System.Drawing.Point(440, 379);
			this.button_LocationDelete.Name = "button_LocationDelete";
			this.button_LocationDelete.Size = new System.Drawing.Size(75, 23);
			this.button_LocationDelete.TabIndex = 13;
			this.button_LocationDelete.Text = "Удалить";
			this.button_LocationDelete.UseVisualStyleBackColor = true;
			this.button_LocationDelete.Click += new System.EventHandler(this.button_LocationDelete_Click);
			// 
			// button_LocationAdd
			// 
			this.button_LocationAdd.Location = new System.Drawing.Point(440, 320);
			this.button_LocationAdd.Name = "button_LocationAdd";
			this.button_LocationAdd.Size = new System.Drawing.Size(75, 23);
			this.button_LocationAdd.TabIndex = 12;
			this.button_LocationAdd.Text = "Добавить";
			this.button_LocationAdd.UseVisualStyleBackColor = true;
			this.button_LocationAdd.Click += new System.EventHandler(this.button_LocationAdd_Click);
			// 
			// button_LocationExit
			// 
			this.button_LocationExit.Location = new System.Drawing.Point(440, 408);
			this.button_LocationExit.Name = "button_LocationExit";
			this.button_LocationExit.Size = new System.Drawing.Size(75, 23);
			this.button_LocationExit.TabIndex = 11;
			this.button_LocationExit.Text = "Выход";
			this.button_LocationExit.UseVisualStyleBackColor = true;
			this.button_LocationExit.Click += new System.EventHandler(this.button_LocationExit_Click);
			// 
			// LocationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 498);
			this.Controls.Add(this.button_LocationEdit);
			this.Controls.Add(this.button_LocationDelete);
			this.Controls.Add(this.button_LocationAdd);
			this.Controls.Add(this.button_LocationExit);
			this.Controls.Add(this.textBox_LocationComment);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_LocationName);
			this.Controls.Add(this.dataGridView_Location);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LocationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LocationForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Location;
		private System.Windows.Forms.TextBox textBox_LocationName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_LocationComment;
		private System.Windows.Forms.Button button_LocationEdit;
		private System.Windows.Forms.Button button_LocationDelete;
		private System.Windows.Forms.Button button_LocationAdd;
		private System.Windows.Forms.Button button_LocationExit;
	}
}
using EqCard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqCard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetAllLocation(dataGridView_location);
		}

		private void GetAllLocation(DataGridView dataGridView_location)
		{
         using (EqCardContext ecc = new EqCardContext())
         {
            var locations = ecc.Locations;
            dataGridView_location.DataSource = locations.ToList();
         }
      }
	}
}

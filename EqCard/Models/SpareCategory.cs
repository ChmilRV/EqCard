using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	class SpareCategory
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string SpareCategoryComment { get; set; }

		public List<Spare> Spares { get; set; }
		public SpareCategory()
		{
			Spares = new List<Spare>();
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	class Spare
	{
		public int Id { get; set; }
		public string SpareName { get; set; }
		public string SpareComment { get; set; }
		public int NumberInStorage { get; set; }
		public int SpareCategoryId { get; set; }
		public SpareCategory SpareCategories { get; set; }

		public List<Equipment> Equipments { get; set; }
		public Spare()
		{
			Equipments = new List<Equipment>();
		}

	}
}

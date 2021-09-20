using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	//__________________________________________Запчасти
	class Spare
	{
		public int Id { get; set; }
		public string SpareName { get; set; }
		public string SpareComment { get; set; }
		public int NumberInStorage { get; set; }  // количество в складе
		public int SpareCategoryId { get; set; }
		public SpareCategory SpareCategories { get; set; }

		//  перечень оборудования с этой запчастью
		public List<Equipment> Equipments { get; set; }
		public Spare()
		{
			Equipments = new List<Equipment>();
		}




	}
}

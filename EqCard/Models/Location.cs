using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	class Location
	{
		//_____________________________________Расположение
		public int Id { get; set; }
		public string LocationName { get; set; }
		public List<Equipment> Equipment { get; set; }




	}
}

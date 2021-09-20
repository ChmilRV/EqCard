using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	//_____________________________________Расположение оборудования
	class Location
	{
		public int Id { get; set; }
		public string LocationName { get; set; }
		public string LocationComment { get; set; }
		public List<Equipment> Equipment { get; set; }




	}
}

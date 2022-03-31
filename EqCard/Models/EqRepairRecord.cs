using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	class EqRepairRecord
	{
		public int Id { get; set; }
		public DateTime RepairDate { get; set; }
		public string RepairDescription { get; set; }
		public string RepairComment { get; set; }
		public int EquipmentId { get; set; }
		public Equipment Equipment { get; set; }



	}
}

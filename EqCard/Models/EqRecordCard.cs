using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	class EqRecordCard
	{
		public int Id { get; set; }
		public int EquipmentId { get; set; }
		public Equipment Equipment { get; set; }
		public int SpareId { get; set; }
		public Spare Spare { get; set; }
		public int SpareCount { get; set; }
		public string EqRecordCardComment { get; set; }
	}
}

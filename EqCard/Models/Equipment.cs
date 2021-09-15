using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqCard.Models
{
	//_______________________________Оборудование
	class Equipment
	{
		public int Id { get; set; }
		public string EqName { get; set; }
		public string EqComment { get; set; }

		public int LocationId { get; set; }
		public Location Location { get; set; }



		// список запчастей оборудования
		public List<Spare> Spares { get; set; } 

		public List<EqRepairRecord> EqRepairRecords { get; set; }

		public Equipment()
		{
			Spares = new List<Spare>();
			EqRepairRecords = new List<EqRepairRecord>();
		}

	}
}

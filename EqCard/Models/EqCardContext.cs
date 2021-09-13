using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EqCard.Models
{
	class EqCardContext: DbContext
	{
      public EqCardContext() : base("MyConnString")
      {
         //Database.SetInitializer<EqCardContext>(new DropCreateDatabaseIfModelChanges<EqCardContext>());
         Database.SetInitializer<EqCardContext>(new MyInitializer());
      }
      public virtual DbSet<Equipment> Equipments { get; set; }
      public virtual DbSet<Location> Locations { get; set; }


   }
}

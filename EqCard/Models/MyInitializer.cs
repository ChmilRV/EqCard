using System.Collections.Generic;
using System.Data.Entity;

namespace EqCard.Models
{
	internal class MyInitializer : DropCreateDatabaseAlways<EqCardContext>
	{
      protected override void Seed(EqCardContext context)
      {

         context.Locations.AddRange(
            new List<Location>
            {
               new Location { LocationName = "Макулатурный"},
               new Location { LocationName = "БДМ3"},
               new Location { LocationName = "БДМ4"}
            });

         

         

         base.Seed(context);
      }




   }
}
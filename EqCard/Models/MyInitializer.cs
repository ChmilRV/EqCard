using System.Collections.Generic;
using System.Data.Entity;

namespace EqCard.Models
{
   internal class MyInitializer : DropCreateDatabaseIfModelChanges<EqCardContext> //DropCreateDatabaseAlways<EqCardContext>
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

         context.SpareCategories.AddRange(
            new List<SpareCategory> 
            {
               new SpareCategory { CategoryName = "Подшипники"},
               new SpareCategory {CategoryName ="Манжеты армированные"},
               new SpareCategory {CategoryName ="Валы карданные"}
            });

         base.Seed(context);
      }
   }
}

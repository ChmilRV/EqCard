using System.Collections.Generic;
using System.Data.Entity;

namespace EqCard.Models
{
   internal class MyInitializer : DropCreateDatabaseIfModelChanges<EqCardContext> //DropCreateDatabaseAlways<EqCardContext>
   {
      protected override void Seed(EqCardContext context)
      {
         // предзаполнение мест расположения оборудования
         context.Locations.AddRange(
            new List<Location>
            {
               new Location { LocationName = "Макулатурный"},
               new Location { LocationName = "БДМ3"},
               new Location { LocationName = "БДМ4"}
            });

         // предзаполнеие категорий запчастей
         context.SpareCategories.AddRange(
            new List<SpareCategory> 
            {
               new SpareCategory { CategoryName = "Подшипники"},
               new SpareCategory {CategoryName ="Манжеты армированные"},
               new SpareCategory {CategoryName ="Валы карданные"}
            });

         // предзаполнение запчастей 
         //context.Spares.AddRange(
         //   new List<Spare>
         //   {
         //      new Spare { SpareName = "6210", NumberInStorage= 10, SpareCategoryId = 1},
         //      new Spare {SpareName ="25x40x8", NumberInStorage = 12, SpareCategoryId = 2},
         //      new Spare {SpareName ="53290-1239874", NumberInStorage = 2, SpareCategoryId = 3}
         //   });

         // предзаполнение оборудования 
         //context.Equipments.AddRange(
         //   new List<Equipment>
         //   {
         //      new Equipment { EqName = "ГРВ-03", LocationId = 1},
         //      new Equipment { EqName = "Вал прессовый", LocationId = 2},
         //      new Equipment { EqName = "Вал прессовый", LocationId = 3},
         //   });





         base.Seed(context);
      }




   }
}
using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building ResidentServices = new Building("100 Main Ave.")
            {
                Stories = 1,
                Width = 564,
                Depth = 234
            };

            Building NooksCranny = new Building("100 Commerce Ave.")
            {
                Stories = 1,
                Width = 378,
                Depth = 200
            };

            Building Museum = new Building("234 Fossil Ln.")
            {
                Stories = 3,
                Width = 688,
                Depth = 310
            };

            Building AbleSisters = new Building("110 Commerce Ave.")
            {
                Stories = 1,
                Width = 234,
                Depth = 200
            };

            ResidentServices.Construct();
            NooksCranny.Construct();
            Museum.Construct();
            AbleSisters.Construct();

            ResidentServices.Purchase("Tom Nook");
            NooksCranny.Purchase("Timmy & Tommy Nook");
            Museum.Purchase("Blathers");
            AbleSisters.Purchase("Mabel & Sable Able");

            City Picorica = new City("Picorica", 2020)
            {
                MayorName = "Heidi Sprouse"
            };

            Picorica.AddBuilding(ResidentServices);
            Picorica.AddBuilding(NooksCranny);
            Picorica.AddBuilding(Museum);
            Picorica.AddBuilding(AbleSisters);

            foreach (Building building in Picorica.CityBuildings)
            {
                building.DisplayInfo();
            }

        }
    }
}
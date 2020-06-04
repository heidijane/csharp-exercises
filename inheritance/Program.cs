using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "pearly white"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "galaxy black"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "blue"
            };
            Ram ram4500 = new Ram()
            {
                MainColor = "dark red"
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            Console.WriteLine();

            ram4500.Drive();
            ram4500.Turn("right");
            ram4500.Stop();
            Console.WriteLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimGrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const int binCapacity = 3000;
            int dispenserCapacity = 20;

            StringBuilder sauceBin = new StringBuilder(binCapacity);
            StringBuilder disp1 = new StringBuilder(20);
            StringBuilder disp2 = new StringBuilder(20);


            List<StringBuilder> dispensers = new List<StringBuilder>();
            dispensers.Add(disp1);
            dispensers.Add(disp2);

            FillerRobotX robotX = new FillerRobotX(dispensers, sauceBin, dispenserCapacity); //robot must know about them
            FillerRobot2 robot2 = new FillerRobot2(dispensers, sauceBin, dispenserCapacity);

            Runner runner = new Runner(robotX);//boss

            bool runNonStop = false;
            int interval = 1000;

            //load saucebin
            for(int i=0; i<binCapacity; i++)
            {
                sauceBin.Append('x');//sauce
            }

            Console.WriteLine(sauceBin);

            Task.Delay(interval).Wait();


            Console.WriteLine("SimGrill\n--------\n\n");

            Console.WriteLine("Saucebin size: " + sauceBin.Length);

            Console.WriteLine("Dispensers quantity: " + dispensers.Count);

            runner.Init();


        }
    }
}

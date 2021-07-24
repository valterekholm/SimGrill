using System;
using System.Collections.Generic;
using System.Text;

namespace SimGrill
{
    abstract class FillerRobot
    {
        public List<StringBuilder> Dispensers { get; set; }
        public StringBuilder SauceBin;
        public int DispenserMaxLength;
        public FillerRobot(List<StringBuilder> dispensers, StringBuilder sauceBin, int dispMaxLen)
        {
            Dispensers = dispensers;
            SauceBin = sauceBin;
            DispenserMaxLength = dispMaxLen;
        }

        public abstract void applySauce(); //give to customer from any/some dispenser
        public abstract bool checkNeedRefill();
        /// <summary>
        /// Takes chars (sauce) from saucebin, into one or more dispensers
        /// </summary>
        /// <returns>returns true if bin did not get empty, else false</returns>
        public abstract bool goRefill();
        /// <summary>
        /// Make a first fill of sauce dispensers
        /// </summary>
        /// <returns> true if dispenser(s) could be filled</returns>
        public abstract bool init();
    }

    class FillerRobotX : FillerRobot
    {
        public FillerRobotX(List<StringBuilder> dispensers, StringBuilder sauceBin, int dispMaxLen) : base(dispensers, sauceBin, dispMaxLen)
        {
        }

        public override void applySauce()
        {
            throw new NotImplementedException();
        }

        public override bool checkNeedRefill()
        {
            throw new NotImplementedException();
        }

        public override bool goRefill()
        {
            throw new NotImplementedException();
        }

        public override bool init()
        {
            int totalDispenserCapacity = 0;
            foreach(StringBuilder d in Dispensers)
            {
                totalDispenserCapacity += d.Length;
            }

            if(totalDispenserCapacity <= SauceBin.Length)
            {
                for(int i= 0; i<Dispensers.Count; i++)
                {
                    Dispensers[i] = new StringBuilder(new String('x', DispenserMaxLength));
                    Console.WriteLine("Filled a dispenser");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Init fails, can't fill all dispensers");
                return false;
            }
        }
    }

    class FillerRobot2 : FillerRobot
    {

        public FillerRobot2(List<StringBuilder> dispensers, StringBuilder sauceBin, int dispMaxLen) : base(dispensers, sauceBin, dispMaxLen)
        {
        }

        public override void applySauce()
        {
            throw new NotImplementedException();
        }

        public override bool checkNeedRefill()
        {
            throw new NotImplementedException();
        }

        public override bool goRefill()
        {
            throw new NotImplementedException();
        }

        public override bool init()
        {
            throw new NotImplementedException();
        }
    }
}

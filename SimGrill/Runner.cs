using System;
using System.Collections.Generic;
using System.Text;

namespace SimGrill
{
    class Runner
    {
        private FillerRobot Robot { get; set; }
        public Runner(FillerRobot robot)
        {
            Robot = robot;
        }

        public void Init()
        {
            Robot.init();
        }
        public void Run()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    class Window : IPart
    {
        public bool isBuilt { get; set; }
        public int requiredTime { get; }
        public int buildingStatus { get; set; }

        public Window()
        {
            isBuilt = false;
            requiredTime = 1;
            buildingStatus = 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    class Walls : IPart
    {

        public bool isBuilt { get; set; }
        public int requiredTime { get; }
        public int buildingStatus { get; set; }

        public Walls()
        {
            isBuilt = false;
            requiredTime = 2;
            buildingStatus = 0;
        }

    }
}

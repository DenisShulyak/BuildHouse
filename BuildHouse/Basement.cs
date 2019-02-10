﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    class Basement : IPart
    {

        public bool isBuilt { get; set; }
        public int requiredTime { get; set; }
        public int buildingStatus { get; set; }

        public Basement()
        {
            isBuilt = false;
            requiredTime = 8;
            buildingStatus = 0;
        }

    }
}

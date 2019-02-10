using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    interface IPart
    {
        bool isBuilt { set; get; }          
        int requiredTime { get; }           
        int buildingStatus { get; set; }    

    }
}

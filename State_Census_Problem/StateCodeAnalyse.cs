using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Census_Problem
{
    public class StateCodeAnalyse
    {
        public string stateName, stateCode;
        public int serialNumber, tin;
        public string dataHeader = "State,Population,AreaInSqKm,DensityPerSqKm";

        public StateCodeAnalyse(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.stateCode = stateCode;
            this.tin = Convert.ToInt32(tin);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Census_Problem
{
    public class StateCensusData
    {
        string state;
        int population, area, density;
        string stateName, stateCode;
        int serialNumber, tin;
        public StateCensusData(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToInt32(population);
            this.area = Convert.ToInt32(area);
            this.density = Convert.ToInt32(density);
        }
        public StateCensusData(StateCodeAnalyse codeAnalyse)
        {
            this.stateName = codeAnalyse.stateName;
            this.stateCode = codeAnalyse.stateCode;
            this.serialNumber = codeAnalyse.serialNumber;
            this.tin = codeAnalyse.tin;
        }
    }
}

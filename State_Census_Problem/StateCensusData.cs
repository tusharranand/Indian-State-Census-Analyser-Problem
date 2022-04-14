using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Census_Problem
{
    public class StateCensusData
    {
        string stateName;
        int population;
        int area;
        int density;
        public StateCensusData(string stateName, string population, string area, string density)
        {
            this.stateName = stateName;
            this.population = Convert.ToInt32(population);
            this.area = Convert.ToInt32(area);
            this.density = Convert.ToInt32(density);
        }
    }
}

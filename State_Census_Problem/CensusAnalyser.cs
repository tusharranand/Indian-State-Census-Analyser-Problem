using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace State_Census_Problem
{
    public class CensusAnalyser
    {
        public Dictionary<string, StateCensusData> dataMap;
        public string dataHeader = "State,Population,AreaInSqKm,DensityPerSqKm";
        public Dictionary<string, StateCensusData> LoadCensusData(string csvFilePath)
        {
            dataMap = new Dictionary<string, StateCensusData>();
            if (!File.Exists(csvFilePath))
                throw new StateCensusException(StateCensusException.ExceptionType.FILE_DOES_NOT_EXIST, 
                    "No file with this name exixts.");
            if (Path.GetExtension(csvFilePath) != ".csv")
                throw new StateCensusException(StateCensusException.ExceptionType.IMPROPER_EXTENTION,
                    "The file must be of .csv type.");

            string[] censusDataInFile = File.ReadAllLines(csvFilePath);
            if (censusDataInFile[0] != dataHeader)
                throw new StateCensusException(StateCensusException.ExceptionType.INCORRECT_HEADER,
                    "Header in the file does not match required header format.");

            foreach (string row in censusDataInFile.Skip(1))
            {
                if (!row.Contains(','))
                    throw new StateCensusException(StateCensusException.ExceptionType.INCORRECT_DEMLIMETER,
                        "Required delimeter \",\" not found.");
                string[] data = row.Split(",");
                dataMap.Add(data[0], new StateCensusData(data[0], data[1], data[2], data[3]));
            }
            return dataMap;
        }
    }
}

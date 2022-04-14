using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Census_Problem
{
    public class StateCensusException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            FILE_DOES_NOT_EXIST,
            IMPROPER_EXTENTION,
            INCORRECT_DEMLIMETER,
            INCORRECT_HEADER
        }
        public StateCensusException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

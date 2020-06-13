using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSystem.Logic
{
    public class AssignValues
    {
        public string assignsinglevalue(string FinalValue, string strWorkingNumber)
        {
            FinalValue = FinalValue + Constants.NumberSystem.Single[int.Parse(strWorkingNumber)];
            return FinalValue;
        }

        public string assigndoublevalue(string FinalValue, string strWorkingNumber)
        {
            FinalValue = FinalValue + Constants.NumberSystem.Double[int.Parse(strWorkingNumber)];
            return FinalValue;
        }

        public string assigncombovalue(string FinalValue, string strWorkingNumber)
        {
            FinalValue = FinalValue + Constants.NumberSystem.Combo[int.Parse(strWorkingNumber)];
            return FinalValue;
        }
    }
}
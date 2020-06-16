using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSystem.Interfaces
{
    public interface INumberSystem
    {
        string ReturnWordValue(string strnumber);
        void WorkNumberValue(string[] strInputnumber, string[] strDecimalNumber, Dictionary<int, string> NumberDictionary);
        void SetValues(int arraylength);
        string SaveData(string strNumber, string strNumberText);
    }
}
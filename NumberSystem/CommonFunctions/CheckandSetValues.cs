using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSystem.Logic
{
    public class CheckandSetValues
    {
        AssignValues assign = new AssignValues();
        public Tuple<string, int> CheckHundred(string FinalValue, int hundredIdentifier, string[] strInputnumber, int j)
        {

            if (j == hundredIdentifier)
            {
                if (strInputnumber[j] != "0")
                {
                    FinalValue = assign.assignsinglevalue(FinalValue, strInputnumber[j]);
                    FinalValue = FinalValue + " HUNDRED";

                    if (strInputnumber[j + 1] != "0" || strInputnumber[j + 2] != "0")
                    {
                        FinalValue = FinalValue + " AND";
                    }
                }
                hundredIdentifier = hundredIdentifier + 3;
            }

            return Tuple.Create(FinalValue, hundredIdentifier);
        }

        public Tuple<string, int> CheckTens(string FinalValue, int Identifier, string[] strInputnumber, int j)
        {
            var tuple = new Tuple<string, int>(FinalValue, Identifier);
            if (j == Identifier && strInputnumber[j] == "1")
            {

                FinalValue = assign.assigncombovalue(FinalValue, strInputnumber[j + 1]);
                Identifier = Identifier + 3;
            }

            else if (j == Identifier && strInputnumber[j] != "1")
            {
                FinalValue = assign.assigndoublevalue(FinalValue, strInputnumber[j]);
                Identifier = Identifier + 3;
            }

            return Tuple.Create(FinalValue, Identifier);
        }

        public Tuple<string, int> CheckSingles(string FinalValue, int Identifier, string[] strInputnumber, int j)
        {
            var tuple = new Tuple<string, int>(FinalValue, Identifier);
            if (j == Identifier)
            {
                FinalValue = FinalValue + Constants.NumberSystem.Single[int.Parse(strInputnumber[j])];
            }

            return Tuple.Create(FinalValue, Identifier);
        }

        public string Removezeroes(string strnumber)
        {
            for (int i = 0; i < strnumber.Length; i++)
            {
                if (strnumber[i].ToString() != "0")
                {
                    break;
                }
                else
                {
                    strnumber = strnumber.Remove(i, 1);
                    i = i - 1;
                }
            }
            return strnumber;
        }
    }
}
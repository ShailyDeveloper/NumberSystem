using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NumberSystem.Logic;

namespace NumberSystem.BusinessLayer
{
    public class WesternNumberSystem
    {
        int singleIdentifier = 0;
        int hundredIdentifier = 0;
        int valueIdentifier = 0;
        string FinalValue = "";
        string strvalues = "";
        CheckandSetValues check = new CheckandSetValues();

        public string ReturnWordValue(string strnumber)
        {
            strnumber = check.Removezeroes(strnumber);
            String[] strInputnumber = strnumber.ToCharArray().Select(c => c.ToString()).ToArray();
            SetValues(strInputnumber.Length);
            WorkNumberValue(strInputnumber);
            return FinalValue;
        }

        public void WorkNumberValue(string[] strInputnumber)
        {
            int j = 0;

            while (j < strInputnumber.Length)
            {
                var tuple = new Tuple<string, int>(FinalValue, hundredIdentifier);
                tuple = check.CheckHundred(FinalValue, hundredIdentifier, strInputnumber, j);
                FinalValue = tuple.Item1.ToString();
                hundredIdentifier = tuple.Item2;

                tuple = new Tuple<string, int>(FinalValue, singleIdentifier);
                tuple = check.CheckTens(FinalValue, singleIdentifier, strInputnumber, j);
                FinalValue = tuple.Item1;
                singleIdentifier = tuple.Item2;

                tuple = new Tuple<string, int>(FinalValue, valueIdentifier);
                tuple = check.CheckSingles(FinalValue, valueIdentifier, strInputnumber, j);
                FinalValue = tuple.Item1;

                if (j == valueIdentifier)
                {
                    strvalues = SetNumberValue(j, strInputnumber);
                    if ((strInputnumber[j] == "0" && ((strInputnumber[j - 1] != "0" && j != 0) || (strInputnumber[j - 2] != "0" && j > 1))) || (strInputnumber[j] != "0"))
                    {
                        FinalValue = FinalValue + strvalues;
                    }

                    valueIdentifier = valueIdentifier + 3;

                }
                j = j + 1;
            }
        }

        public string SetNumberValue(int j, string[] strInputnumber)
        {
            string strValue = "";

            if (strInputnumber.Length - j > 12 && strInputnumber.Length < 16)
            {
                strValue = " TRILLION";
            }
            else if (strInputnumber.Length - j > 9 && strInputnumber.Length - j < 13)
            {
                strValue = " BILLION";
            }
            else if (strInputnumber.Length - j > 6 && strInputnumber.Length - j < 10)
            {
                strValue = " MILLION";
            }
            else if (strInputnumber.Length - j > 3 && strInputnumber.Length - j < 7)
            {
                strValue = " THOUSAND";
            }
            else if (strInputnumber.Length - j > 15 && strInputnumber.Length - j < 19)
            {
                strValue = " QUADRILLION";
            }
            else if (strInputnumber.Length - j > 18 && strInputnumber.Length - j < 22)
            {
                strValue = " QUINTILLION";
            }
            else if (strInputnumber.Length - j > 21 && strInputnumber.Length - j < 25)
            {
                strValue = "SEXTILLION";
            }
            else if (strInputnumber.Length - j > 24 && strInputnumber.Length - j < 27)
            {
                strValue = "OCTILIION";
            }

            for (int i = j + 1; strInputnumber.Length - i > 0; i++)
            {
                if (strInputnumber[i] != "0")
                {
                    strValue = strValue + ",";
                    break;
                }
            }
            return strValue;

        }

        public void SetValues(int arraylength)
        {
            if (arraylength % 3 == 2)
            {
                hundredIdentifier = 2;
                valueIdentifier = 1;
            }

            if (arraylength % 3 == 1)
            {
                singleIdentifier = 2;
                hundredIdentifier = 1;
            }

            if (arraylength % 3 == 0)
            {
                singleIdentifier = 1;
                valueIdentifier = 2;
            }
        }
    }
}
using System;
using System.Linq;
using NumberSystem.Logic;
using NumberSystem.Constants;
using NumberSystem.DBLayer;
using System.Collections.Generic;

namespace NumberSystem.BusinessLayer
{
    public class WesternNumberSystem
    {
        #region Declarations
        int singleIdentifier = 0;
        int hundredIdentifier = 0;
        int valueIdentifier = 0;
        string FinalValue = "";
        string strDecimalNumber = "";
        string DecimalValue = "";
        string strResult = "";
        CheckandSetValues check = new CheckandSetValues();
        WesternNumeralSystem num = new WesternNumeralSystem();
        String[] strdecimalNumber;
        #endregion

        #region Sets the prerequisites and calls the working logic of number conversion and returns the final value
        public string ReturnWordValue(string strnumber)
        {
            string[] strCompletetext = strnumber.Split('.');

            if (strnumber.Contains('.'))
            {
                strDecimalNumber = strCompletetext[1].ToString();
                strdecimalNumber = check.ConvertToArray(strDecimalNumber);
            }

            strnumber = strCompletetext[0].ToString();
            strnumber = check.Removezeroes(strnumber);
            String[] strInputnumber = check.ConvertToArray(strnumber);

            SetValues(strInputnumber.Length);

            Dictionary<int, string> NumeralSystem = num.ReturnNumeralValue();

            WorkNumberValue(strInputnumber, strdecimalNumber,NumeralSystem);
            
            return FinalValue;
        }
        #endregion

        #region Converts the number to text and returns to the parent method
        public void WorkNumberValue(string[] strInputnumber,string[] strDecimalNumber,Dictionary<int,string> NumberDictionary)
        {            
            int NumberIndex = 0;
            int DecimalIndex = 0;

            foreach (string values in strInputnumber)
            {
                             
                var tuple = new Tuple<string, int>(FinalValue, hundredIdentifier);
                tuple = check.CheckHundred(FinalValue, hundredIdentifier, strInputnumber, NumberIndex);
                FinalValue = tuple.Item1.ToString();
                hundredIdentifier = tuple.Item2;

                tuple = new Tuple<string, int>(FinalValue, singleIdentifier);
                tuple = check.CheckTens(FinalValue, singleIdentifier, strInputnumber, NumberIndex);
                FinalValue = tuple.Item1;
                singleIdentifier = tuple.Item2;

                tuple = new Tuple<string, int>(FinalValue, valueIdentifier);
                tuple = check.CheckSingles(FinalValue, valueIdentifier, strInputnumber, NumberIndex,false);
                FinalValue = tuple.Item1;

                tuple = new Tuple<string, int>(FinalValue, valueIdentifier);
                tuple = check.SetValue(FinalValue, valueIdentifier, strInputnumber, NumberIndex, NumberDictionary);
                FinalValue = tuple.Item1;
                valueIdentifier = tuple.Item2;

                NumberIndex = NumberIndex + 1;
            }

            if (strdecimalNumber != null && strdecimalNumber.Length > 0)
            {
                foreach (string values in strDecimalNumber)
                {

                    var tuple = new Tuple<string, int>(DecimalValue, DecimalIndex);
                    tuple = check.CheckSingles(DecimalValue, DecimalIndex, strDecimalNumber, DecimalIndex, true);
                    DecimalValue = tuple.Item1;
                    DecimalIndex = DecimalIndex + 1;

                }
                
            }

            if (DecimalValue != "")
            {
                FinalValue = FinalValue + " POINT " + DecimalValue;
            }
            
        }
        #endregion

        #region defines the numeral placeholder
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
        #endregion

        #region SaveData
        public string SaveData(string strNumber,string strNumberText)
        {
            if(strNumber!="" && strNumberText!="")
            {
                DBLogics Save = new DBLogics();
                int intResult = Save.SaveData(strNumber, strNumberText);

                if (intResult!=0)
                {
                    strResult = "Data Saved Successfully";
                }
                else
                {
                    strResult = "Unable to Save Data";
                }
               
            }
            return strResult;
        }
        #endregion

    }
}
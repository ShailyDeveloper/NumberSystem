using System;
using System.Linq;
using NumberSystem.Logic;
using NumberSystem.Constants;
using NumberSystem.DBLayer;
using System.Collections.Generic;
using NLog;
using System.Reflection;
using NumberSystem.CommonFunctions;

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
            try
            {
                MyLogger.GetInstance().Info("Entering the ReturnWordValue Method with the input " + strnumber);
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

                WorkNumberValue(strInputnumber, strdecimalNumber, NumeralSystem);

                return FinalValue;

            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + "/n Value Provided to this method " + strnumber + "with the error message " + Ex.Message);
                return "Error in Conversion";
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the ReturnWordValue Method");
            }
            
        }
        #endregion

        #region Converts the number to text and returns to the parent method
        public void WorkNumberValue(string[] strInputnumber,string[] strDecimalNumber,Dictionary<int,string> NumberDictionary)
        {
            MyLogger.GetInstance().Info("Entering the WorkNumberValue Method with the input " + "strInputnumber = " + strInputnumber + "and decimal number = " + strDecimalNumber);
            int NumberIndex = 0;
            int DecimalIndex = 0;

            try
            {

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
                    tuple = check.CheckSingles(FinalValue, valueIdentifier, strInputnumber, NumberIndex, false);
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
                MyLogger.GetInstance().Info("Exiting the WorkNumberValue Method");
        }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                FinalValue = "Error in Conversion";
            }
            
        }
        #endregion

        #region defines the numeral placeholder
        public void SetValues(int arraylength)
        {
            MyLogger.GetInstance().Info("Entering the SetValues Method with the array length" + arraylength);
            try
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
                MyLogger.GetInstance().Info("Exiting the SetValues Method with the array length" + arraylength);
            }
            
            catch (Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
            }
            
        }
        #endregion

        #region SaveData
        public string SaveData(string strNumber,string strNumberText)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the SaveData Method with the values strNumber = " + strNumber + " strNumberText = " + strNumberText);

                if (strNumber != "" && strNumberText != "")
                {
                    DBLogics Save = new DBLogics();
                    int intResult = Save.SaveData(strNumber, strNumberText);

                    if (intResult != 0)
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
            catch (Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return strResult = "Unable to Save Data";
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the ReturnWordValue Method");
            }
        }
        #endregion

    }
}
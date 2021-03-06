﻿using NumberSystem.CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NumberSystem.Logic
{
    public class CheckandSetValues
    {
        #region Instance Creation
        AssignValues assign = new AssignValues();
        #endregion

        #region Check and set the value to hundred
        public Tuple<string, int> CheckHundred(string FinalValue, int hundredIdentifier, string[] strInputnumber, int j,string strNumeralSystem)
        {
            try
            {
                if (FinalValue != "Error in Conversion")
                {
                    MyLogger.GetInstance().Info("Entering the CheckHundred Method");
                    if (j == hundredIdentifier)
                    {
                        if (strInputnumber[j] != "0")
                        {
                            FinalValue = assign.Assignsinglevalue(FinalValue, strInputnumber[j]);
                            FinalValue = FinalValue + " HUNDRED";

                            if (strInputnumber[j + 1] != "0" || strInputnumber[j + 2] != "0")
                            {
                                FinalValue = FinalValue + " AND";
                            }
                        }

                        hundredIdentifier = SetIDentifier(hundredIdentifier, strNumeralSystem);
                        
                    }
                }

                return Tuple.Create(FinalValue, hundredIdentifier);

            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return Tuple.Create("Error in Conversion", hundredIdentifier);
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the CheckHundred Method");
            }
        }
        #endregion

        #region Check and set the value to its relevant 2 digits
        public Tuple<string, int> CheckTens(string FinalValue, int Identifier, string[] strInputnumber, int j, string strNumeralSystem)
        {
            try
            {
                if (FinalValue != "Error in Conversion")
                {
                    MyLogger.GetInstance().Info("Entering the CheckTens Method");
                    var tuple = new Tuple<string, int>(FinalValue, Identifier);
                    if (j == Identifier && strInputnumber[j] == "1")
                    {

                        FinalValue = assign.Assigncombovalue(FinalValue, strInputnumber[j + 1]);
                        Identifier = SetIDentifier(Identifier, strNumeralSystem);
                    }

                    else if (j == Identifier && strInputnumber[j] != "1")
                    {
                        FinalValue = assign.Assigndoublevalue(FinalValue, strInputnumber[j]);
                        Identifier = SetIDentifier(Identifier, strNumeralSystem);

                    }
                }

                return Tuple.Create(FinalValue, Identifier);
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return Tuple.Create("Error in Conversion", Identifier);
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the CheckTens Method");
            }
        }
        #endregion

        #region Check and set the value to its relevant single digit
        public Tuple<string, int> CheckSingles(string FinalValue, int Identifier, string[] strInputnumber, int j,bool decimalvalue)
        {
            try
            {
                if (FinalValue != "Error in Conversion")
                {
                    MyLogger.GetInstance().Info("Entering the CheckSingles Method");
                    var tuple = new Tuple<string, int>(FinalValue, Identifier);
                    if (j == Identifier)
                    {
                        if (j != 0 && strInputnumber[j - 1] != "1" && !decimalvalue)
                        {
                            FinalValue = FinalValue + Constants.NumberSystem.Single[int.Parse(strInputnumber[j])];
                        }
                        else if (j == 0 || decimalvalue)
                        {
                            if (int.Parse(strInputnumber[j]) != 0)
                            {
                                FinalValue = FinalValue + Constants.NumberSystem.Single[int.Parse(strInputnumber[j])];
                            }
                            else
                            {
                                FinalValue = FinalValue + " ZERO";
                            }
                        }
                    }

                }
                return Tuple.Create(FinalValue, Identifier);
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return Tuple.Create("Error in Conversion", Identifier);
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the CheckSingles Method");
            }

        }
        #endregion

        #region remove the unwanted zeroes to left side of a number
        public string Removezeroes(string strnumber)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the Removezeroes Method");
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
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return null;
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the Removezeroes Method");
            }
        }
        #endregion

        #region Check and the set the value of a number as per the numeral system
        public Tuple<string, int> SetValue(string FinalValue, int Identifier, string[] strInputnumber, int j , Dictionary<int,string>NumberSystem,string strNumeralSystem)
        {
            try
            {
                if (FinalValue != "Error in Conversion")
                {
                    MyLogger.GetInstance().Info("Entering the SetValue Method");
                    if (j == Identifier)
                    {
                        string strvalues = "";

                        if (strInputnumber.Length - j > 3)
                        {
                            strvalues = NumberSystem[strInputnumber.Length - j];
                            for (int i = j + 1; strInputnumber.Length - i > 0; i++)
                            {
                                if (strInputnumber[i] != "0")
                                {
                                    strvalues = strvalues + ",";
                                    break;
                                }
                            }
                        }
                        if ((strInputnumber[j] == "0" && ((strInputnumber[j - 1] != "0" && j != 0) || (strInputnumber[j - 2] != "0" && j > 1))) || (strInputnumber[j] != "0"))
                        {
                            FinalValue = FinalValue + strvalues;
                        }

                        Identifier = SetIDentifier(Identifier, strNumeralSystem);

                    }
                }
                return Tuple.Create<string, int>(FinalValue, Identifier);
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return Tuple.Create<string, int>("Error in Conversion", Identifier);

            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the SetValue Method");
            }
        }
        #endregion

        #region Converts the number to array
        public string[] ConvertToArray (string strNumber)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the ConvertToArray Method");
                String[] strOutputValue;

                strOutputValue = strNumber.ToCharArray().Select(c => c.ToString()).ToArray();


                return strOutputValue;
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return null;
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the ConvertToArray Method");
            }
        }
        #endregion

        #region Converts the number to array
        public int SetIDentifier(int intIdentifier, string strNumeralSystem)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the ConvertToArray Method");

                switch (strNumeralSystem)
                {
                    case "Western":
                        intIdentifier = intIdentifier + 3;
                        break;

                    case "Indian":
                        intIdentifier = intIdentifier + 2;
                        break;
                }


                return intIdentifier;
            }
            catch (Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return intIdentifier;
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the ConvertToArray Method");
            }
        }
        #endregion


    }
}
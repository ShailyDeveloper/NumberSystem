﻿using NumberSystem.CommonFunctions;
using System;
using System.Reflection;

namespace NumberSystem.Logic
{
    public class AssignValues
    {
        #region Assign Single Values
        public string Assignsinglevalue(string FinalValue, string strWorkingNumber)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the Assignsinglevalue Method");
                FinalValue = FinalValue + Constants.NumberSystem.Single[int.Parse(strWorkingNumber)];
                return FinalValue;
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return FinalValue = "Error in Conversion";
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the Assignsinglevalue Method");
            }
        }
        #endregion

        #region Assign Double Values
        public string Assigndoublevalue(string FinalValue, string strWorkingNumber)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the Assigndoublevalue Method");
                FinalValue = FinalValue + Constants.NumberSystem.Double[int.Parse(strWorkingNumber)];
                return FinalValue;
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return FinalValue = "Error in Conversion";
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the Assigndoublevalue Method");
            }
        }
        #endregion

        #region Assign Combo Values
        public string Assigncombovalue(string FinalValue, string strWorkingNumber)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the Assigncombovalue Method");
                FinalValue = FinalValue + Constants.NumberSystem.Combo[int.Parse(strWorkingNumber)];
                return FinalValue;
            }
            catch (Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return FinalValue = "Error in Conversion";
            }
            finally
            {
                MyLogger.GetInstance().Info("Exiting the Assigncombovalue Method");
            }
        }
        #endregion
    }
}
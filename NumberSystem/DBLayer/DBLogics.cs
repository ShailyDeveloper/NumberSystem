using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using NumberSystem.CommonFunctions;
using System.Reflection;

namespace NumberSystem.DBLayer
{
    public class DBLogics
    {
        readonly string strConnection = ConfigurationManager.ConnectionStrings["DBConn_SQL"].ConnectionString;
        
        #region Save Data
        public int SaveData(string strNumber , string strNumbertext)
        {
            SqlConnection sqlCon = new SqlConnection(strConnection);
            try
            {
                MyLogger.GetInstance().Info("Entering the SaveData Method");                
                SqlCommand cmd = new SqlCommand("InsertData",sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Number", SqlDbType.Float).Value = strNumber;
                cmd.Parameters.Add("@NumberText", SqlDbType.VarChar).Value = strNumbertext;
                sqlCon.Open();
                int intResult = cmd.ExecuteNonQuery();
                sqlCon.Close();

                return intResult;
            }
            catch(Exception Ex)
            {
                sqlCon.Close();
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
                return 0;
            }
            finally
            {
                sqlCon.Close();
                MyLogger.GetInstance().Info("Exiting the SaveData Method");
            }

        }
        #endregion


    }
}
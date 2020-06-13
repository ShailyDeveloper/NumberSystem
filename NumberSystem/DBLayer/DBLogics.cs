﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace NumberSystem.DBLayer
{
    public class DBLogics
    {
        readonly string strConnection = ConfigurationManager.ConnectionStrings["DBConn_SQL"].ConnectionString;
       
        public int SaveData(string strNumber , string strNumbertext)
        {
            SqlConnection sqlCon = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "INSERT INTO dbo.NumberData(Number,NumberText) VALUES(@param1,@param2)";

            cmd.Parameters.Add("@param1", SqlDbType.Float);
            cmd.Parameters["@param1"].Value = Decimal.Parse(strNumber);

            cmd.Parameters.Add("@param2", SqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = strNumbertext;

            sqlCon.Open();
            int intResult = cmd.ExecuteNonQuery();
            sqlCon.Close();

            return intResult;

        }

        
            
    }
}
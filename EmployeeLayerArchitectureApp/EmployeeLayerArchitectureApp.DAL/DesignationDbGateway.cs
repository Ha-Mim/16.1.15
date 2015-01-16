using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.DAL
{
    public class DesignationDbGateway
    {
        string connectionString = @"Data Source = (local); database=EmployeeDB;Integrated Security = true";
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        private string query;
        
        public DesignationDbGateway()
        {
            aSqlConnection = new SqlConnection();   
        }

        public void Save(Designation aDesignation)
        {
            aSqlConnection = new SqlConnection(connectionString);
            query = "INSERT INTO tblDesignation VALUES('" + aDesignation.Code + "', '" + aDesignation.Title + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query,aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Designation Find(string code)
        {
            aSqlConnection = new SqlConnection(connectionString);
            query = "SELECT * FROM tblDesignation WHERE code = '" + code + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            Designation aDesignation;

            if (aDataReader.HasRows)
            {
                aDesignation = new Designation();
                aDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aDataReader["Id"]);
                aDesignation.Code = aDataReader["Code"].ToString();
                aDesignation.Title = aDataReader["Title"].ToString();
                aDataReader.Close();
                aSqlConnection.Close();
                return aDesignation;
            }
            else
            {
                aSqlConnection.Close();
                return null;
            }
        }
        public Designation Find(int id)
        {
            aSqlConnection = new SqlConnection(connectionString);
            query = "SELECT * FROM tblDesignation WHERE id = '" + id + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            Designation aDesignation;

            if (aDataReader.HasRows)
            {
                aDesignation = new Designation();
                aDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aDataReader["Id"]);
                aDesignation.Code = aDataReader["Code"].ToString();
                aDesignation.Title = aDataReader["Title"].ToString();
                aDataReader.Close();
                aSqlConnection.Close();
                return aDesignation;
            }
            else
            {
                aSqlConnection.Close();
                return null;
            }
        }

        public List<Designation> GetAllDesignattion()
        {
            aSqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tblDesignation";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();

            List<Designation> designationList = new List<Designation>();

            while (aDataReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Id = Convert.ToInt32(aDataReader["id"]);
                aDesignation.Code = aDataReader["code"].ToString();
                aDesignation.Title = aDataReader["title"].ToString();
                designationList.Add(aDesignation);
            }
            aDataReader.Close();
            aSqlConnection.Close();
            return designationList;
        }
    }
}

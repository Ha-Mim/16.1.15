using System.Collections.Generic;
using System.Data.SqlClient;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.DAL
{
    public class EmployeeDbGateway
    {
        string connectionString = @"Data Source = (local); database=EmployeeDB;Integrated Security = true";
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        private string query;
        public void Save(Employee aEmployee)
        {
            aSqlConnection = new SqlConnection(connectionString);
            query = "INSERT INTO tblEmployee VALUES('" + aEmployee.Name + "', '" + aEmployee.Email +"', '"+ aEmployee.Address +"', '" + aEmployee.ADesignation.Id + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Employee> SearchEmployees(string name)
        {
            aSqlConnection = new SqlConnection(connectionString);
            if (name == string.Empty)
            {
                query = "SELECT * FROM tblEmployee ";
            }
            else
            {
                query =
                    "SELECT * FROM tblEmployee WHERE tblEmployee.name ='" +
                    name+ "';";
            }
            aSqlConnection.Open();
            DesignationDbGateway aDesignationDbGateway=new DesignationDbGateway();
            aSqlCommand = new SqlCommand(query,aSqlConnection);
            List<Employee> aListEmployees = new List<Employee>();
            
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                Employee aEmployee = new Employee();
                aEmployee.Id = (int)aSqlDataReader["id"];
                aEmployee.Name = aSqlDataReader["name"].ToString();
                aEmployee.Address = aSqlDataReader["address"].ToString();
                aEmployee.Email = aSqlDataReader["email"].ToString();
                aEmployee.ADesignation= aDesignationDbGateway.Find((int)aSqlDataReader["designation_id"]);
                aListEmployees.Add(aEmployee);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return aListEmployees;
        } 
    }
    
}

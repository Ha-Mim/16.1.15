using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLayerArchitectureApp.DAL;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.BLL
{
    public class EmployeeManager
    {
        private EmployeeDbGateway aEmployeeDbGateway;
        public string Save(Employee aEmployee)
        {
            aEmployeeDbGateway = new EmployeeDbGateway();
            aEmployeeDbGateway.Save(aEmployee);
            return "Saved";
        }

        public List<Employee> SearchEmployees(string name)
        {
            aEmployeeDbGateway = new EmployeeDbGateway();
             return aEmployeeDbGateway.SearchEmployees(name);
        } 
        //public Designation Find(string)
    }
}

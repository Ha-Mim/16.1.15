using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLayerArchitectureApp.DAL;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.BLL
{
    public class DesignationManager
    {
        DesignationDbGateway aDesignationDbGateway = new DesignationDbGateway();
        const int MIN_LENGTH_OF_CODE = 3;
        public string Save(Designation aDesignation)
        {
            if (aDesignation.Code.Length >= MIN_LENGTH_OF_CODE)
            {
                Designation designationFound = aDesignationDbGateway.Find(aDesignation.Code);
                if (designationFound == null)
                {
                    aDesignationDbGateway.Save(aDesignation);
                    return "Saved";
                }
                else
                {
                    return "This code already exists";
                }
            }
            else
            {
                return "Code must be " + MIN_LENGTH_OF_CODE + " char long";
            }
        }


        public List<Designation> GetAllDesignattion()
        {
            return aDesignationDbGateway.GetAllDesignattion();
        }

        public Designation GetDesignation(string code)
        {
            return aDesignationDbGateway.Find(code);
        }
    }
}

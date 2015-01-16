using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeLayerArchitectureApp.Web
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmployee.aspx");
        }

        protected void addDesignationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDesignation.aspx");
        }

        protected void FindAndEditButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchAndEdit.aspx");
        }
    }
}
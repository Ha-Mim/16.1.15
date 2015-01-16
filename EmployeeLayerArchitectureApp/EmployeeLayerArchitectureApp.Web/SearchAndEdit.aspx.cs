using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeLayerArchitectureApp.BLL;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.Web
{
    public partial class SearchAndEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void closeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            EmployeeManager anEmployeeManager = new EmployeeManager();


            searchGridView.DataSource = anEmployeeManager.SearchEmployees(name);
            searchGridView.DataBind();
        }
    }
}
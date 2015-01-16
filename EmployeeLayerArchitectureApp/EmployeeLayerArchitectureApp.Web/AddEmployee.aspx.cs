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
    public partial class AddEmployee : System.Web.UI.Page
    {
        DesignationManager aDesignationManager= new DesignationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                designationDropDownList.DataSource = aDesignationManager.GetAllDesignattion();
                designationDropDownList.DataTextField = "Title";
                designationDropDownList.DataValueField = "Id";
                designationDropDownList.DataBind();
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.ADesignation.Id = Convert.ToInt32(designationDropDownList.SelectedValue);
            EmployeeManager aEmployeeManager= new EmployeeManager();
            string msg= aEmployeeManager.Save(anEmployee);
            msgTextBox.Text = msg;
        }

        protected void closeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLayerArchitectureApp.BLL;
using EmployeeLayerArchitectureApp.DAO;

namespace EmployeeLayerArchitectureApp.UI
{
    public partial class AddEmployeeForm : Form
    {
        DesignationManager aDesignationManager = new DesignationManager();
        public AddEmployeeForm()
        {
            InitializeComponent();
            addEmployeeDesignationComboBox.DisplayMember = "title";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.Name = addEmployeeNameTextBox.Text;
            aEmployee.Email = addEmployeeEmailTextBox.Text;
            aEmployee.Address = addEmployeeAddressTextBox.Text;
            Designation selectedDesignation = (Designation) addEmployeeDesignationComboBox.SelectedItem;
            aEmployee.ADesignation = selectedDesignation;
            EmployeeManager aEmployeeManager = new EmployeeManager();
            string msg = aEmployeeManager.Save(aEmployee);
            MessageBox.Show(msg);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            addEmployeeDesignationComboBox.DataSource = aDesignationManager.GetAllDesignattion();
        }
    }
}

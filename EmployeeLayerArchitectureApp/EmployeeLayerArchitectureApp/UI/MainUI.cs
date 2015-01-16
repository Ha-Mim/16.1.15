using System;
using System.Windows.Forms;
using EmployeeLayerArchitectureApp.UI;

namespace EmployeeLayerArchitectureApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployee = new AddEmployeeForm();
            addEmployee.ShowDialog();
        }

        private void addDesignationButton_Click(object sender, EventArgs e)
        {
            AddDesesignationForm addDesesignation = new AddDesesignationForm();
            addDesesignation.ShowDialog();
        }

        private void findAndEditButton_Click(object sender, EventArgs e)
        {
            FindAndSearchForm andSearch = new FindAndSearchForm();
            andSearch.ShowDialog();
        }
    }
}

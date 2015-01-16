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
    public partial class AddDesesignationForm : Form
    {
        public AddDesesignationForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation = new Designation();
            aDesignation.Code = addDesignationCodeTextBox.Text;
            aDesignation.Title = addDesignationTitleTextBox.Text;
            DesignationManager aDesignationManager = new DesignationManager();
            string msg = aDesignationManager.Save(aDesignation);
            MessageBox.Show(msg);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

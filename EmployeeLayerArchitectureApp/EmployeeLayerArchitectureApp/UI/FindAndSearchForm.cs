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
    public partial class FindAndSearchForm : Form
    {
        public FindAndSearchForm()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string name = searchNameTextBox.Text;
            EmployeeManager aEmployeeManager = new EmployeeManager();
            
            foreach (Employee anEmployee in aEmployeeManager.SearchEmployees(name))
            {
                ListViewItem aListViewItem=new ListViewItem();
                aListViewItem.Text = anEmployee.Id.ToString();
                aListViewItem.SubItems.Add(anEmployee.Name);
                aListViewItem.SubItems.Add(anEmployee.Email);
                aListViewItem.SubItems.Add(anEmployee.Address);
                //aListViewItem.SubItems.Add(anEmployee.ADesignation.Code);
                //aListViewItem.SubItems.Add(anEmployee.ADesignation.Title);
                listView1.Items.Add(aListViewItem);
            }
        }
    }
}

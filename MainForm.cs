using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEIS209_PayRoll_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add item to the employee listbox
            EmployeesListBox.Items.Add("New Employee");
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;
            if(itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                MB("Please Selecte employee to remove.", "Error!", MessageBoxIcon.Error);
            }
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MB("Displaying all employees...", "Display All", MessageBoxIcon.Exclamation);
        }
        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MB("Printing paychecks for all employees...", "Printing", MessageBoxIcon.Exclamation);
        }
    }
}

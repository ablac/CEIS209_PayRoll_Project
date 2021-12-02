using System;
using System.Windows.Forms;
//****************************************************************************************************************
//*****************************************************MAINFORM***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //************************************
        //************ADD BUTTON**************
        //************************************
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Create Add Employee Data Form
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                frmInput.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = frmInput.ShowDialog();

                //See if input form was Cancelled
                if (result == DialogResult.Cancel)
                    return;

                //Get User Input/Create employee Object
                string fName = frmInput.firstNameTextBox.Text;
                string lName = frmInput.lastNameTextBox.Text;
                string ssn = frmInput.ssnTextBox.Text;
                string date = frmInput.hireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);

                Employee emp = new Employee(fName, lName, ssn, hireDate);

                //Add Employee Object to List
                EmployeesListBox.Items.Add(emp);

                //Write all Employee Objects to the file
                WriteEmpsToFile($"{fName} {lName} added to {FILENAME} successful!");
            }
        }
        //************************************
        //***********REMOVE BUTTON************
        //************************************
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                //Remove Selected Employee
                EmployeesListBox.Items.RemoveAt(itemNumber);

                //Update File
                WriteEmpsToFile($"Employee removed from {FILENAME} successfully!");
            }
            else
            {
                //Display message
                displayLabel.Text = "Please select an employee to remove!";
            }
        }
        //************************************
        //************PRINT BUTTON************
        //************************************
        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            //Print Paychecks
            displayLabel.Text = "Printing paychecks for all employees!";
            Employee emp = new Employee();
        }
    }
}
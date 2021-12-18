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

                //Get Benefits Information
                string healthINS = frmInput.healthINSTextBox.Text;
                double lifeINS = Double.Parse(frmInput.lifeINSTextBox.Text);
                int vacation = Int32.Parse(frmInput.vacationTextBox.Text);

                Benefits benefits = new Benefits(healthINS, lifeINS, vacation);
                Employee emp;

                //Check if employee is Hourly/Salary
                if (frmInput.hourlyRadioButton.Checked)
                {
                    //Get Hourly Items
                    float hourlyRate = float.Parse(frmInput.pay1TextBox.Text);
                    float hoursWorked = float.Parse(frmInput.pay2TextBox.Text);

                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                }
                else if (frmInput.salaryRadioButton.Checked)
                {
                    //Get Salary Items
                    double salary = Double.Parse(frmInput.pay1TextBox.Text);

                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }
                else
                {
                    displayLabel.Text = "Error, Invalid Employee Type.";
                    return;
                }

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
            foreach (Employee emp in EmployeesListBox.Items)
            {
                string output = $"{emp.FirstName} {emp.LastName} " +
                    $"\n SSN: {emp.SSN}" +
                    $"\n Hiredate: {emp.HireDate.ToShortDateString()}" +
                    $"\n Pay Amount: {emp.CalculatePay().ToString("F2")}";

                MessageBox.Show(output);
            }
            displayLabel.Text = "Printing paychecks for all employees!";
            
        }
        //************************************
        //*************EDIT CLICK*************
        //************************************
        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            //Edit Selected Employee in the list box.
            InputForm frmUpdate = new InputForm();
            using (frmUpdate)
            {
                int itemNumber = EmployeesListBox.SelectedIndex;

                //Update Form Button/Start Position
                frmUpdate.submitButton.Text = "Update";
                frmUpdate.StartPosition = FormStartPosition.CenterParent;

                //Error Check
                if (itemNumber < 0)
                {
                    displayLabel.Text = "Error, Invalid Employee.";
                    return;
                }

                //Find selected Employee Data
                Employee emp = (Employee)EmployeesListBox.Items[itemNumber];

                //Import Employee Data
                frmUpdate.firstNameTextBox.Text = emp.FirstName;
                frmUpdate.lastNameTextBox.Text = emp.LastName;
                frmUpdate.ssnTextBox.Text = emp.SSN;
                frmUpdate.hireDateTextBox.Text = emp.HireDate.ToShortDateString();

                //Import Benefits
                frmUpdate.healthINSTextBox.Text = emp.BenefitsPackage.HealthInsurance;
                frmUpdate.lifeINSTextBox.Text = emp.BenefitsPackage.LifeInsurance.ToString("C2");
                frmUpdate.vacationTextBox.Text = emp.BenefitsPackage.Vacation.ToString();


                //Check Salary/Hourly
                if (emp is Hourly)
                {
                    Hourly hrly = (Hourly)emp;
                    frmUpdate.hourlyRadioButton.Checked = true;
                    frmUpdate.pay1TextBox.Text = hrly.HourlyRate.ToString("N2");
                    frmUpdate.pay2TextBox.Text = hrly.HoursWorked.ToString("N1");
                }
                else if (emp is Salary)
                {
                    Salary sal = (Salary)emp;
                    frmUpdate.salaryRadioButton.Checked = true;
                    frmUpdate.pay1TextBox.Text = sal.AnnualSalary.ToString("N2");
                }

                //Update Form Title
                frmUpdate.Text = $"{emp.FirstName} {emp.LastName} Update Form";

                DialogResult result = frmUpdate.ShowDialog();

                //End Method if user cancles Update
                if (result == DialogResult.Cancel)
                    return;

                //Remove Old Data
                EmployeesListBox.Items.RemoveAt(itemNumber);

                //Get User Input/Create employee Object
                string fName = frmUpdate.firstNameTextBox.Text;
                string lName = frmUpdate.lastNameTextBox.Text;
                string ssn = frmUpdate.ssnTextBox.Text;
                string date = frmUpdate.hireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);

                //Get Benefits Information
                string healthINS = frmUpdate.healthINSTextBox.Text;

                //pull a substring that does not contain the $
                string lifeINSString = frmUpdate.lifeINSTextBox.Text;
                lifeINSString = lifeINSString.Substring(1);
                double lifeINS = Double.Parse(lifeINSString);

                int vacation = Int32.Parse(frmUpdate.vacationTextBox.Text);

                Benefits benefits = new Benefits(healthINS, lifeINS, vacation);

                if (frmUpdate.hourlyRadioButton.Checked)
                {
                    float rate = float.Parse(frmUpdate.pay1TextBox.Text);
                    float hours = float.Parse(frmUpdate.pay2TextBox.Text);

                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, rate, hours);
                }
                else if (frmUpdate.salaryRadioButton.Checked)
                {
                    double salary = Double.Parse(frmUpdate.pay1TextBox.Text);

                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }

                //Add Employee Object to List
                EmployeesListBox.Items.Add(emp);

                //Write all Employee Objects to the file
                WriteEmpsToFile($"{fName} {lName} updated to {FILENAME} successful!");

            }
        }
    }
}
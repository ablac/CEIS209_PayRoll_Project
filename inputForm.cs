using System;
using System.Windows.Forms;
//****************************************************************************************************************
//****************************************************INPUTFORM***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        //************************************
        //***********SUBMIT BUTTON************
        //************************************
        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        //************************************
        //************EXIT BUTTON*************
        //************************************
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void hourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowControls();
        }

        private void salaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowControls();
        }
        private void ShowControls()
        {
            //Show the Appropriate Controls
            if (hourlyRadioButton.Checked)
            {
                pay1Label.Text = "Hourly Rate: ";
                pay2Label.Text = "Hours Worked: ";
                pay2Label.Visible = true;
                pay2TextBox.Visible = true;
            }
            else if (salaryRadioButton.Checked)
            {
                pay1Label.Text = "Annual Salary: ";
                pay2Label.Visible = false;
                pay2TextBox.Visible = false;
            }
        }
    }
}
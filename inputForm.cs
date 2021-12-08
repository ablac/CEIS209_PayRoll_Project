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
    }
}
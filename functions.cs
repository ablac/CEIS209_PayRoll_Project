using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//****************************************************************************************************************
//****************************************************FUNCTIONS***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class MainForm
    {
        //***************************************************
        //********************MESSAGE BOX********************
        //***************************************************
        private void MB(string Text, string Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title, MessageBoxButtons.OKCancel, ICON);
        }
    }
}
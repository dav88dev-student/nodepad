using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nodepad
{
    public partial class FindDialog : Form
    {

        private Form1 parentForm;

        public FindDialog(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
        }

        private void findButtonClick(object sender, EventArgs e)
        {
            string userInput =  parentForm.getMainTextBox().Text;
            int index2 = userInput.IndexOf(searchString.Text);
            if (index2 != -1)
            {
                parentForm.getMainTextBox().SelectionStart = 0;
                parentForm.getMainTextBox().SelectionLength = searchString.Text.Length;
                this.Hide();
            }               
            else
                MessageBox.Show("Cannot find '"+ searchString.Text + "'");

        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

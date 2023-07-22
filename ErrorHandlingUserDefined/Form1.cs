using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorHandlingUserDefined
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Names NameVar = new Names();

            try
            {
                NameVar.showName(txtCorrectName.Text, txtInputName.Text);
            }
            catch (InvalidNameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Thanks");
            }
        }
    }
    public class InvalidNameException : ApplicationException
    {
        public InvalidNameException(string message)
            : base(message)
        { }

    }
    class Names
    {
        public void showName(string correctName, string inputName)
        {
            if (correctName != inputName)
            {
                throw (new InvalidNameException("Invalid Name found"));
            }
            else
            {
                MessageBox.Show("Correct Name is: " + correctName);
            }
        }

    }
}

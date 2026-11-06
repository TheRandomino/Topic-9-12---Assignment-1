using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_12___Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double number1, number2;
        string factor;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != null)
            {

                if (Double.TryParse(txtNumber1.Text, out number1))
                {

                }
                else
                {
                    lblInvalid.Visible = true;
                }
            }
            else
            {
                lblInvalid.Visible = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnExponent_Click(object sender, EventArgs e)
        {

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            
        }
    }
}

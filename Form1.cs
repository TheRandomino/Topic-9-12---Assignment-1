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
                    factor = "+";
                    lblCalculation.Text = (number1 + " " + factor);
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnDivide.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnExponent.Enabled = false;
                    txtNumber1.Enabled = false;
                    txtNumber1.Visible = false;
                    lblInvalid.Visible = false;
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
            if (txtNumber1.Text != null)
            {

                if (Double.TryParse(txtNumber1.Text, out number1))
                {
                    factor = "-";
                    lblCalculation.Text = (number1 + " " + factor);
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnDivide.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnExponent.Enabled = false;
                    txtNumber1.Enabled = false;
                    txtNumber1.Visible = false;
                    lblInvalid.Visible = false;
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

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != null)
            {

                if (Double.TryParse(txtNumber1.Text, out number1))
                {
                    factor = "x";
                    lblCalculation.Text = (number1 + " " + factor);
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnDivide.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnExponent.Enabled = false;
                    txtNumber1.Enabled = false;
                    txtNumber1.Visible = false;
                    lblInvalid.Visible = false;
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

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != null)
            {

                if (Double.TryParse(txtNumber1.Text, out number1))
                {
                    factor = "÷";
                    lblCalculation.Text = (number1 + " " + factor);
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnDivide.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnExponent.Enabled = false;
                    txtNumber1.Enabled = false;
                    txtNumber1.Visible = false;
                    lblInvalid.Visible = false;
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

        private void btnExponent_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text != null)
            {

                if (Double.TryParse(txtNumber1.Text, out number1))
                {
                    factor = "^";
                    lblCalculation.Text = (number1 + " " + factor);
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnDivide.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnExponent.Enabled = false;
                    txtNumber1.Enabled = false;
                    txtNumber1.Visible = false;
                    lblInvalid.Visible = false;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            factor = null;
            txtNumber1.Text = null;
            txtNumber2.Text = null;
            txtNumber1.Visible = true;
            txtNumber1.Enabled = true;
            txtNumber2.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnExponent.Enabled = true;
            btnEquals.Enabled = true;
            lblCalculation.Text = null;
            lblInvalid.Visible = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            if (txtNumber2.Text != "")
            {

                if (Double.TryParse(txtNumber2.Text, out number2))
                {
                    lblInvalid.Visible = false;
                    btnEquals.Enabled = false;
                    txtNumber2.Enabled = false;
                    if (factor == "+")
                    {
                        lblCalculation.Text = (number1 + " " + factor + " " + number2 + " = " + (number1 + number2));
                    }
                    else if (factor == "-")
                    {
                        lblCalculation.Text = (number1 + " " + factor + " " + number2 + " = " + (number1 - number2));
                    }
                    else if (factor == "x")
                    {
                        lblCalculation.Text = (number1 + " " + factor + " " + number2 + " = " + (number1 * number2));
                    }
                    else if (factor == "÷")
                    {
                        lblCalculation.Text = (number1 + " " + factor + " " + number2 + " = " + (number1 / number2));
                    }
                    else if (factor == "^")
                    {
                        lblCalculation.Text = (number1 + " " + factor + " " + number2 + " = " + Math.Pow(number1, number2));
                    }
                    else
                    {
                        lblWhat.Visible = true;
                    }
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
    }
}

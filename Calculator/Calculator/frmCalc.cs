using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author : Matthew Gilbert
// Creation Date : 6/6/2019
// Version : 1.0
// Version Control: https://github.com/TrebliGM/Calculator

namespace Calculator
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Adds "1" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Adds "2" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Adds "3" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Adds "4" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Adds "5" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Adds "6" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Adds "7" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Adds "8" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // Adds "9" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // Adds "0" to the display text box
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the display text box
            txtDisplay.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // Adds "." to the display text box
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        // Calculator Variables
        double total1 = 0;                  // Total 1 Variable Double
        double total2 = 0;                  // Total 2 Variable Double
        bool plusButtonClicked = false;     // Addition check Boolean Variable
        bool minusButtonClicked = false;    // Subtraction check Boolean Variable
        bool divideButtonClicked = false;   // Divison check Boolean Variable
        bool multiplybuttonClicked = false; // Multiplication check Boolean Variable

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                // Adds the display text to the total1 variable parse double
                total1 += double.Parse(txtDisplay.Text);
                // Clears the display text
                txtDisplay.Clear();

                // plus boolean set to true, other to false
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplybuttonClicked = false;
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtDisplay.Text))
            {
                // Adds the display text to the total1 variable parse double
                total1 += double.Parse(txtDisplay.Text);
                // Clears the display text
                txtDisplay.Clear();

                // minus boolean set to true, other to false
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplybuttonClicked = false;
            }  
            else
            {
                txtDisplay.Text += "-";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                // Adds the display text to the total1 variable parse double
                total1 += double.Parse(txtDisplay.Text);
                // Clears the display text
                txtDisplay.Clear();

                // divide boolean set to true, other to false
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = true;
                multiplybuttonClicked = false;
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                // Adds the display text to the total1 variable parse double
                total1 += double.Parse(txtDisplay.Text);
                // Clears the display text
                txtDisplay.Clear();

                // multiply boolean set to true, other to false
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplybuttonClicked = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                // Check which boolean variable is set to true
                if (plusButtonClicked == true)
                {
                    // Set total2 to total1 + display text
                    total2 = BasicMath.Arithmetic.Add(total1, double.Parse(txtDisplay.Text));
                    //total2 = total1 + double.Parse(txtDisplay.Text);
                }
                else if (minusButtonClicked == true)
                {
                    // Set total2 to total1 - display text
                    total2 = BasicMath.Arithmetic.Subtract(total1, double.Parse(txtDisplay.Text));
                    //total2 = total1 - double.Parse(txtDisplay.Text);
                }
                else if (divideButtonClicked == true)
                {
                    // Set total2 to total1 / display text
                    total2 = Math.Round(BasicMath.Arithmetic.Divide(total1, double.Parse(txtDisplay.Text)), 6);
                    //total2 = total1 / double.Parse(txtDisplay.Text);
                }
                else if (multiplybuttonClicked == true)
                {
                    // Set total2 to total1 * display text
                    total2 = Math.Round(BasicMath.Arithmetic.Multiply(total1, double.Parse(txtDisplay.Text)), 6);
                    //total2 = total1 * double.Parse(txtDisplay.Text);
                }

                // Set display text to total 2
                txtDisplay.Text = total2.ToString();
                // Set total1 to 0
                total1 = 0;
            }
            catch(FileLoadException ex)
            {
                MessageBox.Show("Error Occured");
            }
            
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                // Variable to hold display text number
                double num = double.Parse(txtDisplay.Text);

                // If num is greater than or equal to 0
                if (num >= 0)
                {
                    // Set display text to result returned from SquareRoot Method
                    txtDisplay.Text = Math.Round(BasicMath.Algebraic.SquareRoot(num), 6).ToString();
                    //txtDisplay.Text = SquareRoot(num).ToString();
                }
                else
                {
                    // Display Error Message
                    MessageBox.Show("Number must be positive", "Error Message");
                    // Set Display text to 0
                    txtDisplay.Text = "0";
                }
            }
        }
        
        // Square Root Method
        private double SquareRoot(double num)
        {
            // Square root number and return result
            return Math.Sqrt(num);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If User Clicks OK to Quit Close Application Else do Nothing
            if (MessageBox.Show("Do you want to Quit?", "Quit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Close Application
                Application.Exit();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear display text box
            txtDisplay.Clear();
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);

                // Set display text to result returned from CubeRoot Method
                txtDisplay.Text = Math.Round(BasicMath.Algebraic.CubeRoot(num), 6).ToString();
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);

                // Set display text to result returned from CubeRoot Method
                txtDisplay.Text = Math.Round(BasicMath.Algebraic.Inverse(num), 6).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);

                if (num == 90 || num == 270)
                {
                    MessageBox.Show(num + " is undefined!");
                }
                else
                {
                    double radians = num * (Math.PI / 180);
                    // Set display text to result returned from CubeRoot Method
                    txtDisplay.Text = Math.Round(BasicMath.Trigonometric.Tan(radians), 6).ToString();
                }

            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);

                double radians = num * (Math.PI / 180);
                // Set display text to result returned from CubeRoot Method
                txtDisplay.Text = Math.Round(BasicMath.Trigonometric.Sin(radians), 6).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                double num = double.Parse(txtDisplay.Text);

                double radians = num * (Math.PI / 180);
                // Set display text to result returned from CubeRoot Method
                txtDisplay.Text = Math.Round(BasicMath.Trigonometric.Cosine(radians), 6).ToString();
            }
        }
    }
}

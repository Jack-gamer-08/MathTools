using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTools
{
    public partial class MathTools : Form
    {
        public MathTools()
        {
            InitializeComponent();
        }

        private void MathTools_Load(object sender, EventArgs e)
        {
            indicator1.BackColor = Color.FromArgb(71, 48, 184);
            GCDandLCMinvalidInput.Hide();

            interestInvalidInput1.Hide();
            interestInvalidInput2.Hide();
            interestInvalidInput3.Hide();
            normalInterestBtn.Checked = true;
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator1.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(0);
        }

        private void option2_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator2.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(1);
        }

        private void option3_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator3.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(2);
        }

        private void option4_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator4.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(3);
        }

        private void option5_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator5.BackColor = Color.FromArgb(71, 48, 184);
        }

        private void option6_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator6.BackColor = Color.FromArgb(71, 48, 184);
        }

        private void option7_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator7.BackColor = Color.FromArgb(71, 48, 184);
        }

        private void option8_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator8.BackColor = Color.FromArgb(71, 48, 184);
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            indicatorsOff();
        }

        private void indicatorsOff()
        {
            indicator1.BackColor = Color.FromArgb(50, 47, 106);
            indicator2.BackColor = Color.FromArgb(50, 47, 106);
            indicator3.BackColor = Color.FromArgb(50, 47, 106);
            indicator4.BackColor = Color.FromArgb(50, 47, 106);
            indicator5.BackColor = Color.FromArgb(50, 47, 106);
            indicator6.BackColor = Color.FromArgb(50, 47, 106);
            indicator7.BackColor = Color.FromArgb(50, 47, 106);
            indicator8.BackColor = Color.FromArgb(50, 47, 106);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool isValid(String input, int t)
        {
            bool value = true;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || (c == ' ' && (t == 1)) || (c == ',' && (t == 2))))
                {
                    value = false;
                }
            }
            return value;
        }

        private void calculateGCDandLCM_Click(object sender, EventArgs e)
        {
            GCDandLCMcalculator(GCDandLCMinput.Text);
        }

        private void GCDandLCMcalculator(string input)
        {
            if(input.Replace(" ", "") != "")
            {
                if (input[input.Length - 1] == ' ')
                {
                    string temp = input;
                    input = "";
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        input += temp[i];
                    }
                    GCDandLCMcalculator(input);
                }
                else if (isValid(input, 1))
                {
                    GCDandLCMinvalidInput.Hide();
                    string[] strings = input.Split(' ');
                    int[] ints = new int[strings.Length];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        ints[i] = Convert.ToInt32(strings[i]);
                    }
                    GCDoutput.Text = "" + calculateGCD(ints);
                    LCMoutput.Text = "" + calculateLCM(ints);
                }
                else
                {
                    GCDandLCMinvalidInput.Show();
                    GCDoutput.Text = "";
                    LCMoutput.Text = "";
                }
            }
            else
            {
                GCDandLCMinvalidInput.Show();
                GCDoutput.Text = "";
                LCMoutput.Text = "";
                GCDandLCMinput.Text = "";
            }
        }

        private int calculateGCD(int[] ints)
        {
            int result = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                result = gcd(ints[i], result);
                if (result == 1)
                {
                    return 1;
                }
            }
            return result;
        }

        private int gcd(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            return gcd(b % a, a);
        }

        private long calculateLCM(int[] ints)
        {
            long result = 1;
            int divisor = 2;

            while (true)
            {
                int counter = 0;
                bool divisible = false;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] == 0)
                    {
                        return 0;
                    }
                    else if (ints[i] < 0)
                    {
                        ints[i] = ints[i] * (-1);
                    }
                    if (ints[i] == 1)
                    {
                        counter++;
                    }if (ints[i] % divisor == 0)
                    {
                        divisible = true;
                        ints[i] = ints[i] / divisor;
                    }
                }
                if (divisible)
                {
                    result = result * divisor;
                }
                else
                {
                    divisor++;
                }
                if (counter == ints.Length)
                {
                    return result;
                }
            }
        }

        private void GCDandLCMinput_Select(object sender, EventArgs e)
        {
            GCDandLCMinput.SelectAll();
        }

        private void calculateInterestBtn_Click(object sender, EventArgs e)
        {
            string amount = amountInput.Text.Replace(" ", "").Replace(".", ",");
            string rate = rateInput.Text.Replace(" ", "").Replace(".", ",");
            string years = yearsInput.Text.Replace(" ", "");
            bool validInputs = true;
            if (!isValid(amount, 2) || amount == "")
            {
                validInputs = false;
                interestInvalidInput1.Show();
            }
            else interestInvalidInput1.Hide();
            if (!isValid(rate, 2) || rate == "")
            {
                validInputs = false;
                interestInvalidInput2.Show();
            }
            else interestInvalidInput2.Hide();
            if (!isValid(years, 0) || years == "")
            {
                validInputs = false;
                interestInvalidInput3.Show();
                amountInput.SelectAll();
            }
            else interestInvalidInput3.Hide();
            if(validInputs)
            {
                double a = Convert.ToDouble(amount);
                double r = Convert.ToDouble(rate) / 100;
                int y = Convert.ToInt32(years);
                if(normalInterestBtn.Checked)
                {
                    double total = Math.Round(a*(1 + y*r)*1000) / 1000;
                    totalOutput.Text = "" + total;
                    interestOutput.Text = "" + (total - a);
                }
                else if (compoundInterestBtn.Checked)
                {
                    double total = Math.Round((a * Math.Pow(1 + r, y)) * 1000) / 1000;
                    totalOutput.Text = "" + total;
                    interestOutput.Text = "" + (total - a);
                }
            }
            else
            {
                totalOutput.Text = "";
                interestOutput.Text = "";
            }
        }

        private void amountInput_Select(object sender, EventArgs e)
        {
            amountInput.SelectAll();
        }

        private void rateInput_Select(object sender, EventArgs e)
        {
            rateInput.SelectAll();
        }

        private void yearsInput_Select(object sender, EventArgs e)
        {
            yearsInput.SelectAll();
        }

        private void totalOutput_Select(object sender, EventArgs e)
        {
            totalOutput.SelectAll();
        }

        private void interestOutput_Select(object sender, EventArgs e)
        {
            interestOutput.SelectAll();
        }
    }
}
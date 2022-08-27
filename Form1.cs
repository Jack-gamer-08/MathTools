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

            conversionInvalidInput.Hide();

            invalidCoeffs.Hide();
            secondSol.Hide();

            romanInvalidInput.Hide();
            arabicInvalidInput.Hide();
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
            tabControl.SelectTab(4);
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
                if (!(c == '0' || c == '1' || (c == '2' && t != 3) || (c == '3' && t != 3) || (c == '4' && t != 3) || (c == '5' && t != 3) || (c == '6' && t != 3) || (c == '7' && t != 3) || (c == '8' && t != 3 && t != 4) || (c == '9' && t != 3 && t != 4) || (c == ' ' && (t == 1)) || (c == ',' && (t == 2 || t == 6)) || (c == '-' && (t == 6)) || (c == 'A' && t == 5) || (c == 'B' && t == 5) || (c == 'C' && t == 5) || (c == 'D' && t == 5) || (c == 'E' && t == 5) || (c == 'F' && t == 5)))
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

        private int calculateGCD(int[] ints) //not my code
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

        private int gcd(int a, int b) //some euclidian stuff
        {
            if (a == 0)
            {
                return b;
            }
            return gcd(b % a, a);
        }

        private long calculateLCM(int[] ints) //again not my code lol
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

        private void GCDoutput_Select(object sender, EventArgs e)
        {
            GCDoutput.SelectAll();
        }

        private void LCMoutput_Select(object sender, EventArgs e)
        {
            LCMoutput.SelectAll();
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

        private void convertBtn_Click(object sender, EventArgs e)
        {
            convert(conversionInput.Text);
        }

        private void convert(string input)
        {
            if (input.Replace(" ", "") != "")
            {
                if (input[input.Length - 1] == ' ')
                {
                    string temp = input;
                    input = "";
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        input += temp[i];
                    }
                    convert(input);
                }
                else
                {
                    int start = startBase.SelectedIndex + 1;
                    int end = endBase.SelectedIndex + 1;
                    int t;
                    switch (start)
                    {
                        case 1:
                            t = 3;
                            break;
                        case 2:
                            t = 4;
                            break;
                        case 4:
                            t = 5;
                            break;
                        default:
                            t = 0;
                            break;
                    }
                    if (!isValid(input.ToUpper(), t))
                    {
                        conversionInvalidInput.Show();
                        conversionOutput.Text = "";
                    }
                    else
                    {
                        conversionInvalidInput.Hide();
                        int decimalInput = 0;
                        switch(start)
                        {
                            case 1:
                                decimalInput = Convert.ToInt32(input, 2);
                                break;
                            case 2:
                                decimalInput = Convert.ToInt32(input, 8);
                                break;
                            case 3:
                                decimalInput = Convert.ToInt32(input);
                                break;
                            case 4:
                                decimalInput = Convert.ToInt32(input, 16);
                                break;
                        }
                        string output = "";
                        switch(end)
                        {
                            case 1:
                                output = Convert.ToString(decimalInput, 2);
                                break;
                            case 2:
                                output = Convert.ToString(decimalInput, 8);
                                break;
                            case 3:
                                output = Convert.ToString(decimalInput);
                                break;
                            case 4:
                                output = Convert.ToString(decimalInput, 16);
                                break;
                        }
                        conversionOutput.Text = output;
                    }
                }
            }
            else
            {
                conversionInvalidInput.Show();
                conversionOutput.Text = "";
                conversionInput.Text = "";
            }
        }

        private void conversionInput_Select(object sender, EventArgs e)
        {
            conversionInput.SelectAll();
        }

        private void conversionOutput_Select(object sender, EventArgs e)
        {
            conversionOutput.SelectAll();
        }

        private void solveBtn_Click(object sender, EventArgs e) //just quadratic equation
        {
            firstSol.Text = "X =";
            secondSol.Text = "X =";

            string firstCoeff = xSquaredCoeff.Text.Replace(" ", "").Replace(".", ",");
            string secondCoeff = xCoeff.Text.Replace(" ", "").Replace(".", ",");
            string thirdCoeff = knownTerm.Text.Replace(" ", "").Replace(".", ",");

            if (!(isValid(firstCoeff, 6) && isValid(secondCoeff, 6) && isValid(thirdCoeff, 6) && firstCoeff != "" && secondCoeff != "" && thirdCoeff != ""))
            {
                invalidCoeffs.Show();
                deltaLabel.Text = "Delta:";
            }
            else
            {
                invalidCoeffs.Hide();

                double a = Convert.ToDouble(firstCoeff);
                double b = Convert.ToDouble(secondCoeff);
                double c = Convert.ToDouble(thirdCoeff);
                
                double delta = b*b - 4*a*c;
                deltaLabel.Text = "Delta: " + delta;
                if(delta < 0)
                {
                    secondSol.Show();
                    firstSol.Text += ((b != 0) ? (-b / 2 + " + ") : "") + ((Math.Sqrt(-delta) / 2 == 1) ? " " : ("" + Math.Sqrt(-delta) / 2)) + "i";
                    secondSol.Text += ((b != 0) ? ("" + -b / 2) : "") + " -" + ((Math.Sqrt(-delta) / 2 == 1) ? "" : (" " + Math.Sqrt(-delta) / 2)) + "i";
                }
                else if(delta == 0)
                {
                    secondSol.Hide();
                    firstSol.Text = "" + -b/2;
                }
                else
                {
                    secondSol.Show();
                    firstSol.Text = "X = " + (-b - Math.Sqrt(delta)) / 2;
                    secondSol.Text = "X = " + (-b + Math.Sqrt(delta)) / 2;
                }
            }
        }

        private void xSquaredCoeff_Select(object sender, EventArgs e)
        {
            xSquaredCoeff.SelectAll();
        }

        private void xCoeff_Select(object sender, EventArgs e)
        {
            xCoeff.SelectAll();
        }

        private void knownTerm_Select(object sender, EventArgs e)
        {
            knownTerm.SelectAll();
        }

        private bool isValidNumeral(string input)
        {
            bool value = true;
            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if(!(c == 'I' || c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M'))
                {
                    value = false;
                }
            }
            return value;
        }

        private void romanToArabicBtn_Click(object sender, EventArgs e)
        {
            string input = romanInput.Text.ToUpper().Replace(" ", "");
            if (!isValidNumeral(input) || input == "")
            {
                romanInvalidInput.Show();
            }
            else
            {
                romanInvalidInput.Hide();

                int sum = 0;
                Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }
                };

                for(int i = 0; i < input.Length; i++)
                {
                    romanDictionary.TryGetValue(input[i], out int number);
                    if(i + 1 < input.Length && romanDictionary[input[i + 1]] > romanDictionary[input[i]])
                    {
                        sum -= number;
                    }
                    else
                    {
                        sum += number;
                    }
                }
                if(sum < 4000)
                {
                    arabicOutput.Text = "" + sum;
                    romanInput.Text = input;
                }
                else
                {
                    romanInvalidInput.Show();
                }
            }
        }

        private static StringBuilder romanBuilder = new StringBuilder();

        private void arabicToRomanBtn_Click(object sender, EventArgs e)
        {
            string input = arabicInput.Text.Replace(" ", "");
            if (!isValid(input, 0) || input == "")
            {
                arabicInvalidInput.Show();
                romanOutput.Text = "";
            }
            else if (Convert.ToInt32(input) > 3999 || Convert.ToInt32(input) < 1)
            {
                arabicInvalidInput.Show();
                romanOutput.Text = "";
            }
            else //code by some random guy on github cause I can't bother
            {
                arabicInvalidInput.Hide();

                romanBuilder.Clear();
                toRoman(Convert.ToInt32(input));
                romanOutput.Text = romanBuilder.ToString();
            }
        }
        
        private readonly static Dictionary<int, string> ArabicAux = new Dictionary<int, string>() {
            { 3000, "MMM" },
            { 2000, "MM" },
            { 1000, "M" },
            { 900, "CM" },
            { 800, "DCCC" },
            { 700, "DCC" },
            { 600, "DC" },
            { 500, "D" },
            { 400, "CD" },
            { 300, "CCC" },
            { 200, "CC" },
            { 100, "C" },
            { 90, "XC" },
            { 80, "LXXX" },
            { 70, "LXX" },
            { 60, "LX" },
            { 50, "L" },
            { 40, "XL" },
            { 30, "XXX" },
            { 20, "XX" },
            { 10, "X" },
            { 9, "IX" },
            { 8, "VIII" },
            { 7, "VII" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 3, "III" },
            { 2, "II" },
            { 1, "I" },
        };

        public static void toRoman(int arabic) //what the heck?????
        {
            int mod = 0;
            foreach (KeyValuePair<int, string> item in ArabicAux)
            {
                if (arabic / item.Key > 0)
                {
                    romanBuilder.Append($"{item.Value}");
                    mod = arabic % item.Key;
                    if (mod > 0)
                    {
                        toRoman(mod);
                    }
                    break;
                }
            }
        }

        private void romanInput_Select(object sender, EventArgs e)
        {
            romanInput.SelectAll();
        }

        private void arabicOutput_Select(object sender, EventArgs e)
        {
            arabicOutput.SelectAll();
        }

        private void arabicInput_Select(object sender, EventArgs e)
        {
            arabicInput.SelectAll();
        }

        private void romanOutput_Select(object sender, EventArgs e)
        {
            romanOutput.SelectAll();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;

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

            invalidWeightInput.Hide();
            invalidLengthInput.Hide();

            currencyInvalidInput.Hide();
            currencyNoConnection.Hide();

            randomInvalidInputs.Hide();
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

        static bool allowConnection = true;
        private static bool connectionCheck()
        {
            if (allowConnection)
            {
                try
                {
                    Ping myPing = new Ping();
                    String host = "google.com";
                    byte[] buffer = new byte[32];
                    int timeout = 1000;
                    PingOptions pingOptions = new PingOptions();
                    PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                    return (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else return false;
        }
        bool internetConnection = connectionCheck();

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
            tabControl.SelectTab(5);
        }

        private void option7_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator7.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(6);
        }

        private void option8_Click(object sender, EventArgs e)
        {
            indicatorsOff();
            indicator8.BackColor = Color.FromArgb(71, 48, 184);
            tabControl.SelectTab(7);
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

        private void calculateGCDandLCMbtn_Click(object sender, EventArgs e)
        {
            GCDandLCMcalculator(GCDandLCMinput.Text);
        }

        private void GCDandLCMinput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GCDandLCMcalculator(GCDandLCMinput.Text);
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Escape)
            {
                GCDandLCMinput.DeselectAll();
                e.SuppressKeyPress = true;
            }
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

        private void convertBaseBtn_Click(object sender, EventArgs e)
        {
            convert(conversionInput.Text);
        }

        private void conversionInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                convert(conversionInput.Text);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                conversionInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
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
                    if (!isValid(input.ToUpper(), t) || startBase.SelectedIndex == -1 || endBase.SelectedIndex == -1)
                    {
                        conversionInvalidInput.Show();
                        baseConversionOutput.Text = "";
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
                        baseConversionOutput.Text = output;
                    }
                }
            }
            else
            {
                conversionInvalidInput.Show();
                baseConversionOutput.Text = "";
                conversionInput.Text = "";
            }
        }

        private void conversionInput_Select(object sender, EventArgs e)
        {
            conversionInput.SelectAll();
        }

        private void conversionOutput_Select(object sender, EventArgs e)
        {
            baseConversionOutput.SelectAll();
        }

        private void solveBtn_Click(object sender, EventArgs e) //just quadratic equation
        {
            firstSol.Text = "X =";
            secondSol.Text = "X =";

            string firstCoeff = xSquaredCoeff.Text.Replace(" ", "").Replace(".", ",");
            string secondCoeff = xCoeff.Text.Replace(" ", "").Replace(".", ",");
            string thirdCoeff = knownTerm.Text.Replace(" ", "").Replace(".", ",");

            if (!(isValid(firstCoeff, 6) && isValid(secondCoeff, 6) && isValid(thirdCoeff, 6) && string.IsNullOrEmpty(firstCoeff.Replace(",", "")) && string.IsNullOrEmpty(secondCoeff.Replace(",", "")) && string.IsNullOrEmpty(thirdCoeff.Replace(",", ""))))
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
            romanToArabic();
        }

        private void romanInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                romanToArabic();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                romanInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void romanToArabic()
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
            arabicToRoman();
        }

        private void arabicInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                arabicToRoman();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                arabicInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void arabicToRoman()
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

        Dictionary<string, double> weightDictionary = new Dictionary<string, double>() //kilogram is the base
        {
            {"Gram", 0.001 },
            {"Kilogram", 1 },
            {"Ton", 1000 },
            {"Ounce", 0.0283495 },
            {"Pound", 0.453592 },
            {"Stone", 6.35029 }
        };

        private void weightInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                convertWeight();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                weightInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void convertWeightBtn_Click(object sender, EventArgs e)
        {
            convertWeight();
        }

        private void convertWeight()
        {
            string input = weightInput.Text.Replace(" ", "").Replace(".", ",");
            if(!isValid(input, 2) || string.IsNullOrEmpty(input.Replace(",", "")) || startWeight.SelectedIndex == -1 || endWeight.SelectedIndex == -1)
            {
                invalidWeightInput.Show();
            }
            else
            {
                invalidWeightInput.Hide();

                double startValue = weightDictionary[startWeight.SelectedItem as string];
                double endValue = weightDictionary[endWeight.SelectedItem as string];

                weightOutput.Text = "" + (1 / endValue * startValue * Convert.ToDouble(input));
            }
        }

        private void weightInput_Select(object sender, EventArgs e)
        {
            weightInput.SelectAll();
        }

        private void weightOutput_Select(object sender, EventArgs e)
        {
            weightOutput.SelectAll();
        }

        Dictionary<string, double> lengthDictionary = new Dictionary<string, double>()
        {
            {"Millimeter", 0.001 },
            {"Centimeter", 0.01 },
            {"Meter", 1 },
            {"Kilometer", 1000 },
            {"Inch", 0.0254 },
            {"Foot", 0.3048 },
            {"Yard", 0.9144 },
            {"Mile", 1609.344 },
            {"Nautical mile", 1852 }
        };

        private void lengthInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertLength();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lengthInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void convertLengthBtn_Click(object sender, EventArgs e)
        {
            convertLength();
        }

        private void convertLength()
        {
            string input = lengthInput.Text.Replace(" ", "").Replace(".", ",");
            if (!isValid(input, 2) || string.IsNullOrEmpty(input.Replace(", ", "")) || startLength.SelectedIndex == -1 || endLength.SelectedIndex == -1)
            {
                invalidLengthInput.Show();
            }
            else
            {
                invalidLengthInput.Hide();

                double startValue = lengthDictionary[startLength.SelectedItem as string];
                double endValue = lengthDictionary[endLength.SelectedItem as string];

                lengthOutput.Text = "" + (1 / endValue * startValue * Convert.ToDouble(input));
            }
        }

        private void lengthInput_Select(object sender, EventArgs e)
        {
            lengthInput.SelectAll();
        }

        private void lengthOutput_Select(object sender, EventArgs e)
        {
            lengthOutput.SelectAll();
        }

        private void currencyConversionInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                convertCurrency();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                currencyConversionInput.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void convertCurrencyBtn_Click(object sender, EventArgs e)
        {
            convertCurrency();
        }

        bool alreadyCalledApi = false;
        string exchangeRateApiKey = "9ddc3e999e421fc76d08f29d";
        string apiResponse = "";

        private void convertCurrency()
        {
            if (internetConnection)
            {
                currencyNoConnection.Hide();

                string input = currencyConversionInput.Text.Replace(" ", "").Replace(".", ",");

                if (!isValid(input, 2) || String.IsNullOrEmpty(input.Replace(",", "")) || startCurrency.SelectedIndex == -1 || endCurrency.SelectedIndex == -1)
                {
                    currencyInvalidInput.Show();
                }
                else
                {
                    currencyInvalidInput.Hide();

                    if (string.IsNullOrEmpty(exchangeRateApiKey))
                    {
                        throw new Exception("Please use a key to connect to the API");
                    }
                    else
                    {
                        if (!alreadyCalledApi)
                        {
                            alreadyCalledApi = true;

                            using (var client = new HttpClient())
                            {
                                try
                                {
                                    var endpoint = new Uri("https://v6.exchangerate-api.com/v6/" + exchangeRateApiKey + "/latest/EUR");

                                    apiResponse = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                            }
                        }

                        dynamic jsonFile = JsonConvert.DeserializeObject(apiResponse);

                        string startOption = startCurrency.SelectedItem as string;
                        string endOption = endCurrency.SelectedItem as string;
                        string startCode = "" + startOption[0] + startOption[1] + startOption[2];
                        string endCode = "" + endOption[0] + endOption[1] + endOption[2];
                        double start = jsonFile["conversion_rates"][startCode];
                        double end = jsonFile["conversion_rates"][endCode];

                        currencyConversionOutput.Text = "" + (1 / start * end * Convert.ToDouble(input));
                    }
                }
            }
            else
            {
                currencyNoConnection.Show();
            }
        }

        private void currencyConversionInput_Select(object sender, EventArgs e)
        {
            currencyConversionInput.SelectAll();
        }

        private void currencyConversionOutput_Select(object sender, EventArgs e)
        {
            currencyConversionOutput.SelectAll();
        }

        private void randomMin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && string.IsNullOrEmpty(randomMin.Text.Replace(" ", "").Replace(".", "").Replace(",", "")) && string.IsNullOrEmpty(randomMax.Text.Replace(" ", "").Replace(".", "").Replace(",", "")))
            {
                randomGenerate();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                randomMin.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void randomMax_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && string.IsNullOrEmpty(randomMin.Text.Replace(" ", "").Replace(".", "").Replace(",", "")) && string.IsNullOrEmpty(randomMax.Text.Replace(" ", "").Replace(".", "").Replace(",", "")))
            {
                randomGenerate();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                randomMax.DeselectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void randomGenerateBtn_Click(object sender, EventArgs e)
        {
            randomGenerate();
        }

        private void randomGenerate()
        {
            string minimum = randomMin.Text.Replace(" ", "");
            string maximum = randomMax.Text.Replace(" ", "");
            if(!isValid(minimum, 0) || !isValid(maximum, 0) || string.IsNullOrEmpty(minimum) || string.IsNullOrEmpty(maximum))
            {
                randomInvalidInputs.Show();
            }
            else
            {
                randomInvalidInputs.Hide();
                
                double min = Convert.ToDouble(minimum);
                double max = Convert.ToDouble(maximum);

                var rng = new Random();

                randomOutput.Text = "" + ((max - min) * rng.NextDouble() + min);
            }
        }

        private void randomMin_Select(object sender, EventArgs e)
        {
            randomMin.SelectAll();
        }

        private void randomMax_Select(object sender, EventArgs e)
        {
            randomMax.SelectAll();
        }
    }
}
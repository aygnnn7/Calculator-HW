namespace Calculator
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        
        private bool lastClickSign = false;

        private bool errorDivideByZero = false;


        private bool CheckForAction(string input, string btnNum)
        {
            if (btnNum.Contains('0') && input.Contains("0") && input.Length <= 1)
            {
                return true;
            }
            else if (input.Contains("0") && input.Length <= 1)
            {
                if (afterSqr)
                {
                    lastClickSign = false;
                    afterSqr = false;
                }

                tbInput.Text = btnNum;
                return true;
            }
            else if (lastClickSign)
            {

                lastClickSign = false;
                tbInput.Text = btnNum;
                return true;

            }
            return false;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c == '-' || c == ',' || c == '.') continue;
                if (c < '0' || c > '9') return false;
            }

            return true;
        }

        private bool madeOperation = false;

        //Operators
        private void BasicOperations()
        {
            FreePoint();
            if (tbSign.Text != "=") madeOperation = true;

            if (tbResult.Text == "")
            {
                tbResult.Text = tbInput.Text;
                return;
            }
            else if (lastClickSign && tbResult.Text == tbInput.Text)
            {
                return;
            }
            else
            {
                string result = BOperation(tbInput.Text, tbResult.Text);
                if (errorDivideByZero)
                {
                    clearAll();
                    MessageBox.Show("Cannot divide by zero!");
                }
                else
                {

                    tbResult.Text = result;
                    tbInput.Text = result;
                }
            }
        }

        private string BOperation(string inputBox, string resultBox)
        {
            FreePoint();
            //checks for inappropriate char;
            if (!IsDigitsOnly(inputBox) || !IsDigitsOnly(resultBox))
            {
                MessageBox.Show("The string contains inappropriate char!");
                return "undefined";
            }

            double num1 = double.Parse(resultBox);
            double num2 = double.Parse(inputBox);


            switch (tbSign.Text)
            {
                case "+":

                    return (num1 + num2).ToString();
                case "-":

                    return (num1 - num2).ToString();
                case "×":

                    return (num1 * num2).ToString();
                case "÷":

                    if (num2 == 0)
                    {
                        errorDivideByZero = true;
                        return "undefined";
                    };
                    return (num1 / num2).ToString();
                case "^":
                    return tbResult.Text;
                case "√":
                    return tbResult.Text;
                case "=":
                    return tbResult.Text = tbInput.Text;


            }

            return "undefined ";
        }

        //Clear all;

        private void clearAll()
        {

            tbInput.Text = "0";
            tbResult.Text = "";
            tbSign.Text = "";
            madeOperation = false;
            flaggedEqual = false;
            flaggedSqr = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //Number buttons

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "0";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "1";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (flaggedEqual || flaggedSqr) clearAll();

            string btnNum = "2";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "3";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "4";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "5";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "6";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "7";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flaggedEqual || flaggedSqr) clearAll();
            string btnNum = "8";
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
        }


        //Operations with equal button
        private void BOperationAfterEqual(string sign)
        {
            FreePoint();
            tbSign.Text = sign;
            tbResult.Text = tbInput.Text;
            flaggedEqual = false;
        }


        //Basic functions
        private void btnAdd_Click(object sender, EventArgs e)
        {

            flaggedSqr = false;
            string sign = "+";
            if (tbSign.Text == "=")
                BOperationAfterEqual(sign);

            else
                BasicOperations();

            if (!errorDivideByZero) tbSign.Text = sign;
            else errorDivideByZero = false;
            lastClickSign = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            flaggedSqr = false;
            string sign = "-";
            if (tbSign.Text == "=")
                BOperationAfterEqual(sign);

            else
                BasicOperations();



            if (!errorDivideByZero) tbSign.Text = sign;
            else errorDivideByZero = false;
            lastClickSign = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            flaggedSqr = false;
            string sign = "×";
            if (tbSign.Text == "=")
                BOperationAfterEqual(sign);

            else
                BasicOperations();

            if (!errorDivideByZero) tbSign.Text = sign;
            else errorDivideByZero = false;
            lastClickSign = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            flaggedSqr = false;
            string sign = "÷";
            if (tbSign.Text == "=")
                BOperationAfterEqual(sign);

            else
                BasicOperations();

            if (!errorDivideByZero) tbSign.Text = "÷";
            else errorDivideByZero = false;
            lastClickSign = true;
        }

        //Equal
        private bool flaggedEqual = false;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!madeOperation)
            {
                FreePoint();
                tbResult.Text = tbInput.Text;
                tbSign.Text = "=";
                flaggedEqual = true;
            }

            else
            {
                BasicOperations();
                if (tbResult.Text != "") tbSign.Text = "=";
                flaggedEqual = true;

            }
        }



        //Sqr functions
        private bool flaggedSqr = false;

        private bool afterSqr = false;
        private void Sqr(string sign, string input, string result)
        {
            afterSqr = true;
            string sqrNum;
            if (sign == "^")
                sqrNum = (Math.Pow(double.Parse(input), 2)).ToString();
            else if (sign == "√")
                sqrNum = (Math.Sqrt(double.Parse(input))).ToString();
            else throw new ArgumentException("another exit");


            if (result != "" && tbSign.Text != "^")
            {

                string tempRes = BOperation(sqrNum, result);
                tbInput.Text = sqrNum;
                tbResult.Text = tempRes;

            }
            else //((result == "") || (result != "" && (sign == "^" || sign=="=")))
            {
                tbInput.Text = sqrNum;
                tbResult.Text = sqrNum;
            }

            tbSign.Text = sign;
            lastClickSign = true;
            flaggedSqr = true;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            Sqr("^", tbInput.Text, tbResult.Text);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Sqr("√", tbInput.Text, tbResult.Text);
        }


        //Decimal point button
        private void FreePoint()
        {
            string num = tbInput.Text;
            if (num[num.Length - 1] == '.') tbInput.Text = num.Remove(num.Length - 1);
        }

        private void btnDecimalP_Click(object sender, EventArgs e)
        {
            if (lastClickSign)
            {

                lastClickSign = false;
                tbInput.Text = "0.";
            }
            else
            {

                foreach (char c in tbInput.Text)
                    if (c == '.') return;
                tbInput.Text += ".";
            }
        }

        
        //Erase button (backspace)
        private void btnErase_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            if (tbSign.Text == "=" || tbSign.Text == "^" || tbSign.Text == "√") return;

            if (input.Length > 1)
                tbInput.Text = input.Remove(input.Length - 1);
            else
                tbInput.Text = "0";
        }

        internal string memorizedNum;

       
        //Memory buttons M+, M-, MR, MC
        private void Memorize(string func)
        {

            if (string.IsNullOrEmpty(memorizedNum)) memorizedNum = tbInput.Text;
            else
            {
                if (func == "+")
                {
                    memorizedNum = (double.Parse(memorizedNum) + double.Parse(tbInput.Text)).ToString();    
                }
                else //(func=="-")
                {
                    memorizedNum = (double.Parse(memorizedNum) - double.Parse(tbInput.Text)).ToString();
                }
            }
            if (flaggedEqual)
            {
                tbResult.Text = "";
                tbSign.Text = "";
                flaggedEqual = false;

            }

            lastClickSign = true;
            btnMC.Enabled = true;
            btnMR.Enabled = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            Memorize("+");
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            Memorize("-");
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memorizedNum = null;
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            tbInput.Text = memorizedNum;
        }
    }
}

namespace Calculator
{
    using System;
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

        //Check - contains only 0 / last clicked buttons is sign or not 
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

        //Check - if string is only digit
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c == '-' || c == ',' || c == '.') continue;
                if (c < '0' || c > '9') return false;
            }

            return true;
        }

        //Basic operations

        private bool madeOperation = false;

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

        private void basicFunction_Click(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            //if (sign.Length > 1) throw new ArgumentException(sign, "sign should be only one character");
            flaggedSqr = false;

            if (tbSign.Text == "=") BOperationAfterEqual(sign);
            else BasicOperations();
            if (!errorDivideByZero) tbSign.Text = sign;
            else errorDivideByZero = false;

            lastClickSign = true;
        }

        //Clear
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

        private void btnNum_Click(object sender, EventArgs e)
        {
            string btnNum = (sender as Button).Text;
            if (flaggedEqual || flaggedSqr) clearAll();
            if (CheckForAction(tbInput.Text, btnNum)) return;
            tbInput.Text += btnNum;
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
            }
            else
            {
                BasicOperations();
                if (tbResult.Text != "") tbSign.Text = "=";
            }
            flaggedEqual = true;
        }

        private void BOperationAfterEqual(string sign)
        {
            FreePoint();
            tbSign.Text = sign;
            tbResult.Text = tbInput.Text;
            flaggedEqual = false;
        }

        //Sqrt & pow(x, 2)

        private bool flaggedSqr = false;

        private bool afterSqr = false;

        private void sqrFunc_Click(object sender, EventArgs e)
        {
            afterSqr = true;
            string sqrNum;
            string sign;
            if ((sender as Button).Text == "x²") sign = "^";
            else sign = "√";
            if (sign == "^") sqrNum = (Math.Pow(double.Parse(tbInput.Text), 2)).ToString();
            else sqrNum = (Math.Sqrt(double.Parse(tbInput.Text))).ToString();

            tbInput.Text = sqrNum;

            if (tbResult.Text != "" && tbSign.Text != "^") tbResult.Text = BOperation(sqrNum, tbResult.Text);
            else tbResult.Text = sqrNum;

            tbSign.Text = sign;
            lastClickSign = true;
            flaggedSqr = true;
        }

        //Decimal Point

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

        //Erase

        private void btnErase_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            if (tbSign.Text == "=" || tbSign.Text == "^" || tbSign.Text == "√") return;

            if (input.Length > 1)
                tbInput.Text = input.Remove(input.Length - 1);
            else
                tbInput.Text = "0";
        }

        //Memory buttons

        internal string memorizedNum;

        private void memorize_Click(object sender, EventArgs e)
        {
            string func;
            if ((sender as Button).Text == "M+") func = "+";
            else func = "-";
            if (string.IsNullOrEmpty(memorizedNum)) memorizedNum = tbInput.Text;
            else
            {
                if (func == "+")
                    memorizedNum = (double.Parse(memorizedNum) + double.Parse(tbInput.Text)).ToString();
                else //(func=="-")
                    memorizedNum = (double.Parse(memorizedNum) - double.Parse(tbInput.Text)).ToString();
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


namespace Calculator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnDecimalP = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lblStandard = new System.Windows.Forms.Label();
            this.tbSign = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.panelButtons.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelButtons.Controls.Add(this.btnDivide);
            this.panelButtons.Controls.Add(this.btnSqrt);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnErase);
            this.panelButtons.Controls.Add(this.btnDecimalP);
            this.panelButtons.Controls.Add(this.btnMultiply);
            this.panelButtons.Controls.Add(this.btnSub);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEqual);
            this.panelButtons.Controls.Add(this.btnPow);
            this.panelButtons.Controls.Add(this.btn0);
            this.panelButtons.Controls.Add(this.btn9);
            this.panelButtons.Controls.Add(this.btn8);
            this.panelButtons.Controls.Add(this.btn7);
            this.panelButtons.Controls.Add(this.btn6);
            this.panelButtons.Controls.Add(this.btn5);
            this.panelButtons.Controls.Add(this.btn4);
            this.panelButtons.Controls.Add(this.btn3);
            this.panelButtons.Controls.Add(this.btn2);
            this.panelButtons.Controls.Add(this.btn1);
            this.panelButtons.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 184);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(784, 520);
            this.panelButtons.TabIndex = 0;
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDivide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivide.Location = new System.Drawing.Point(395, 54);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(187, 82);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.basicFunction_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSqrt.Location = new System.Drawing.Point(200, 54);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(187, 82);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.sqrFunc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Brown;
            this.btnClear.Location = new System.Drawing.Point(3, 431);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 82);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnErase
            // 
            this.btnErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnErase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnErase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnErase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnErase.Location = new System.Drawing.Point(593, 54);
            this.btnErase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(187, 82);
            this.btnErase.TabIndex = 16;
            this.btnErase.Text = "⌫";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnDecimalP
            // 
            this.btnDecimalP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecimalP.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDecimalP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecimalP.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnDecimalP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDecimalP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDecimalP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimalP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDecimalP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDecimalP.Location = new System.Drawing.Point(395, 432);
            this.btnDecimalP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecimalP.Name = "btnDecimalP";
            this.btnDecimalP.Size = new System.Drawing.Size(187, 82);
            this.btnDecimalP.TabIndex = 15;
            this.btnDecimalP.Text = ".";
            this.btnDecimalP.UseVisualStyleBackColor = false;
            this.btnDecimalP.Click += new System.EventHandler(this.btnDecimalP_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.Location = new System.Drawing.Point(593, 148);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(187, 82);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.basicFunction_Click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.btnSub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSub.Location = new System.Drawing.Point(593, 243);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(187, 82);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.basicFunction_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(593, 337);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 82);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.basicFunction_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEqual.BackColor = System.Drawing.Color.Brown;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEqual.Location = new System.Drawing.Point(593, 432);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(187, 82);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPow
            // 
            this.btnPow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPow.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPow.Location = new System.Drawing.Point(3, 54);
            this.btnPow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(187, 82);
            this.btnPow.TabIndex = 10;
            this.btnPow.Text = "x²";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.sqrFunc_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn0.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(199, 432);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(187, 82);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn9.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(395, 148);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(187, 82);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn8.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(200, 148);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(187, 82);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn7.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(3, 148);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(187, 82);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn6.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(395, 243);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(187, 82);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn5.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(199, 243);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(187, 82);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn4.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(3, 243);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(187, 82);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(395, 337);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(187, 82);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(199, 337);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(187, 82);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(3, 337);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(187, 82);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMMinus.FlatAppearance.BorderSize = 0;
            this.btnMMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMinus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMMinus.Location = new System.Drawing.Point(593, 174);
            this.btnMMinus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(187, 55);
            this.btnMMinus.TabIndex = 23;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.memorize_Click);
            // 
            // btnMR
            // 
            this.btnMR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMR.Enabled = false;
            this.btnMR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMR.Location = new System.Drawing.Point(200, 174);
            this.btnMR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(187, 55);
            this.btnMR.TabIndex = 22;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMPlus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMPlus.FlatAppearance.BorderSize = 0;
            this.btnMPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPlus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMPlus.Location = new System.Drawing.Point(395, 174);
            this.btnMPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(187, 55);
            this.btnMPlus.TabIndex = 21;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.memorize_Click);
            // 
            // btnMC
            // 
            this.btnMC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMC.Enabled = false;
            this.btnMC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMC.Location = new System.Drawing.Point(3, 174);
            this.btnMC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(187, 55);
            this.btnMC.TabIndex = 20;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelResults.Controls.Add(this.btnMMinus);
            this.panelResults.Controls.Add(this.lblStandard);
            this.panelResults.Controls.Add(this.btnMR);
            this.panelResults.Controls.Add(this.tbSign);
            this.panelResults.Controls.Add(this.btnMPlus);
            this.panelResults.Controls.Add(this.tbResult);
            this.panelResults.Controls.Add(this.btnMC);
            this.panelResults.Controls.Add(this.tbInput);
            this.panelResults.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelResults.ForeColor = System.Drawing.SystemColors.Control;
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(784, 232);
            this.panelResults.TabIndex = 1;
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStandard.Location = new System.Drawing.Point(6, 9);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(125, 36);
            this.lblStandard.TabIndex = 2;
            this.lblStandard.Text = "Standard";
            // 
            // tbSign
            // 
            this.tbSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSign.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbSign.Enabled = false;
            this.tbSign.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tbSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbSign.Location = new System.Drawing.Point(752, 41);
            this.tbSign.Name = "tbSign";
            this.tbSign.ReadOnly = true;
            this.tbSign.Size = new System.Drawing.Size(19, 35);
            this.tbSign.TabIndex = 2;
            this.tbSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbResult.Enabled = false;
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbResult.Location = new System.Drawing.Point(12, 44);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(734, 32);
            this.tbResult.TabIndex = 1;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.tbInput.ForeColor = System.Drawing.SystemColors.Window;
            this.tbInput.Location = new System.Drawing.Point(12, 67);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(759, 67);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "0";
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 704);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panelButtons.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnDecimalP;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbSign;
        private System.Windows.Forms.Label lblStandard;
    }
}


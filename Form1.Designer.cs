namespace MathTools
{
    partial class MathTools
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LCMoutput = new System.Windows.Forms.TextBox();
            this.GCDoutput = new System.Windows.Forms.TextBox();
            this.GCDandLCMinput = new System.Windows.Forms.TextBox();
            this.GCDandLCMinvalidInput = new System.Windows.Forms.Label();
            this.LCMoutputLabel = new System.Windows.Forms.Label();
            this.GCDoutputLabel = new System.Windows.Forms.Label();
            this.calculateGCDandLCM = new System.Windows.Forms.Button();
            this.GCDandLCMinputExplaination = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.interestInvalidInput3 = new System.Windows.Forms.Label();
            this.interestInvalidInput2 = new System.Windows.Forms.Label();
            this.interestInvalidInput1 = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.interestOutput = new System.Windows.Forms.TextBox();
            this.yearsInput = new System.Windows.Forms.TextBox();
            this.rateInput = new System.Windows.Forms.TextBox();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.calculateInterestBtn = new System.Windows.Forms.Button();
            this.compoundInterestBtn = new System.Windows.Forms.RadioButton();
            this.normalInterestBtn = new System.Windows.Forms.RadioButton();
            this.percent = new System.Windows.Forms.Label();
            this.interestInputExplaination3 = new System.Windows.Forms.Label();
            this.interestInputExplaination2 = new System.Windows.Forms.Label();
            this.interestInputExplaination1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.startBase = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.indicator8 = new System.Windows.Forms.Panel();
            this.indicator7 = new System.Windows.Forms.Panel();
            this.indicator6 = new System.Windows.Forms.Panel();
            this.indicator5 = new System.Windows.Forms.Panel();
            this.indicator4 = new System.Windows.Forms.Panel();
            this.indicator3 = new System.Windows.Forms.Panel();
            this.indicator2 = new System.Windows.Forms.Panel();
            this.indicator1 = new System.Windows.Forms.Panel();
            this.option8 = new System.Windows.Forms.Button();
            this.option7 = new System.Windows.Forms.Button();
            this.option6 = new System.Windows.Forms.Button();
            this.option5 = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.contactBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.author = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.startBaseLabel = new System.Windows.Forms.Label();
            this.endBaseLabel = new System.Windows.Forms.Label();
            this.endBase = new System.Windows.Forms.ComboBox();
            this.convertLabel = new System.Windows.Forms.Label();
            this.conversionInput = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.conversionResultLabel = new System.Windows.Forms.Label();
            this.conversionOutput = new System.Windows.Forms.TextBox();
            this.conversionInvalidInput = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(184)))));
            this.mainPanel.Controls.Add(this.tabControl);
            this.mainPanel.Location = new System.Drawing.Point(279, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(903, 628);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(-4, -27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(912, 660);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(184)))));
            this.tabPage1.Controls.Add(this.LCMoutput);
            this.tabPage1.Controls.Add(this.GCDoutput);
            this.tabPage1.Controls.Add(this.GCDandLCMinput);
            this.tabPage1.Controls.Add(this.GCDandLCMinvalidInput);
            this.tabPage1.Controls.Add(this.LCMoutputLabel);
            this.tabPage1.Controls.Add(this.GCDoutputLabel);
            this.tabPage1.Controls.Add(this.calculateGCDandLCM);
            this.tabPage1.Controls.Add(this.GCDandLCMinputExplaination);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GCD-LCM";
            // 
            // LCMoutput
            // 
            this.LCMoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCMoutput.Location = new System.Drawing.Point(638, 471);
            this.LCMoutput.Name = "LCMoutput";
            this.LCMoutput.ReadOnly = true;
            this.LCMoutput.Size = new System.Drawing.Size(180, 34);
            this.LCMoutput.TabIndex = 7;
            this.LCMoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LCMoutput.Click += new System.EventHandler(this.LCMoutput_Select);
            this.LCMoutput.Enter += new System.EventHandler(this.LCMoutput_Select);
            // 
            // GCDoutput
            // 
            this.GCDoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDoutput.Location = new System.Drawing.Point(638, 342);
            this.GCDoutput.Name = "GCDoutput";
            this.GCDoutput.ReadOnly = true;
            this.GCDoutput.Size = new System.Drawing.Size(180, 34);
            this.GCDoutput.TabIndex = 6;
            this.GCDoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GCDoutput.Click += new System.EventHandler(this.GCDoutput_Select);
            this.GCDoutput.Enter += new System.EventHandler(this.GCDoutput_Select);
            // 
            // GCDandLCMinput
            // 
            this.GCDandLCMinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDandLCMinput.Location = new System.Drawing.Point(326, 180);
            this.GCDandLCMinput.Name = "GCDandLCMinput";
            this.GCDandLCMinput.Size = new System.Drawing.Size(250, 34);
            this.GCDandLCMinput.TabIndex = 0;
            this.GCDandLCMinput.Click += new System.EventHandler(this.GCDandLCMinput_Select);
            this.GCDandLCMinput.Enter += new System.EventHandler(this.GCDandLCMinput_Select);
            // 
            // GCDandLCMinvalidInput
            // 
            this.GCDandLCMinvalidInput.AutoSize = true;
            this.GCDandLCMinvalidInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDandLCMinvalidInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GCDandLCMinvalidInput.Location = new System.Drawing.Point(352, 230);
            this.GCDandLCMinvalidInput.Name = "GCDandLCMinvalidInput";
            this.GCDandLCMinvalidInput.Size = new System.Drawing.Size(197, 20);
            this.GCDandLCMinvalidInput.TabIndex = 5;
            this.GCDandLCMinvalidInput.Text = "Please enter a valid input";
            // 
            // LCMoutputLabel
            // 
            this.LCMoutputLabel.AutoSize = true;
            this.LCMoutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCMoutputLabel.Location = new System.Drawing.Point(556, 471);
            this.LCMoutputLabel.Name = "LCMoutputLabel";
            this.LCMoutputLabel.Size = new System.Drawing.Size(75, 29);
            this.LCMoutputLabel.TabIndex = 4;
            this.LCMoutputLabel.Text = "LCM: ";
            // 
            // GCDoutputLabel
            // 
            this.GCDoutputLabel.AutoSize = true;
            this.GCDoutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDoutputLabel.Location = new System.Drawing.Point(556, 342);
            this.GCDoutputLabel.Name = "GCDoutputLabel";
            this.GCDoutputLabel.Size = new System.Drawing.Size(77, 29);
            this.GCDoutputLabel.TabIndex = 3;
            this.GCDoutputLabel.Text = "GCD: ";
            // 
            // calculateGCDandLCM
            // 
            this.calculateGCDandLCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateGCDandLCM.Location = new System.Drawing.Point(187, 401);
            this.calculateGCDandLCM.Name = "calculateGCDandLCM";
            this.calculateGCDandLCM.Size = new System.Drawing.Size(200, 40);
            this.calculateGCDandLCM.TabIndex = 2;
            this.calculateGCDandLCM.Text = "Calculate";
            this.calculateGCDandLCM.UseVisualStyleBackColor = true;
            this.calculateGCDandLCM.Click += new System.EventHandler(this.calculateGCDandLCM_Click);
            // 
            // GCDandLCMinputExplaination
            // 
            this.GCDandLCMinputExplaination.AutoSize = true;
            this.GCDandLCMinputExplaination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDandLCMinputExplaination.Location = new System.Drawing.Point(182, 126);
            this.GCDandLCMinputExplaination.Name = "GCDandLCMinputExplaination";
            this.GCDandLCMinputExplaination.Size = new System.Drawing.Size(538, 32);
            this.GCDandLCMinputExplaination.TabIndex = 1;
            this.GCDandLCMinputExplaination.Text = "Enter your numbers separated by a space";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(184)))));
            this.tabPage2.Controls.Add(this.interestInvalidInput3);
            this.tabPage2.Controls.Add(this.interestInvalidInput2);
            this.tabPage2.Controls.Add(this.interestInvalidInput1);
            this.tabPage2.Controls.Add(this.totalOutput);
            this.tabPage2.Controls.Add(this.interestOutput);
            this.tabPage2.Controls.Add(this.yearsInput);
            this.tabPage2.Controls.Add(this.rateInput);
            this.tabPage2.Controls.Add(this.amountInput);
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(this.interestLabel);
            this.tabPage2.Controls.Add(this.calculateInterestBtn);
            this.tabPage2.Controls.Add(this.compoundInterestBtn);
            this.tabPage2.Controls.Add(this.normalInterestBtn);
            this.tabPage2.Controls.Add(this.percent);
            this.tabPage2.Controls.Add(this.interestInputExplaination3);
            this.tabPage2.Controls.Add(this.interestInputExplaination2);
            this.tabPage2.Controls.Add(this.interestInputExplaination1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interest";
            // 
            // interestInvalidInput3
            // 
            this.interestInvalidInput3.AutoSize = true;
            this.interestInvalidInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInvalidInput3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.interestInvalidInput3.Location = new System.Drawing.Point(301, 354);
            this.interestInvalidInput3.Name = "interestInvalidInput3";
            this.interestInvalidInput3.Size = new System.Drawing.Size(197, 20);
            this.interestInvalidInput3.TabIndex = 16;
            this.interestInvalidInput3.Text = "Please enter a valid input";
            // 
            // interestInvalidInput2
            // 
            this.interestInvalidInput2.AutoSize = true;
            this.interestInvalidInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInvalidInput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.interestInvalidInput2.Location = new System.Drawing.Point(301, 254);
            this.interestInvalidInput2.Name = "interestInvalidInput2";
            this.interestInvalidInput2.Size = new System.Drawing.Size(197, 20);
            this.interestInvalidInput2.TabIndex = 15;
            this.interestInvalidInput2.Text = "Please enter a valid input";
            // 
            // interestInvalidInput1
            // 
            this.interestInvalidInput1.AutoSize = true;
            this.interestInvalidInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInvalidInput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.interestInvalidInput1.Location = new System.Drawing.Point(301, 154);
            this.interestInvalidInput1.Name = "interestInvalidInput1";
            this.interestInvalidInput1.Size = new System.Drawing.Size(197, 20);
            this.interestInvalidInput1.TabIndex = 14;
            this.interestInvalidInput1.Text = "Please enter a valid input";
            // 
            // totalOutput
            // 
            this.totalOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(581, 520);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(240, 38);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalOutput.Click += new System.EventHandler(this.totalOutput_Select);
            this.totalOutput.Enter += new System.EventHandler(this.totalOutput_Select);
            // 
            // interestOutput
            // 
            this.interestOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.interestOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestOutput.Location = new System.Drawing.Point(581, 403);
            this.interestOutput.Name = "interestOutput";
            this.interestOutput.ReadOnly = true;
            this.interestOutput.Size = new System.Drawing.Size(240, 38);
            this.interestOutput.TabIndex = 11;
            this.interestOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.interestOutput.Click += new System.EventHandler(this.interestOutput_Select);
            this.interestOutput.Enter += new System.EventHandler(this.interestOutput_Select);
            // 
            // yearsInput
            // 
            this.yearsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsInput.Location = new System.Drawing.Point(310, 310);
            this.yearsInput.Name = "yearsInput";
            this.yearsInput.Size = new System.Drawing.Size(180, 38);
            this.yearsInput.TabIndex = 5;
            this.yearsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yearsInput.Click += new System.EventHandler(this.yearsInput_Select);
            this.yearsInput.Enter += new System.EventHandler(this.yearsInput_Select);
            // 
            // rateInput
            // 
            this.rateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateInput.Location = new System.Drawing.Point(310, 210);
            this.rateInput.Name = "rateInput";
            this.rateInput.Size = new System.Drawing.Size(140, 38);
            this.rateInput.TabIndex = 4;
            this.rateInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rateInput.Click += new System.EventHandler(this.rateInput_Select);
            this.rateInput.Enter += new System.EventHandler(this.rateInput_Select);
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.Location = new System.Drawing.Point(310, 110);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(180, 38);
            this.amountInput.TabIndex = 3;
            this.amountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountInput.Click += new System.EventHandler(this.amountInput_Select);
            this.amountInput.Enter += new System.EventHandler(this.amountInput_Select);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(528, 480);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(347, 32);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total amount with interest:";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabel.Location = new System.Drawing.Point(643, 356);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(116, 32);
            this.interestLabel.TabIndex = 10;
            this.interestLabel.Text = "Interest:";
            // 
            // calculateInterestBtn
            // 
            this.calculateInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateInterestBtn.Location = new System.Drawing.Point(170, 480);
            this.calculateInterestBtn.Name = "calculateInterestBtn";
            this.calculateInterestBtn.Size = new System.Drawing.Size(220, 46);
            this.calculateInterestBtn.TabIndex = 9;
            this.calculateInterestBtn.Text = "Calculate";
            this.calculateInterestBtn.UseVisualStyleBackColor = true;
            this.calculateInterestBtn.Click += new System.EventHandler(this.calculateInterestBtn_Click);
            // 
            // compoundInterestBtn
            // 
            this.compoundInterestBtn.AutoSize = true;
            this.compoundInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compoundInterestBtn.Location = new System.Drawing.Point(272, 410);
            this.compoundInterestBtn.Name = "compoundInterestBtn";
            this.compoundInterestBtn.Size = new System.Drawing.Size(199, 29);
            this.compoundInterestBtn.TabIndex = 8;
            this.compoundInterestBtn.TabStop = true;
            this.compoundInterestBtn.Text = "Compound Interest";
            this.compoundInterestBtn.UseVisualStyleBackColor = true;
            // 
            // normalInterestBtn
            // 
            this.normalInterestBtn.AutoSize = true;
            this.normalInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalInterestBtn.Location = new System.Drawing.Point(89, 410);
            this.normalInterestBtn.Name = "normalInterestBtn";
            this.normalInterestBtn.Size = new System.Drawing.Size(164, 29);
            this.normalInterestBtn.TabIndex = 7;
            this.normalInterestBtn.TabStop = true;
            this.normalInterestBtn.Text = "Normal Interest";
            this.normalInterestBtn.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(451, 210);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(39, 32);
            this.percent.TabIndex = 6;
            this.percent.Text = "%";
            // 
            // interestInputExplaination3
            // 
            this.interestInputExplaination3.AutoSize = true;
            this.interestInputExplaination3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInputExplaination3.Location = new System.Drawing.Point(70, 310);
            this.interestInputExplaination3.Name = "interestInputExplaination3";
            this.interestInputExplaination3.Size = new System.Drawing.Size(236, 32);
            this.interestInputExplaination3.TabIndex = 2;
            this.interestInputExplaination3.Text = "Number of years: ";
            // 
            // interestInputExplaination2
            // 
            this.interestInputExplaination2.AutoSize = true;
            this.interestInputExplaination2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInputExplaination2.Location = new System.Drawing.Point(70, 210);
            this.interestInputExplaination2.Name = "interestInputExplaination2";
            this.interestInputExplaination2.Size = new System.Drawing.Size(172, 32);
            this.interestInputExplaination2.TabIndex = 1;
            this.interestInputExplaination2.Text = "Interest rate:";
            // 
            // interestInputExplaination1
            // 
            this.interestInputExplaination1.AutoSize = true;
            this.interestInputExplaination1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestInputExplaination1.Location = new System.Drawing.Point(70, 110);
            this.interestInputExplaination1.Name = "interestInputExplaination1";
            this.interestInputExplaination1.Size = new System.Drawing.Size(192, 32);
            this.interestInputExplaination1.TabIndex = 0;
            this.interestInputExplaination1.Text = "Initial amount:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(184)))));
            this.tabPage3.Controls.Add(this.conversionInvalidInput);
            this.tabPage3.Controls.Add(this.conversionOutput);
            this.tabPage3.Controls.Add(this.conversionResultLabel);
            this.tabPage3.Controls.Add(this.convertBtn);
            this.tabPage3.Controls.Add(this.conversionInput);
            this.tabPage3.Controls.Add(this.convertLabel);
            this.tabPage3.Controls.Add(this.endBaseLabel);
            this.tabPage3.Controls.Add(this.endBase);
            this.tabPage3.Controls.Add(this.startBaseLabel);
            this.tabPage3.Controls.Add(this.startBase);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bin-Dec-Oct-Hex";
            // 
            // startBase
            // 
            this.startBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBase.FormattingEnabled = true;
            this.startBase.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.startBase.Location = new System.Drawing.Point(266, 246);
            this.startBase.Name = "startBase";
            this.startBase.Size = new System.Drawing.Size(166, 33);
            this.startBase.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(184)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(904, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pythagorean Triplets";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnPanel);
            this.leftPanel.Controls.Add(this.contactBtn);
            this.leftPanel.Controls.Add(this.titlePanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(320, 628);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // btnPanel
            // 
            this.btnPanel.AutoScroll = true;
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.btnPanel.Controls.Add(this.indicator8);
            this.btnPanel.Controls.Add(this.indicator7);
            this.btnPanel.Controls.Add(this.indicator6);
            this.btnPanel.Controls.Add(this.indicator5);
            this.btnPanel.Controls.Add(this.indicator4);
            this.btnPanel.Controls.Add(this.indicator3);
            this.btnPanel.Controls.Add(this.indicator2);
            this.btnPanel.Controls.Add(this.indicator1);
            this.btnPanel.Controls.Add(this.option8);
            this.btnPanel.Controls.Add(this.option7);
            this.btnPanel.Controls.Add(this.option6);
            this.btnPanel.Controls.Add(this.option5);
            this.btnPanel.Controls.Add(this.option4);
            this.btnPanel.Controls.Add(this.option3);
            this.btnPanel.Controls.Add(this.option2);
            this.btnPanel.Controls.Add(this.option1);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPanel.Location = new System.Drawing.Point(0, 116);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(320, 452);
            this.btnPanel.TabIndex = 5;
            // 
            // indicator8
            // 
            this.indicator8.Location = new System.Drawing.Point(0, 420);
            this.indicator8.Name = "indicator8";
            this.indicator8.Size = new System.Drawing.Size(23, 60);
            this.indicator8.TabIndex = 20;
            // 
            // indicator7
            // 
            this.indicator7.Location = new System.Drawing.Point(0, 360);
            this.indicator7.Name = "indicator7";
            this.indicator7.Size = new System.Drawing.Size(23, 60);
            this.indicator7.TabIndex = 19;
            // 
            // indicator6
            // 
            this.indicator6.Location = new System.Drawing.Point(0, 300);
            this.indicator6.Name = "indicator6";
            this.indicator6.Size = new System.Drawing.Size(23, 60);
            this.indicator6.TabIndex = 18;
            // 
            // indicator5
            // 
            this.indicator5.Location = new System.Drawing.Point(0, 240);
            this.indicator5.Name = "indicator5";
            this.indicator5.Size = new System.Drawing.Size(23, 60);
            this.indicator5.TabIndex = 17;
            // 
            // indicator4
            // 
            this.indicator4.Location = new System.Drawing.Point(0, 180);
            this.indicator4.Name = "indicator4";
            this.indicator4.Size = new System.Drawing.Size(23, 60);
            this.indicator4.TabIndex = 16;
            // 
            // indicator3
            // 
            this.indicator3.Location = new System.Drawing.Point(0, 120);
            this.indicator3.Name = "indicator3";
            this.indicator3.Size = new System.Drawing.Size(23, 60);
            this.indicator3.TabIndex = 15;
            // 
            // indicator2
            // 
            this.indicator2.Location = new System.Drawing.Point(0, 60);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(23, 60);
            this.indicator2.TabIndex = 14;
            // 
            // indicator1
            // 
            this.indicator1.Location = new System.Drawing.Point(0, 0);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(23, 60);
            this.indicator1.TabIndex = 13;
            // 
            // option8
            // 
            this.option8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option8.ForeColor = System.Drawing.Color.White;
            this.option8.Location = new System.Drawing.Point(23, 420);
            this.option8.Name = "option8";
            this.option8.Size = new System.Drawing.Size(274, 60);
            this.option8.TabIndex = 12;
            this.option8.Text = "Option 8";
            this.option8.UseVisualStyleBackColor = false;
            this.option8.Click += new System.EventHandler(this.option8_Click);
            // 
            // option7
            // 
            this.option7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option7.ForeColor = System.Drawing.Color.White;
            this.option7.Location = new System.Drawing.Point(23, 360);
            this.option7.Name = "option7";
            this.option7.Size = new System.Drawing.Size(274, 60);
            this.option7.TabIndex = 11;
            this.option7.Text = "Option 7";
            this.option7.UseVisualStyleBackColor = false;
            this.option7.Click += new System.EventHandler(this.option7_Click);
            // 
            // option6
            // 
            this.option6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option6.ForeColor = System.Drawing.Color.White;
            this.option6.Location = new System.Drawing.Point(23, 300);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(274, 60);
            this.option6.TabIndex = 10;
            this.option6.Text = "Option 6";
            this.option6.UseVisualStyleBackColor = false;
            this.option6.Click += new System.EventHandler(this.option6_Click);
            // 
            // option5
            // 
            this.option5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option5.ForeColor = System.Drawing.Color.White;
            this.option5.Location = new System.Drawing.Point(23, 240);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(274, 60);
            this.option5.TabIndex = 9;
            this.option5.Text = "Option 5";
            this.option5.UseVisualStyleBackColor = false;
            this.option5.Click += new System.EventHandler(this.option5_Click);
            // 
            // option4
            // 
            this.option4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option4.ForeColor = System.Drawing.Color.White;
            this.option4.Location = new System.Drawing.Point(23, 180);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(274, 60);
            this.option4.TabIndex = 8;
            this.option4.Text = "Pythagorean Triplets Generator";
            this.option4.UseVisualStyleBackColor = false;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option3.ForeColor = System.Drawing.Color.White;
            this.option3.Location = new System.Drawing.Point(23, 120);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(274, 60);
            this.option3.TabIndex = 7;
            this.option3.Text = "Bin-Dec-Oct-Hex Converter";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(23, 60);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(274, 60);
            this.option2.TabIndex = 6;
            this.option2.Text = "Interest Calculator";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(23, 0);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(274, 60);
            this.option1.TabIndex = 5;
            this.option1.Text = "GCD and LCM Calculator";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // contactBtn
            // 
            this.contactBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.contactBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contactBtn.ForeColor = System.Drawing.Color.White;
            this.contactBtn.Location = new System.Drawing.Point(0, 568);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(320, 60);
            this.contactBtn.TabIndex = 4;
            this.contactBtn.Text = "Contact us";
            this.contactBtn.UseVisualStyleBackColor = false;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(106)))));
            this.titlePanel.Controls.Add(this.author);
            this.titlePanel.Controls.Add(this.title);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(320, 116);
            this.titlePanel.TabIndex = 3;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.author.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.author.Location = new System.Drawing.Point(128, 67);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(63, 22);
            this.author.TabIndex = 1;
            this.author.Text = "by Jack";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(60, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 30);
            this.title.TabIndex = 0;
            this.title.Text = "MathTools";
            // 
            // startBaseLabel
            // 
            this.startBaseLabel.AutoSize = true;
            this.startBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBaseLabel.Location = new System.Drawing.Point(166, 246);
            this.startBaseLabel.Name = "startBaseLabel";
            this.startBaseLabel.Size = new System.Drawing.Size(76, 29);
            this.startBaseLabel.TabIndex = 2;
            this.startBaseLabel.Text = "From:";
            // 
            // endBaseLabel
            // 
            this.endBaseLabel.AutoSize = true;
            this.endBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBaseLabel.Location = new System.Drawing.Point(516, 246);
            this.endBaseLabel.Name = "endBaseLabel";
            this.endBaseLabel.Size = new System.Drawing.Size(49, 29);
            this.endBaseLabel.TabIndex = 4;
            this.endBaseLabel.Text = "To:";
            // 
            // endBase
            // 
            this.endBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBase.FormattingEnabled = true;
            this.endBase.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.endBase.Location = new System.Drawing.Point(615, 246);
            this.endBase.Name = "endBase";
            this.endBase.Size = new System.Drawing.Size(166, 33);
            this.endBase.TabIndex = 3;
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertLabel.Location = new System.Drawing.Point(414, 71);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(113, 32);
            this.convertLabel.TabIndex = 5;
            this.convertLabel.Text = "Convert";
            // 
            // conversionInput
            // 
            this.conversionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionInput.Location = new System.Drawing.Point(373, 149);
            this.conversionInput.Name = "conversionInput";
            this.conversionInput.Size = new System.Drawing.Size(200, 34);
            this.conversionInput.TabIndex = 6;
            this.conversionInput.Click += new System.EventHandler(this.conversionInput_Select);
            this.conversionInput.Enter += new System.EventHandler(this.conversionInput_Select);
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(373, 343);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(200, 40);
            this.convertBtn.TabIndex = 7;
            this.convertBtn.Text = "Calculate";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // conversionResultLabel
            // 
            this.conversionResultLabel.AutoSize = true;
            this.conversionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionResultLabel.Location = new System.Drawing.Point(419, 440);
            this.conversionResultLabel.Name = "conversionResultLabel";
            this.conversionResultLabel.Size = new System.Drawing.Size(103, 32);
            this.conversionResultLabel.TabIndex = 8;
            this.conversionResultLabel.Text = "Result:";
            // 
            // conversionOutput
            // 
            this.conversionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionOutput.Location = new System.Drawing.Point(373, 502);
            this.conversionOutput.Name = "conversionOutput";
            this.conversionOutput.ReadOnly = true;
            this.conversionOutput.Size = new System.Drawing.Size(200, 34);
            this.conversionOutput.TabIndex = 9;
            this.conversionOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conversionOutput.Click += new System.EventHandler(this.conversionOutput_Select);
            this.conversionOutput.Enter += new System.EventHandler(this.conversionOutput_Select);
            // 
            // conversionInvalidInput
            // 
            this.conversionInvalidInput.AutoSize = true;
            this.conversionInvalidInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionInvalidInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.conversionInvalidInput.Location = new System.Drawing.Point(362, 195);
            this.conversionInvalidInput.Name = "conversionInvalidInput";
            this.conversionInvalidInput.Size = new System.Drawing.Size(197, 20);
            this.conversionInvalidInput.TabIndex = 16;
            this.conversionInvalidInput.Text = "Please enter a valid input";
            // 
            // MathTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MathTools";
            this.Text = "MathTools";
            this.Load += new System.EventHandler(this.MathTools_Load);
            this.mainPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button option6;
        private System.Windows.Forms.Button option5;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option7;
        private System.Windows.Forms.Button option8;
        private System.Windows.Forms.Panel indicator1;
        private System.Windows.Forms.Panel indicator3;
        private System.Windows.Forms.Panel indicator2;
        private System.Windows.Forms.Panel indicator8;
        private System.Windows.Forms.Panel indicator7;
        private System.Windows.Forms.Panel indicator6;
        private System.Windows.Forms.Panel indicator5;
        private System.Windows.Forms.Panel indicator4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox LCMoutput;
        private System.Windows.Forms.TextBox GCDoutput;
        private System.Windows.Forms.TextBox GCDandLCMinput;
        private System.Windows.Forms.Label GCDandLCMinvalidInput;
        private System.Windows.Forms.Label LCMoutputLabel;
        private System.Windows.Forms.Label GCDoutputLabel;
        private System.Windows.Forms.Button calculateGCDandLCM;
        private System.Windows.Forms.Label GCDandLCMinputExplaination;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label interestInvalidInput3;
        private System.Windows.Forms.Label interestInvalidInput2;
        private System.Windows.Forms.Label interestInvalidInput1;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.TextBox interestOutput;
        private System.Windows.Forms.TextBox yearsInput;
        private System.Windows.Forms.TextBox rateInput;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Button calculateInterestBtn;
        private System.Windows.Forms.RadioButton compoundInterestBtn;
        private System.Windows.Forms.RadioButton normalInterestBtn;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label interestInputExplaination3;
        private System.Windows.Forms.Label interestInputExplaination2;
        private System.Windows.Forms.Label interestInputExplaination1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox startBase;
        private System.Windows.Forms.Label endBaseLabel;
        private System.Windows.Forms.ComboBox endBase;
        private System.Windows.Forms.Label startBaseLabel;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox conversionInput;
        private System.Windows.Forms.TextBox conversionOutput;
        private System.Windows.Forms.Label conversionResultLabel;
        private System.Windows.Forms.Label conversionInvalidInput;
    }
}


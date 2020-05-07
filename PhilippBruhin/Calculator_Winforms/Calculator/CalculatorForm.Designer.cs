namespace Calculator
{
    partial class CalculatorForm
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
            this.numericUpDownInput1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInput2 = new System.Windows.Forms.NumericUpDown();
            this.labelEqual = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownInput1
            // 
            this.numericUpDownInput1.DecimalPlaces = 2;
            this.numericUpDownInput1.Location = new System.Drawing.Point(12, 39);
            this.numericUpDownInput1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownInput1.Name = "numericUpDownInput1";
            this.numericUpDownInput1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInput1.TabIndex = 0;
            this.numericUpDownInput1.ThousandsSeparator = true;
            // 
            // numericUpDownInput2
            // 
            this.numericUpDownInput2.DecimalPlaces = 2;
            this.numericUpDownInput2.Location = new System.Drawing.Point(188, 39);
            this.numericUpDownInput2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownInput2.Name = "numericUpDownInput2";
            this.numericUpDownInput2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInput2.TabIndex = 2;
            this.numericUpDownInput2.ThousandsSeparator = true;
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Location = new System.Drawing.Point(311, 43);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(13, 13);
            this.labelEqual.TabIndex = 4;
            this.labelEqual.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(325, 43);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(13, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "0";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperation.Location = new System.Drawing.Point(138, 39);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(44, 21);
            this.comboBoxOperation.TabIndex = 1;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(169, 83);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 134);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.numericUpDownInput2);
            this.Controls.Add(this.numericUpDownInput1);
            this.Name = "CalculatorForm";
            this.Text = "Pamasol Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownInput1;
        private System.Windows.Forms.NumericUpDown numericUpDownInput2;
        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Button buttonCalculate;
    }
}


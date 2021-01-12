
namespace Calculator_Winforms
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEqual = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownInput1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInput2 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Location = new System.Drawing.Point(482, 169);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(18, 20);
            this.labelEqual.TabIndex = 0;
            this.labelEqual.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(506, 169);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(282, 226);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(101, 31);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numericUpDownInput1
            // 
            this.numericUpDownInput1.DecimalPlaces = 2;
            this.numericUpDownInput1.Location = new System.Drawing.Point(83, 167);
            this.numericUpDownInput1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownInput1.Name = "numericUpDownInput1";
            this.numericUpDownInput1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownInput1.TabIndex = 3;
            // 
            // numericUpDownInput2
            // 
            this.numericUpDownInput2.DecimalPlaces = 2;
            this.numericUpDownInput2.Location = new System.Drawing.Point(340, 167);
            this.numericUpDownInput2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownInput2.Name = "numericUpDownInput2";
            this.numericUpDownInput2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownInput2.TabIndex = 4;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperation.Location = new System.Drawing.Point(213, 166);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(121, 28);
            this.comboBoxOperation.TabIndex = 5;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.numericUpDownInput2);
            this.Controls.Add(this.numericUpDownInput1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEqual);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownInput1;
        private System.Windows.Forms.NumericUpDown numericUpDownInput2;
        private System.Windows.Forms.ComboBox comboBoxOperation;
    }
}


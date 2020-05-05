namespace Taschenrechner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Subtraktion = new System.Windows.Forms.RadioButton();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.Multiplikation = new System.Windows.Forms.RadioButton();
            this.firstnum = new System.Windows.Forms.TextBox();
            this.secondnum = new System.Windows.Forms.TextBox();
            this.opperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.result = new System.Windows.Forms.Label();
            this.dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subtraktion
            // 
            this.Subtraktion.AutoSize = true;
            this.Subtraktion.Location = new System.Drawing.Point(231, 128);
            this.Subtraktion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subtraktion.Name = "Subtraktion";
            this.Subtraktion.Size = new System.Drawing.Size(79, 17);
            this.Subtraktion.TabIndex = 4;
            this.Subtraktion.TabStop = true;
            this.Subtraktion.Text = "Subtraktion";
            this.Subtraktion.UseVisualStyleBackColor = true;
            this.Subtraktion.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(231, 107);
            this.Addition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(63, 17);
            this.Addition.TabIndex = 5;
            this.Addition.TabStop = true;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.ForeColor = System.Drawing.Color.Black;
            this.Division.Location = new System.Drawing.Point(231, 170);
            this.Division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(62, 17);
            this.Division.TabIndex = 7;
            this.Division.TabStop = true;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.CheckedChanged += new System.EventHandler(this.Division_CheckedChanged);
            // 
            // Multiplikation
            // 
            this.Multiplikation.AutoSize = true;
            this.Multiplikation.Location = new System.Drawing.Point(231, 149);
            this.Multiplikation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Multiplikation.Name = "Multiplikation";
            this.Multiplikation.Size = new System.Drawing.Size(86, 17);
            this.Multiplikation.TabIndex = 8;
            this.Multiplikation.TabStop = true;
            this.Multiplikation.Text = "Multiplikation";
            this.Multiplikation.UseVisualStyleBackColor = true;
            this.Multiplikation.CheckedChanged += new System.EventHandler(this.Multiplikation_CheckedChanged);
            // 
            // firstnum
            // 
            this.firstnum.Location = new System.Drawing.Point(123, 71);
            this.firstnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstnum.Name = "firstnum";
            this.firstnum.Size = new System.Drawing.Size(76, 20);
            this.firstnum.TabIndex = 9;
            this.firstnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondnum
            // 
            this.secondnum.Location = new System.Drawing.Point(231, 71);
            this.secondnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondnum.Name = "secondnum";
            this.secondnum.Size = new System.Drawing.Size(76, 20);
            this.secondnum.TabIndex = 10;
            // 
            // opperator
            // 
            this.opperator.AutoSize = true;
            this.opperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opperator.Location = new System.Drawing.Point(205, 69);
            this.opperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opperator.Name = "opperator";
            this.opperator.Size = new System.Drawing.Size(0, 24);
            this.opperator.TabIndex = 11;
            this.opperator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Berechnung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(331, 76);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 15;
            this.result.Click += new System.EventHandler(this.label4_Click);
            // 
            // dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem
            // 
            this.dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem.Name = "dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem";
            this.dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem.Text = "Das ist ein Taschenrechner made by Jonas Bisig";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opperator);
            this.Controls.Add(this.secondnum);
            this.Controls.Add(this.firstnum);
            this.Controls.Add(this.Multiplikation);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtraktion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Subtraktion;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Division;
        private System.Windows.Forms.RadioButton Multiplikation;
        private System.Windows.Forms.TextBox firstnum;
        private System.Windows.Forms.TextBox secondnum;
        private System.Windows.Forms.Label opperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ToolStripMenuItem dasIstEinTaschenrechnerMadeByJonasBisigToolStripMenuItem;
    }
}


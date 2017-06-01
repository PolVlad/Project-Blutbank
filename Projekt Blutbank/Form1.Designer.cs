namespace Projekt_Blutbank
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
            this.buttonEinloggen = new System.Windows.Forms.Button();
            this.comboBoxAuswahl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEinloggen
            // 
            this.buttonEinloggen.Location = new System.Drawing.Point(126, 235);
            this.buttonEinloggen.Name = "buttonEinloggen";
            this.buttonEinloggen.Size = new System.Drawing.Size(121, 23);
            this.buttonEinloggen.TabIndex = 0;
            this.buttonEinloggen.Text = "Bestätigen";
            this.buttonEinloggen.UseVisualStyleBackColor = true;
            this.buttonEinloggen.Click += new System.EventHandler(this.buttonEinloggen_Click);
            // 
            // comboBoxAuswahl
            // 
            this.comboBoxAuswahl.FormattingEnabled = true;
            this.comboBoxAuswahl.Items.AddRange(new object[] {
            "Patient",
            "Spender"});
            this.comboBoxAuswahl.Location = new System.Drawing.Point(126, 184);
            this.comboBoxAuswahl.Name = "comboBoxAuswahl";
            this.comboBoxAuswahl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuswahl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 329);
            this.Controls.Add(this.comboBoxAuswahl);
            this.Controls.Add(this.buttonEinloggen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEinloggen;
        private System.Windows.Forms.ComboBox comboBoxAuswahl;
    }
}


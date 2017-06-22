namespace Projekt_Blutbank
{
    partial class SpenderHinzufügen
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
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonBestätigen = new System.Windows.Forms.Button();
            this.textBoxLetzteSpende = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBluttgruppe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSpenderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(172, 238);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(102, 23);
            this.buttonAbbrechen.TabIndex = 23;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            // 
            // buttonBestätigen
            // 
            this.buttonBestätigen.Location = new System.Drawing.Point(29, 238);
            this.buttonBestätigen.Name = "buttonBestätigen";
            this.buttonBestätigen.Size = new System.Drawing.Size(102, 23);
            this.buttonBestätigen.TabIndex = 22;
            this.buttonBestätigen.Text = "Bestätigen";
            this.buttonBestätigen.UseVisualStyleBackColor = true;
            // 
            // textBoxLetzteSpende
            // 
            this.textBoxLetzteSpende.Location = new System.Drawing.Point(115, 184);
            this.textBoxLetzteSpende.Name = "textBoxLetzteSpende";
            this.textBoxLetzteSpende.Size = new System.Drawing.Size(159, 20);
            this.textBoxLetzteSpende.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Letzte Spende";
            // 
            // textBoxBluttgruppe
            // 
            this.textBoxBluttgruppe.Location = new System.Drawing.Point(115, 145);
            this.textBoxBluttgruppe.Name = "textBoxBluttgruppe";
            this.textBoxBluttgruppe.Size = new System.Drawing.Size(159, 20);
            this.textBoxBluttgruppe.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bluttgruppe";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(115, 104);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(159, 20);
            this.textBoxVorname.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vorname";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(115, 64);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(159, 20);
            this.textBoxNachname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nachname";
            // 
            // textBoxSpenderId
            // 
            this.textBoxSpenderId.Location = new System.Drawing.Point(115, 23);
            this.textBoxSpenderId.Name = "textBoxSpenderId";
            this.textBoxSpenderId.Size = new System.Drawing.Size(159, 20);
            this.textBoxSpenderId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SpenderID";
            // 
            // SpenderHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 288);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonBestätigen);
            this.Controls.Add(this.textBoxLetzteSpende);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBluttgruppe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSpenderId);
            this.Controls.Add(this.label1);
            this.Name = "SpenderHinzufügen";
            this.Text = "SpenderHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonBestätigen;
        private System.Windows.Forms.TextBox textBoxLetzteSpende;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBluttgruppe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSpenderId;
        private System.Windows.Forms.Label label1;
    }
}
namespace Projekt_Blutbank
{
    partial class FormPatient
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
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.buttonPatientHinzu = new System.Windows.Forms.Button();
            this.buttonPatientAendern = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.buttonPatientLoeschen = new System.Windows.Forms.Button();
            this.textBoxAnzeigeAuswahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBlutbank = new System.Windows.Forms.Button();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEntnehmen = new System.Windows.Forms.Button();
            this.labelMeldung = new System.Windows.Forms.Label();
            this.textBoxAendernLoeschen = new System.Windows.Forms.TextBox();
            this.dataGridViewBlutbank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlutbank)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(299, 12);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.Size = new System.Drawing.Size(411, 265);
            this.dataGridViewPatient.TabIndex = 0;
            // 
            // buttonPatientHinzu
            // 
            this.buttonPatientHinzu.Location = new System.Drawing.Point(88, 12);
            this.buttonPatientHinzu.Name = "buttonPatientHinzu";
            this.buttonPatientHinzu.Size = new System.Drawing.Size(134, 23);
            this.buttonPatientHinzu.TabIndex = 1;
            this.buttonPatientHinzu.Text = "Patient hinzufügen";
            this.buttonPatientHinzu.UseVisualStyleBackColor = true;
            this.buttonPatientHinzu.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPatientAendern
            // 
            this.buttonPatientAendern.Location = new System.Drawing.Point(12, 64);
            this.buttonPatientAendern.Name = "buttonPatientAendern";
            this.buttonPatientAendern.Size = new System.Drawing.Size(134, 23);
            this.buttonPatientAendern.TabIndex = 3;
            this.buttonPatientAendern.Text = "Patient ändern";
            this.buttonPatientAendern.UseVisualStyleBackColor = true;
            this.buttonPatientAendern.Click += new System.EventHandler(this.buttonPatientAendern_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Location = new System.Drawing.Point(12, 171);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(134, 23);
            this.buttonAnzeigen.TabIndex = 5;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // buttonPatientLoeschen
            // 
            this.buttonPatientLoeschen.Location = new System.Drawing.Point(12, 93);
            this.buttonPatientLoeschen.Name = "buttonPatientLoeschen";
            this.buttonPatientLoeschen.Size = new System.Drawing.Size(134, 23);
            this.buttonPatientLoeschen.TabIndex = 4;
            this.buttonPatientLoeschen.Text = "Patient löschen";
            this.buttonPatientLoeschen.UseVisualStyleBackColor = true;
            this.buttonPatientLoeschen.Click += new System.EventHandler(this.buttonPatientLoeschen_Click);
            // 
            // textBoxAnzeigeAuswahl
            // 
            this.textBoxAnzeigeAuswahl.Location = new System.Drawing.Point(171, 173);
            this.textBoxAnzeigeAuswahl.Name = "textBoxAnzeigeAuswahl";
            this.textBoxAnzeigeAuswahl.Size = new System.Drawing.Size(106, 20);
            this.textBoxAnzeigeAuswahl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nach Blutgruppe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBlutbank);
            this.groupBox1.Controls.Add(this.textBoxPatientID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonEntnehmen);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 125);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blutentnahme aus dem Lager";
            // 
            // buttonBlutbank
            // 
            this.buttonBlutbank.Location = new System.Drawing.Point(183, 62);
            this.buttonBlutbank.Name = "buttonBlutbank";
            this.buttonBlutbank.Size = new System.Drawing.Size(76, 23);
            this.buttonBlutbank.TabIndex = 21;
            this.buttonBlutbank.Text = "Blutbank";
            this.buttonBlutbank.UseVisualStyleBackColor = true;
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(76, 22);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Patient ID";
            // 
            // buttonEntnehmen
            // 
            this.buttonEntnehmen.Location = new System.Drawing.Point(19, 62);
            this.buttonEntnehmen.Name = "buttonEntnehmen";
            this.buttonEntnehmen.Size = new System.Drawing.Size(128, 23);
            this.buttonEntnehmen.TabIndex = 17;
            this.buttonEntnehmen.Text = "Entnehmen";
            this.buttonEntnehmen.UseVisualStyleBackColor = true;
            // 
            // labelMeldung
            // 
            this.labelMeldung.AutoSize = true;
            this.labelMeldung.Location = new System.Drawing.Point(9, 367);
            this.labelMeldung.Name = "labelMeldung";
            this.labelMeldung.Size = new System.Drawing.Size(48, 13);
            this.labelMeldung.TabIndex = 21;
            this.labelMeldung.Text = "Meldung";
            // 
            // textBoxAendernLoeschen
            // 
            this.textBoxAendernLoeschen.Location = new System.Drawing.Point(152, 79);
            this.textBoxAendernLoeschen.Name = "textBoxAendernLoeschen";
            this.textBoxAendernLoeschen.Size = new System.Drawing.Size(100, 20);
            this.textBoxAendernLoeschen.TabIndex = 22;
            // 
            // dataGridViewBlutbank
            // 
            this.dataGridViewBlutbank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlutbank.Location = new System.Drawing.Point(299, 283);
            this.dataGridViewBlutbank.Name = "dataGridViewBlutbank";
            this.dataGridViewBlutbank.Size = new System.Drawing.Size(411, 89);
            this.dataGridViewBlutbank.TabIndex = 23;
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 384);
            this.Controls.Add(this.dataGridViewBlutbank);
            this.Controls.Add(this.textBoxAendernLoeschen);
            this.Controls.Add(this.labelMeldung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnzeigeAuswahl);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.buttonPatientLoeschen);
            this.Controls.Add(this.buttonPatientAendern);
            this.Controls.Add(this.buttonPatientHinzu);
            this.Controls.Add(this.dataGridViewPatient);
            this.Name = "FormPatient";
            this.Text = "FormPatient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPatient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlutbank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Button buttonPatientHinzu;
        private System.Windows.Forms.Button buttonPatientAendern;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.Button buttonPatientLoeschen;
        private System.Windows.Forms.TextBox textBoxAnzeigeAuswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBlutbank;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEntnehmen;
        private System.Windows.Forms.Label labelMeldung;
        private System.Windows.Forms.TextBox textBoxAendernLoeschen;
        private System.Windows.Forms.DataGridView dataGridViewBlutbank;
    }
}
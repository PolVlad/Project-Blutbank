namespace Projekt_Blutbank
{
    partial class FormSpender
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
            this.buttonEntnehmen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnezigenAuswahl = new System.Windows.Forms.TextBox();
            this.buttonSpenderAnzeigen = new System.Windows.Forms.Button();
            this.buttonSpenderLoeschen = new System.Windows.Forms.Button();
            this.buttonSpenderAendern = new System.Windows.Forms.Button();
            this.buttonSpenderHinzu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMeldung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpenderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEntnehmen
            // 
            this.buttonEntnehmen.Location = new System.Drawing.Point(19, 71);
            this.buttonEntnehmen.Name = "buttonEntnehmen";
            this.buttonEntnehmen.Size = new System.Drawing.Size(128, 23);
            this.buttonEntnehmen.TabIndex = 17;
            this.buttonEntnehmen.Text = "Entnehmen";
            this.buttonEntnehmen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nach Blutgruppe:";
            // 
            // textBoxAnezigenAuswahl
            // 
            this.textBoxAnezigenAuswahl.Location = new System.Drawing.Point(167, 153);
            this.textBoxAnezigenAuswahl.Name = "textBoxAnezigenAuswahl";
            this.textBoxAnezigenAuswahl.Size = new System.Drawing.Size(106, 20);
            this.textBoxAnezigenAuswahl.TabIndex = 15;
            // 
            // buttonSpenderAnzeigen
            // 
            this.buttonSpenderAnzeigen.Location = new System.Drawing.Point(8, 151);
            this.buttonSpenderAnzeigen.Name = "buttonSpenderAnzeigen";
            this.buttonSpenderAnzeigen.Size = new System.Drawing.Size(134, 23);
            this.buttonSpenderAnzeigen.TabIndex = 14;
            this.buttonSpenderAnzeigen.Text = "Anzeigen";
            this.buttonSpenderAnzeigen.UseVisualStyleBackColor = true;
            // 
            // buttonSpenderLoeschen
            // 
            this.buttonSpenderLoeschen.Location = new System.Drawing.Point(8, 93);
            this.buttonSpenderLoeschen.Name = "buttonSpenderLoeschen";
            this.buttonSpenderLoeschen.Size = new System.Drawing.Size(134, 23);
            this.buttonSpenderLoeschen.TabIndex = 13;
            this.buttonSpenderLoeschen.Text = "Spender löschen";
            this.buttonSpenderLoeschen.UseVisualStyleBackColor = true;
            // 
            // buttonSpenderAendern
            // 
            this.buttonSpenderAendern.Location = new System.Drawing.Point(8, 54);
            this.buttonSpenderAendern.Name = "buttonSpenderAendern";
            this.buttonSpenderAendern.Size = new System.Drawing.Size(134, 23);
            this.buttonSpenderAendern.TabIndex = 12;
            this.buttonSpenderAendern.Text = "Spender ändern";
            this.buttonSpenderAendern.UseVisualStyleBackColor = true;
            // 
            // buttonSpenderHinzu
            // 
            this.buttonSpenderHinzu.Location = new System.Drawing.Point(8, 12);
            this.buttonSpenderHinzu.Name = "buttonSpenderHinzu";
            this.buttonSpenderHinzu.Size = new System.Drawing.Size(134, 23);
            this.buttonSpenderHinzu.TabIndex = 10;
            this.buttonSpenderHinzu.Text = "Spender hinzufügen";
            this.buttonSpenderHinzu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 352);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSpenderID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonEntnehmen);
            this.groupBox1.Location = new System.Drawing.Point(8, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 125);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blutentnahme";
            // 
            // labelMeldung
            // 
            this.labelMeldung.AutoSize = true;
            this.labelMeldung.Location = new System.Drawing.Point(5, 371);
            this.labelMeldung.Name = "labelMeldung";
            this.labelMeldung.Size = new System.Drawing.Size(48, 13);
            this.labelMeldung.TabIndex = 19;
            this.labelMeldung.Text = "Meldung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Spender ID:";
            // 
            // textBoxSpenderID
            // 
            this.textBoxSpenderID.Location = new System.Drawing.Point(76, 29);
            this.textBoxSpenderID.Name = "textBoxSpenderID";
            this.textBoxSpenderID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpenderID.TabIndex = 20;
            // 
            // FormSpender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.labelMeldung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnezigenAuswahl);
            this.Controls.Add(this.buttonSpenderAnzeigen);
            this.Controls.Add(this.buttonSpenderLoeschen);
            this.Controls.Add(this.buttonSpenderAendern);
            this.Controls.Add(this.buttonSpenderHinzu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSpender";
            this.Text = "FormSpender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSpender_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntnehmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnezigenAuswahl;
        private System.Windows.Forms.Button buttonSpenderAnzeigen;
        private System.Windows.Forms.Button buttonSpenderLoeschen;
        private System.Windows.Forms.Button buttonSpenderAendern;
        private System.Windows.Forms.Button buttonSpenderHinzu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSpenderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMeldung;
    }
}
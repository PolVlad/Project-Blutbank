﻿namespace Projekt_Blutbank
{
    partial class PatientÄndern
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
            this.textBoxWohnort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBlutgruppe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(158, 228);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(102, 23);
            this.buttonAbbrechen.TabIndex = 23;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click_1);
            // 
            // buttonBestätigen
            // 
            this.buttonBestätigen.Location = new System.Drawing.Point(15, 228);
            this.buttonBestätigen.Name = "buttonBestätigen";
            this.buttonBestätigen.Size = new System.Drawing.Size(102, 23);
            this.buttonBestätigen.TabIndex = 22;
            this.buttonBestätigen.Text = "Bestätigen";
            this.buttonBestätigen.UseVisualStyleBackColor = true;
            this.buttonBestätigen.Click += new System.EventHandler(this.buttonBestätigen_Click_1);
            // 
            // textBoxWohnort
            // 
            this.textBoxWohnort.Location = new System.Drawing.Point(101, 174);
            this.textBoxWohnort.Name = "textBoxWohnort";
            this.textBoxWohnort.Size = new System.Drawing.Size(159, 20);
            this.textBoxWohnort.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Wohnort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bluttgruppe";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(101, 94);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(159, 20);
            this.textBoxVorname.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vorname";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(101, 54);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(159, 20);
            this.textBoxNachname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nachname";
            // 
            // textBoxPatientId
            // 
            this.textBoxPatientId.Enabled = false;
            this.textBoxPatientId.Location = new System.Drawing.Point(101, 13);
            this.textBoxPatientId.Name = "textBoxPatientId";
            this.textBoxPatientId.Size = new System.Drawing.Size(159, 20);
            this.textBoxPatientId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "PatientID";
            // 
            // comboBoxBlutgruppe
            // 
            this.comboBoxBlutgruppe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlutgruppe.FormattingEnabled = true;
            this.comboBoxBlutgruppe.Items.AddRange(new object[] {
            "0",
            "A",
            "AB",
            "B"});
            this.comboBoxBlutgruppe.Location = new System.Drawing.Point(101, 135);
            this.comboBoxBlutgruppe.Name = "comboBoxBlutgruppe";
            this.comboBoxBlutgruppe.Size = new System.Drawing.Size(159, 21);
            this.comboBoxBlutgruppe.TabIndex = 24;
            // 
            // PatientÄndern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 287);
            this.Controls.Add(this.comboBoxBlutgruppe);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonBestätigen);
            this.Controls.Add(this.textBoxWohnort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatientId);
            this.Controls.Add(this.label1);
            this.Name = "PatientÄndern";
            this.Text = "PatientÄndern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonBestätigen;
        private System.Windows.Forms.TextBox textBoxWohnort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBlutgruppe;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Blutbank
{
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHinzufügen patHinz = new PatientHinzufügen();

            patHinz.ShowDialog();

        }

        private void close()
        {
            
                Form1 frm = new Form1();
                frm.Visible = true;

               this.Visible = false;
            
        }
        
    

        private void FormPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }

        private void buttonPatientAendern_Click(object sender, EventArgs e)
        {
            PatientÄndern patAend = new PatientÄndern();

            patAend.ShowDialog();

        }

        private void loeschen()
        {

        }

        private void buttonPatientLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten sie wirklich löschen ?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loeschen();
            }
            else
            {
                
            }
        }

        private void anzeigen()
        {

        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            anzeigen();
        }

       
    }
}

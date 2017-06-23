using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projekt_Blutbank
{
    public partial class FormPatient : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adpPatient;
        OleDbDataAdapter adpBlutbank;
        DataSet dsPatient;
        DataSet dsBlutbank;


        public FormPatient()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            con = new OleDbConnection(Properties.Settings.Default.DBcon);
            adpPatient = new OleDbDataAdapter("select * from tPatient", con);
            adpBlutbank = new OleDbDataAdapter("select * from tBlutbank", con);
            dsPatient = new DataSet();
            dsBlutbank = new DataSet();

            anzeigen();
            //adpBestellung = new OleDbDataAdapter("select * from tBestellung", con);
            //CreateCmdObjectKunde();
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
            dsPatient.Clear();
            adpPatient.Fill(dsPatient, "Patient");
            dataGridViewPatient.DataSource = dsPatient.Tables["Patient"];

            dsBlutbank.Clear();
            adpBlutbank.Fill(dsBlutbank, "Blutbank");
            dataGridViewBlutbank.DataSource = dsBlutbank.Tables["Blutbank"];


        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            //nach blutgruppe suchen
        }

       
    }
}

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
        OleDbCommand cmd;
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
            con.Open();

            anzeigen();
            //adpBestellung = new OleDbDataAdapter("select * from tBestellung", con);
            //CreateCmdObjectKunde();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PatientHinzufügen patHinz = new PatientHinzufügen(con);

            patHinz.ShowDialog();

         
           /* if(patHinz.FormClosed)
            {
                anzeigen();
            }*/

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
            int id = Convert.ToInt32(textBoxAendernLoeschen.Text);
            PatientÄndern patAend = new PatientÄndern(con, id);
            cmd = con.CreateCommand();

            cmd.CommandText = "select Nachname from tPatient where PatientID = " + id;
            String nachname = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Vorname from tPatient where PatientID = " + id;
            String vorname = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Bluttgruppe from tPatient where PatientID = " + id;
            String blutgruppe = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Wohnort from tPatient where PatientID = " + id;
            String ort = (String)cmd.ExecuteScalar();

            patAend.füllenTextBox(id, nachname, vorname, blutgruppe, ort);
            patAend.ShowDialog();
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
            adpPatient = new OleDbDataAdapter("select * from tPatient", con);
            anzeigen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teilAnzeigen();
        }

        private void teilAnzeigen()
        {
            try
            {
                adpPatient = null;
                String auswahl = Convert.ToString(comboBox1.SelectedItem);
                labelMeldung.Text = auswahl;




                adpPatient = new OleDbDataAdapter("select * from tPatient WHERE Bluttgruppe = '" + auswahl + "'", con);


                dsPatient = new DataSet();
                anzeigen();


            }

            catch
            {
                labelMeldung.Text = "Wählen Sie eine Blutgruppe aus";
            }



        }

        private void loeschen()
        {
            int patient = Convert.ToInt16(textBoxAendernLoeschen.Text);
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "DELETE FROM tPatient where PatientID = " + patient;
            cmd1.CommandType = CommandType.Text;

            try
            {
                cmd1.ExecuteNonQuery();
                anzeigen();
            }
            catch (Exception)
            {
                if (textBoxAendernLoeschen.Text == "")
                {
                    labelMeldung.Text = "Das ID Feld ist leer";
                }
                else
                {
                    labelMeldung.Text = "Bitte geben sie eine gültige ID ein";
                }
            }

        }
    }
}

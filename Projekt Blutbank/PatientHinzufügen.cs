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
    public partial class PatientHinzufügen : Form
    {
        OleDbConnection con = null;
        


        public PatientHinzufügen()
        {
            InitializeComponent();
        }

        public PatientHinzufügen(OleDbConnection connnection):this()
        {
            this.con = connnection;
            comboBoxBlutgruppe.SelectedIndex = 1;
           
        }

        private void buttonBestätigen_Click(object sender, EventArgs e)
        {


            Patient p = new Patient();
          
            p.Nachname = textBoxNachname.Text;
            p.Vorname = textBoxVorname.Text;
            p.Blutgruppe = ""+comboBoxBlutgruppe.SelectedItem;
            p.Wohnort = textBoxWohnort.Text;

            if (textBoxNachname.Text != "" && textBoxVorname.Text != "" && textBoxWohnort.Text != "")
            {
                insertDB(p);
                this.Close();
            }

            else
            {
                MessageBox.Show("Bitte alle Daten ausfüllen!");
            }
        }

        private void insertDB(Patient p)
        {
            OleDbCommand cmd = con.CreateCommand();
            String sql = "Insert into tPatient( Nachname, Vorname, Bluttgruppe, Wohnort)"; 
            sql += "Values(Nname, Vname, BG, Ort)"; 

           
            cmd.Parameters.Add("Nname", OleDbType.WChar);
            cmd.Parameters.Add("Vname", OleDbType.WChar);
            cmd.Parameters.Add("BG", OleDbType.WChar);
            cmd.Parameters.Add("Ort", OleDbType.WChar);

            cmd.CommandText = sql;

            // Values
            cmd.Parameters["Nname"].Value = p.Nachname;
            cmd.Parameters["Vname"].Value = p.Vorname;
            cmd.Parameters["BG"].Value = p.Blutgruppe;
            cmd.Parameters["Ort"].Value = p.Wohnort;

            // Ausführen
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Einfügen erfolgreich!");

                cmd.CommandText = "SELECT @@IDENTITY";
                Int32 autowert = (Int32)cmd.ExecuteScalar();
                p.PatientID = autowert;
                textBoxPatientId.Text = autowert.ToString();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Einfügen nicht erfolgreich.");
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

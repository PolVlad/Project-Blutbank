using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Blutbank
{
    public partial class PatientÄndern : Form
    {
        OleDbConnection con = null;
        int id;
        public PatientÄndern()
        {
            InitializeComponent();
        }

        public PatientÄndern(OleDbConnection connection, int id)
        {
            this.con = connection;
            this.id = id;
            InitializeComponent();
        }
        
        private void editDB()
        {
            OleDbCommand cmd = con.CreateCommand();
            String sql = "Update tPatient set Nachname = '" + textBoxNachname.Text + "', Vorname = '" + textBoxVorname.Text + "', Bluttgruppe = '" + comboBoxBlutgruppe.Text + "', Wohnort = '" + textBoxWohnort.Text + "' where PatientID = " + textBoxPatientId.Text;

            cmd.Parameters.Add("Nname", OleDbType.WChar);
            cmd.Parameters.Add("Vname", OleDbType.WChar);
            cmd.Parameters.Add("BG", OleDbType.WChar);
            cmd.Parameters.Add("Ort", OleDbType.WChar);

            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ändern nicht erfolgreich");
            }
            this.Close();
        }
        

        internal void füllenTextBox(int id, String nachname, String vorname, String blutgruppe, String ort)
        {
            textBoxPatientId.Text = Convert.ToString(id);
            textBoxNachname.Text = nachname;
            textBoxVorname.Text = vorname;
            comboBoxBlutgruppe.Text = blutgruppe;
            textBoxWohnort.Text = ort;
        }

        private void buttonBestätigen_Click_1(object sender, EventArgs e)
        {
            try
            {
                editDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten");
            }
        }

        private void buttonAbbrechen_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

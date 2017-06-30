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
    public partial class SpenderHinzufügen : Form
    {
        OleDbConnection con = null;


        public SpenderHinzufügen()
        {
            InitializeComponent();
        }

        public SpenderHinzufügen(OleDbConnection con)
        {
            InitializeComponent();
            this.con = con;
        }


        private void insertDB(Spender s)
        {
            OleDbCommand cmd = con.CreateCommand();
            String sql = "Insert into tSpender( Nachname, Vorname, Blutgruppe, Wohnort)";
            sql += "Values(Nname, Vname, BG, Ort)";


            cmd.Parameters.Add("Nname", OleDbType.WChar);
            cmd.Parameters.Add("Vname", OleDbType.WChar);
            cmd.Parameters.Add("BG", OleDbType.WChar);
            cmd.Parameters.Add("Ort", OleDbType.WChar);

            cmd.CommandText = sql;

            // Values
            cmd.Parameters["Nname"].Value = s.Nachname;
            cmd.Parameters["Vname"].Value = s.Vorname;
            cmd.Parameters["BG"].Value = s.Blutgruppe;
            cmd.Parameters["Ort"].Value = s.Wohnort;

            // Ausführen
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Einfügen erfolgreich!");

                cmd.CommandText = "SELECT @@IDENTITY";
                Int32 autowert = (Int32)cmd.ExecuteScalar();
                s.SpenderID = autowert;
                textBoxSpenderId.Text = autowert.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Einfügen nicht erfolgreich.");
            }
            this.Close();
        }


        private void buttonBestätigen_Click_1(object sender, EventArgs e)
        {
            Spender s = new Spender();

            s.Nachname = textBoxNachname.Text;
            s.Vorname = textBoxVorname.Text;
            s.Blutgruppe = "" + comboBoxBlutgruppe.SelectedItem;
            s.Wohnort = textBoxWohnort.Text;

            insertDB(s);
        }

        private void buttonAbbrechen_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

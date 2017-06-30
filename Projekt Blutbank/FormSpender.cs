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
    public partial class FormSpender : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adpSpender;
        OleDbDataAdapter adpBlutbank;
        OleDbCommand cmd;
        DataSet dsSpender;
        DataSet dsBlutbank;
        public FormSpender()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            con = new OleDbConnection(Properties.Settings.Default.DBcon);
            adpSpender = new OleDbDataAdapter("select * from tSpender", con);
            adpBlutbank = new OleDbDataAdapter("select * from tBlutbank", con);
            dsSpender = new DataSet();
            dsBlutbank = new DataSet();
            con.Open();
            anzeigen();
            //adpBestellung = new OleDbDataAdapter("select * from tBestellung", con);
            //CreateCmdObjectKunde();
        }

        private void FormSpender_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }

        private void close()
        {

            Form1 frm = new Form1();
            frm.Visible = true;

            this.Visible = false;

        }

        private void anzeigen()
        {
            dsSpender.Clear();
            adpSpender.Fill(dsSpender, "Spender");
            dataGridViewSpender.DataSource = dsSpender.Tables["Spender"];
        }

        private void buttonSpenderHinzu_Click(object sender, EventArgs e)
        {
            SpenderHinzufügen spenHinzu = new SpenderHinzufügen(con);
            spenHinzu.ShowDialog();
        }

        private void buttonSpenderAendern_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxAendernLoeschen.Text);
            SpenderÄndern spenAend = new SpenderÄndern(con, id);
            cmd = con.CreateCommand();

            cmd.CommandText = "select Nachname from tSpender where SpenderID = " + id;
            String nachname = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Vorname from tSpender where SpenderID = " + id;
            String vorname = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Blutgruppe from tSpender where SpenderID = " + id;
            String blutgruppe = (String)cmd.ExecuteScalar();
            cmd.CommandText = "select Wohnort from tSpender where SpenderID = " + id;
            String ort = (String)cmd.ExecuteScalar();

            spenAend.füllenTextBox(id, nachname, vorname, blutgruppe, ort);
            spenAend.ShowDialog();
        }

        private void buttonSpenderLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten sie wirklich löschen ?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loeschen();
            }
            else
            {

            }
        }

        private void loeschen()
        {
            int spender = Convert.ToInt16(textBoxAendernLoeschen.Text);
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "DELETE FROM tSpender where SpenderID = " + spender;
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

        private void buttonSpenderAnzeigen_Click(object sender, EventArgs e)
        {
            adpSpender = new OleDbDataAdapter("select * from tSpender", con);
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
                adpSpender = null;
                String auswahl = Convert.ToString(comboBox1.SelectedItem);
                labelMeldung.Text = auswahl;




                adpSpender = new OleDbDataAdapter("select * from tSpender WHERE Blutgruppe = '" + auswahl + "'", con);


                dsSpender = new DataSet();
                anzeigen();


            }

            catch
            {
                labelMeldung.Text = "Wählen Sie eine Blutgruppe aus";
            }



        }
    }
}

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
            /*dataGridViewSpender.DataSource = null;
            dataGridViewSpender.Rows.Clear();*/
            dsSpender.Clear();
            adpSpender.Fill(dsSpender, "Spender");
            dataGridViewSpender.DataSource = dsSpender.Tables["Spender"];
        }

        private void buttonSpenderHinzu_Click(object sender, EventArgs e)
        {
            SpenderHinzufügen spenHinzu = new SpenderHinzufügen();
            spenHinzu.ShowDialog();
        }

        private void buttonSpenderAendern_Click(object sender, EventArgs e)
        {
            SpenderÄndern spenAend = new SpenderÄndern();
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
            throw new NotImplementedException();
        }

        private void buttonSpenderAnzeigen_Click(object sender, EventArgs e)
        {
            anzeigen();
        }
    }
}

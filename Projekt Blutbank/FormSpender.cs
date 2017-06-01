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
    public partial class FormSpender : Form
    {
        public FormSpender()
        {
            InitializeComponent();
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
    }
}

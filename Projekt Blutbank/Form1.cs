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
    public partial class Form1 : Form
    {
      


        public Form1()
        {
            InitializeComponent();
     


        }

        private void buttonEinloggen_Click(object sender, EventArgs e)
        {
            if(comboBoxAuswahl.SelectedIndex.Equals(0))  //PatientFenster
            {
                FormPatient frmPatient = new FormPatient();
                
                frmPatient.Show();
                this.Visible = false;
                              
            }
            if (comboBoxAuswahl.SelectedIndex.Equals(1))   //SpenderFenster
            {
                FormSpender frmSpender = new FormSpender();

                frmSpender.Show();
                this.Visible = false;

            }

        }
    }
}

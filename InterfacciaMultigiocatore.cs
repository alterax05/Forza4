
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4
{
    public partial class InterfacciaMultigiocatore : Form
    {
        public InterfacciaMultigiocatore()
        {
            InitializeComponent();
        }
        public static string nome1 = "";
        public static string nome2 = "";
        private void Segno1_Click(object sender, EventArgs e)
        {
            Giocatore1.ReadOnly = true;
            Segno1.Visible = false;
            Giocatore2.Visible = true;
            Segno2.Visible = true;

            Segno1 frm = new Segno1();
            frm.Show();
        }

        private void Segno2_Click(object sender, EventArgs e)
        {
            Giocatore2.ReadOnly = true;
            Segno2.Visible = false;
            Gioca.Visible = true;
            Segno2 frm = new Segno2();
            frm.Show();   
        }

        private void Gioca_Click(object sender, EventArgs e)
        {
            nome1 = Giocatore1.Text;
            nome2 = Giocatore2.Text;
            Forza4Multigiocatore frm = new Forza4Multigiocatore();
            frm.Show();
            this.Visible = false;
        }
    }
}

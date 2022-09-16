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
    public partial class Segno1 : Form
    {
        
        public Segno1()
        {
            InitializeComponent();
        }

        public static Color colore1;
        public static String Giocatoresegno1="";
        string GiocatoreSegno1;

        private void button15_Click(object sender, EventArgs e)
        {
            Giocatoresegno1 = GiocatoreSegno1;
            colore1 = colore1;
            this.Close();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cambiare tutti i back color dei bottoni segno
            
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            button11.BackColor = Color.Black;
            button12.BackColor = Color.Black;
            button13.BackColor = Color.Black;
            button14.BackColor = Color.Black;
            GiocatoreSegno1 = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.White;
            label2.Visible = true;
            pictureBox1.Visible = true;
            button16.Text = GiocatoreSegno1;
            button16.ForeColor = colore1;
            button15.Visible = true;
        }

        private void DarkRed_Click(object sender, EventArgs e)
        {

           colore1 = ((Button)sender).FlatAppearance.BorderColor;
           button16.Visible = true;
            button16.Text = GiocatoreSegno1;
            button16.ForeColor = colore1;
            button16.BackColor = Color.Black;
            button15.Visible = true;

        }
    }
}

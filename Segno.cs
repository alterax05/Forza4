namespace Forza4
{
    public partial class Segno : Form
    {

        public Segno()
        {
            InitializeComponent();
        }

        public Color colore;
        public String giocatoreSegno;

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cambiare tutti i backcolor dei bottoni segno

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

            giocatoreSegno = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.White;
            label2.Visible = true;
            pictureBox1.Visible = true;
            button16.Text = giocatoreSegno;
            button16.ForeColor = colore;
            button15.Visible = true;
        }

        private void DarkRed_Click(object sender, EventArgs e)
        {
            colore = ((Button)sender).FlatAppearance.BorderColor;
            button16.Visible = true;
            button16.Text = giocatoreSegno;
            button16.ForeColor = colore;
            button16.BackColor = Color.Black;
            button15.Visible = true;
        }
    }
}

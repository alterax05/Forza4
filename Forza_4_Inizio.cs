namespace Forza4
{
    public partial class Forza_4_Inizio : Form
    {
        public Forza_4_Inizio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Show();
            button4.Visible = true;
            GIOCA.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterfacciaMultigiocatore frm = new InterfacciaMultigiocatore();
            frm.Show();
            this.Visible = false;
        }

        private void GIOCA_Click(object sender, EventArgs e)
        {
            Forza4Solitario frm = new Forza4Solitario(textBox1.Text);
            frm.Show();
            this.Visible = false;
        }
    }
}
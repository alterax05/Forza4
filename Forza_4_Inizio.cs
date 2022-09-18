namespace Forza4
{
    public partial class Forza_4_Inizio : Form
    {
        public Forza_4_Inizio()
        {
            InitializeComponent();
        }
        private void giocaInizio_Click(object sender, EventArgs e)
        {
            giocaInizio.Visible = false;
            solitario.Visible = true;
            multigiocatore.Visible = true;
        }
        private void solitario_Click(object sender, EventArgs e)
        {
            solitario.Visible = false;
            multigiocatore.Visible = false;
            solitario_textBox.Show();
            scrivi_Nome.Visible = true;
            gioca.Visible = true;
        }
        private void multigiocatore_Click(object sender, EventArgs e)
        {
            InterfacciaMultigiocatore frm = new InterfacciaMultigiocatore();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
        private void gioca_Click(object sender, EventArgs e)
        {
            Forza4Solitario frm = new Forza4Solitario(solitario_textBox.Text);
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
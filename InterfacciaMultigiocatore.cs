namespace Forza4
{
    public partial class InterfacciaMultigiocatore : Form
    {
        Color coloreSinistra;
        String giocatoreSinistra;
        Color coloreDestra;
        String giocatoreDestra;

        public InterfacciaMultigiocatore()
        {
            InitializeComponent();
        }

        private void Segno1_Click(object sender, EventArgs e)
        {
            Giocatore1.ReadOnly = true;
            Segno1.Visible = false;
            Giocatore2.Visible = true;
            Segno2.Visible = true;

            Segno frm = new Segno();
            frm.ShowDialog();

            coloreSinistra = frm.colore;
            giocatoreSinistra = frm.giocatoreSegno;
        }

        private void Segno2_Click(object sender, EventArgs e)
        {
            Giocatore2.ReadOnly = true;
            Segno2.Visible = false;
            Gioca.Visible = true;

            Segno frm = new Segno();
            frm.ShowDialog();

            coloreDestra = frm.colore;
            giocatoreDestra = frm.giocatoreSegno;
        }

        private void Gioca_Click(object sender, EventArgs e)
        {
            Forza4Multigiocatore frm = new Forza4Multigiocatore(Giocatore1.Text, Giocatore2.Text, coloreSinistra, giocatoreSinistra, coloreDestra, giocatoreDestra);
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}

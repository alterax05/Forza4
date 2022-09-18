namespace Forza4
{
    public partial class Pausa : Form
    {
        public Pausa()
        {
            InitializeComponent();
        }
        private void tornaAllaHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ricarica_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void continua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

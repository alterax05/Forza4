namespace Forza4
{
    public partial class Pareggio : Form
    {
        public Pareggio()
        {
            InitializeComponent();
        }

        private void ricarica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tornaAllaHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

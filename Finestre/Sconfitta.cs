namespace Forza4
{
    public partial class Sconfitta : Form
    {
        public Sconfitta()
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

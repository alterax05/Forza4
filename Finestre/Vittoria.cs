namespace Forza4
{
    public partial class Vittoria : Form
    {
        string nomeDestra;
        string nomeSinistra;
        bool vittoriaSinistra;
        string nomeSolitario;
        bool vittoriaSolitaria;

        public Vittoria(string nomeSinistra, string nomeDestra, bool vittoriaSinistra, string nomeSolitario, bool vittoriaSolitaria)
        {
            InitializeComponent();
            this.nomeSinistra = nomeSinistra;
            this.nomeDestra = nomeDestra;
            this.vittoriaSinistra = vittoriaSinistra;
            this.nomeSolitario = nomeSolitario;
            this.vittoriaSolitaria = vittoriaSolitaria;
            if (vittoriaSolitaria)
            {
                label2.Text = nomeSolitario;
            }
            else
            {
                if (vittoriaSinistra == true)
                {
                    label2.Text = nomeSinistra;
                }
                else
                {
                    label2.Text = nomeDestra;
                }
            }

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

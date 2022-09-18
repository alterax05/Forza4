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

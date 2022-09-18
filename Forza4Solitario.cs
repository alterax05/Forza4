namespace Forza4
{
    public partial class Forza4Solitario : Form
    {
        int[,] M = new int[6, 7];
        Label[,] labels;
        Button[] buttons;
        int cont = 0;

        bool vittoria = false;
        bool pareggio = false;

        int punteggiodestra = 0;
        int punteggiosinistra = 0;

        string nomeSolitario = "";
        bool vittoriaSolitaria = false;

        public Forza4Solitario(string nome)
        {
            InitializeComponent();
            GiocatoreSinistra.Text = nome;
            labels = new Label[6, 7] {
                { A0, B0, C0, D0, E0, F0, G0 },
                { A1, B1, C1, D1, E1, F1, G1 },
                { A2, B2, C2, D2, E2, F2, G2 },
                { A3, B3, C3, D3, E3, F3, G3 },
                { A4, B4, C4, D4, E4, F4, G4 },
                { A5, B5, C5, D5, E5, F5, G5 }
            };
            buttons = new Button[7] { Abutton, Bbutton, Cbutton, Dbutton, Ebutton, Fbutton, Gbutton };
        }
        private void ButtonPausa_Click(object sender, EventArgs e)
        {
            Pausa frm = new Pausa();
            var result = frm.ShowDialog();
            if (result == DialogResult.Retry)
            {
                Ricarica();
            }
        }
        private void Vittoria(int riga, int colonna)
        {
            string c = "";
            string r = "";
            string d1 = "";
            string d2 = "";

            string test_1 = "1111";
            string test_2 = "2222";

            int shift = colonna - riga;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == riga)
                    {
                        r += Convert.ToString(M[i, j]);
                    }
                    if (j == colonna)
                    {
                        c += Convert.ToString(M[i, j]);
                    }
                    if (i + shift == j && i + shift < 7)
                    {
                        d1 += Convert.ToString(M[i, j]);
                    }
                    if (i + j == riga + colonna)
                    {
                        d2 += Convert.ToString(M[i, j]);
                    }
                    if (M[i, j] != 0)
                    {
                        pareggio = false;
                    }
                }
            }
            int r_find2 = r.IndexOf(test_2);
            for (int i = r_find2; i < r_find2 + 4 && r_find2 != -1; i++)
            {
                labels[riga, i].ForeColor = Color.White;
            }

            int c_find2 = c.IndexOf(test_2);
            for (int i = c_find2; i < c_find2 + 4 && c_find2 != -1; i++)
            {
                labels[i, colonna].ForeColor = Color.White;
            }

            int d1_find2 = d1.IndexOf(test_2);
            for (int i = d1_find2; i < d1_find2 + 4 && d1_find2 != -1; i++)
            {
                labels[i, i + shift].ForeColor = Color.White;
            }

            int d2_find2 = d2.IndexOf(test_2);
            for (int i = riga, j = colonna; i < riga + 4 && d2_find2 != -1; i++, j--)
            {
                labels[i, j].ForeColor = Color.White;
            }

            int r_find1 = r.IndexOf(test_1);
            for (int i = r_find1; i < r_find1 + 4 && r_find1 != -1; i++)
            {
                labels[riga, i].ForeColor = Color.White;
            }

            int c_find1 = c.IndexOf(test_1);
            for (int i = c_find1; i < c_find1 + 4 && c_find1 != -1; i++)
            {
                labels[i, colonna].ForeColor = Color.White;
            }

            int d1_find1 = d1.IndexOf(test_1);
            for (int i = d1_find1; i < d1_find1 + 4 && d1_find1 != -1; i++)
            {
                labels[i, i + shift].ForeColor = Color.White;
            }

            int d2_find1 = d2.IndexOf(test_1);
            for (int i = riga, j = colonna; i < riga + 4 && d2_find1 != -1; i++, j--)
            {
                labels[i, j].ForeColor = Color.White;
            }
            //uso il contatore che quando arriva a 41 significa che c'è stato pareggio
            cont = cont + 1;
            if (r.Contains(test_1) || c.Contains(test_1) || d1.Contains(test_1) || d2.Contains(test_1))
            {
                //faccio vedere la form vittoria
                vittoria = true;
                cont = 0;
                giocaAncora.Visible = true;
                punteggiosinistra++;
                PunteggioSinistra.Text = Convert.ToString(punteggiosinistra);
                nomeSolitario = GiocatoreSinistra.Text;
                vittoriaSolitaria = true;
                Vittoria frm = new Vittoria("", "", false, nomeSolitario, vittoriaSolitaria);
                var result = frm.ShowDialog();
                if (result == DialogResult.Retry)
                {
                    Ricarica();
                }
            }
            else
            {
                if (r.Contains(test_2) || c.Contains(test_2) || d1.Contains(test_2) || d2.Contains(test_2))
                {
                    // form sconfitta
                    punteggiodestra++;
                    cont = 0;
                    giocaAncora.Visible = true;
                    PunteggioDestra.Text = Convert.ToString(punteggiodestra);
                    Sconfitta frm = new Sconfitta();
                    var result = frm.ShowDialog();
                    vittoria = true;
                    if (result == DialogResult.Retry)
                    {
                        Ricarica();
                    }
                }
                else
                {
                    if (cont == 41)
                    {
                        //form pareggio
                        giocaAncora.Visible = true;
                        Pareggio frm = new Pareggio();
                        var result = frm.ShowDialog();
                        pareggio = true;
                        if (result == DialogResult.Retry)
                        {
                            Ricarica();
                        }
                    }
                }
            }
        }
        private void Computer()
        {
            // rendo visibile botton computer
            int colonna;
            // numero random generato che lo inserisco come colonna
            Random random = new Random();
            colonna = random.Next(0, 7);
            bool cambiato = false;
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (labels[i, colonna].Text == "")
                    {
                        labels[i, colonna].Text = SegnoDestra.Text;
                        labels[i, colonna].ForeColor = SegnoDestra.ForeColor;
                        int riga = i;
                        M[i, colonna] = 2;
                        Vittoria(riga, colonna);
                        cambiato = true;
                        break;
                    }
                }
                if (cambiato)
                {
                    break;
                }
                colonna = random.Next(0, 7);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            int riga = 0;
            int colonna = (int)((Button)sender).Name[0] - 65;
            for (int i = 5; i >= 0; i--)
            {
                if (labels[i, colonna].Text == "")
                {
                    riga = i;
                    labels[i, colonna].Text = SegnoSinistra.Text;
                    labels[i, colonna].ForeColor = SegnoSinistra.ForeColor;
                    M[i, colonna] = 1;
                    break;
                }
            }
            Vittoria(riga, colonna);
            if (vittoria == false)
            {
                Computer();
            }
        }
        private void giocaAncora_Click(object sender, EventArgs e)
        {
            Ricarica();
        }
        private void Ricarica()
        {
            foreach (Label l in labels)
            {
                l.Text = "";
                l.ForeColor = DefaultForeColor;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    M[i, j] = 0;
                }
            }

            foreach (Button b in buttons)
            {
                b.Enabled = true;
            }

            vittoria = false;
            pareggio = false;
            giocaAncora.Visible = false;
        }

    }
}





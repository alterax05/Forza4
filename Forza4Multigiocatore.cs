using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Forza4
{
    public partial class Forza4Multigiocatore : Form
    {
        int[,] M = new int[6, 7];
        Label[,] labels;
        Button[] buttons;

        bool turno = true;
        bool vittoria = false;
        bool pareggio = false;

        int punteggiodestra = 0;
        int punteggiosinistra = 0;

        int cont = 0;

        //true = sinistra
        //false = destra

        string nomeDestra = "";
        string nomeSinistra = "";
        bool vittoriaSinistra = false;

        public Forza4Multigiocatore(string nomeDestra, string nomeSinistra, Color coloreSinistra, string giocatoreSinistra, Color coloreDestra, string giocatoreDestra)
        {
            InitializeComponent();
            // Scritte giocatori
            GiocatoreSinistra.Text = this.nomeSinistra = nomeSinistra;
            GiocatoreDestra.Text = this.nomeDestra = nomeDestra;
            // Segni testo e colore giocatori
            SegnoSinistra.Text = giocatoreSinistra;
            SegnoSinistra.ForeColor = coloreSinistra;
            SegnoDestra.Text = giocatoreDestra;
            SegnoDestra.ForeColor = coloreDestra;

            labels = new Label[6, 7]{
                {A0,B0,C0,D0,E0,F0,G0},
                {A1,B1,C1,D1,E1,F1,G1},
                {A2,B2,C2,D2,E2,F2,G2},
                {A3,B3,C3,D3,E3,F3,G3},
                {A4,B4,C4,D4,E4,F4,G4},
                {A5,B5,C5,D5,E5,F5,G5}
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
        public void Vittoria(int riga, int colonna)
        {
            //1 = sinistra
            //2 = destra


            pareggio = true;

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
            cont = +1;
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
            if (r.Contains(test_1) || c.Contains(test_1) || d1.Contains(test_1) || d2.Contains(test_1))
            {
                vittoria = true;
                cont = 0;
                punteggiosinistra++;
                PunteggioSinistra.Text = Convert.ToString(punteggiosinistra);
                nomeSinistra = GiocatoreSinistra.Text;
                vittoriaSinistra = true;
                giocaAncora.Visible = true;
                Vittoria frm = new Vittoria(nomeSinistra, nomeDestra, vittoriaSinistra, "", false);
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
                    vittoria = true;
                    cont = 0;
                    punteggiodestra++;
                    PunteggioDestra.Text = Convert.ToString(punteggiodestra);
                    nomeDestra = GiocatoreDestra.Text;
                    vittoriaSinistra = false;
                    giocaAncora.Visible = true;
                    Vittoria frm = new Vittoria(nomeSinistra, nomeDestra, vittoriaSinistra, "", false);
                    var result = frm.ShowDialog();
                    if (result == DialogResult.Retry)
                    {
                        Ricarica();
                    }
                }
                else
                {
                    if (cont == 41)
                    {
                        giocaAncora.Visible = true;
                        Pareggio frm = new Pareggio();
                        var result = frm.ShowDialog();
                        if (result == DialogResult.Retry)
                        {
                            Ricarica();
                        }
                    }
                }
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
                    if (turno)
                    {
                        labels[i, colonna].Text = SegnoSinistra.Text;
                        labels[i, colonna].ForeColor = SegnoSinistra.ForeColor;
                        M[i, colonna] = 1;
                        break;
                    }
                    else
                    {
                        labels[i, colonna].Text = SegnoDestra.Text;
                        labels[i, colonna].ForeColor = SegnoDestra.ForeColor;
                        M[i, colonna] = 2;
                        break;
                    }
                }
            }

            if (labels[0, colonna].Text != "")
            {
                ((Button)sender).Enabled = false;
            }

            turno = !turno;

            Vittoria(riga, colonna);

        }
        private void giocaAncora_Click(object sender, EventArgs e)
        {
            Ricarica();
        }
        public void Ricarica()
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

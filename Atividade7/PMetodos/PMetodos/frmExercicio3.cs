using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemover1_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text,
                StringComparison.OrdinalIgnoreCase);
            //a      a         ss
            //casa   Fatec    Assessoria
            //c      F        A

            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text,
                StringComparison.OrdinalIgnoreCase);
            }
        }

        private void BtnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {
            //transforma string em array de char
            char[] vetorC = txtPalavra1.Text.ToCharArray();
            //inverter o array(vetor)
            Array.Reverse(vetorC);
            //voltar o vetor para string
            foreach (char C in vetorC)
                txtPalavra2.Text += C;
            //ou
            //txtPalavra2.Text = new string(vetorC);
            //ou
            //txtPalavra2.Text
        }
    }
}

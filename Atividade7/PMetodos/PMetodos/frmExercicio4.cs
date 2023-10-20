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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void BtnNumericos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var i=0; i<rchtxtFrase.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtFrase.Text[i]))
                    contador++; //contador=+1;
            }

            MessageBox.Show($"a frase tem {contador} números");
            //MessageBox.Show("a frase tem "+contador+" números);
           
        }

        private void BtnBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int posicao = 0;
            while (contador < rchtxtFrase.Text.Length)
            {
                //if (rchtxtFrase.Text[contador]==' ')
                if (Char.IsWhiteSpace(rchtxtFrase.Text[contador]))
                {
                    posicao = contador + 1;
                    break;
                }
                contador += 1;
                
            }

            MessageBox.Show("O primeiro caracter em branco " + "está na posição " + posicao);

        }

        private void BtnLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (var c in rchtxtFrase.Text)
            {
                if (char.IsLetter(c))
                {
                    contador++;
                }
            }

            MessageBox.Show($"O total de letras na frase é: {contador}");
        }
    }
}

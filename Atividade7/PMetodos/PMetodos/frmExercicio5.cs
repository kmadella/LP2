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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void BtnSorteio_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            if (!int.TryParse(txt1.Text, out numero1) ||
                !int.TryParse(txt2.Text, out numero2))
            {
                MessageBox.Show("Dados Inaválidos!");
            }
            else
            {
                if ((numero1 <= 0) || (numero2 <= 0) ||
                    (numero1 > numero2))
                {
                    MessageBox.Show("Primeiro número deve ser menor que o segundo");
                }
                else
                {
                    Random objR = new Random();
                    int aleatorio = objR.Next(numero1, numero2);
                    MessageBox.Show("O número aleatório é: " +aleatorio);
                }
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção copiar");
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção colar");
        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                // de o formulário não tiver nenhum componente dá erro, //precisaria testar o controls.Count do form
                Application.OpenForms["frmExercicio2"].BringToFront();
                //Uma opção seria usar o Activate() no lugar do BringToFront()// O método Activate() faz basicamente a
// mesma coisa que o BringToFront,
// com o adicional de dar foco no form.
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized; obj2.Show();
            }
        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                // de o formulário não tiver nenhum componente dá erro, //precisaria testar o controls.Count do form
                Application.OpenForms["frmExercicio3"].BringToFront();
                //Uma opção seria usar o Activate() no lugar do BringToFront()// O método Activate() faz basicamente a
                // mesma coisa que o BringToFront,
                // com o adicional de dar foco no form.
            }
            else
            {
                frmExercicio3 obj3 = new frmExercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized; obj3.Show();
            }
        }

        private void Exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                // de o formulário não tiver nenhum componente dá erro, //precisaria testar o controls.Count do form
                Application.OpenForms["frmExercicio4"].BringToFront();
                //Uma opção seria usar o Activate() no lugar do BringToFront()// O método Activate() faz basicamente a
                // mesma coisa que o BringToFront,
                // com o adicional de dar foco no form.
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized; obj4.Show();
            }
        }

        private void Exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                // de o formulário não tiver nenhum componente dá erro, //precisaria testar o controls.Count do form
                Application.OpenForms["frmExercicio5"].BringToFront();
                //Uma opção seria usar o Activate() no lugar do BringToFront()// O método Activate() faz basicamente a
                // mesma coisa que o BringToFront,
                // com o adicional de dar foco no form.
            }
            else
            {
                frmExercicio5 obj5 = new frmExercicio5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Maximized; obj5.Show();
            }
        }
    }
}

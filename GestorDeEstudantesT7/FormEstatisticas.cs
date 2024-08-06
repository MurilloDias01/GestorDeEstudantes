using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        Color corPainelTotal;
        Color corPainelMeninas;
        Color corPainelMeninos;
        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalDeEstudantes.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void labelTotalDeEstudantes_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Gray;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Red;
            labelMeninos.ForeColor = corPainelTotal;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelTotal;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Green;
            labelMeninas.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_Click(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }
    }
}

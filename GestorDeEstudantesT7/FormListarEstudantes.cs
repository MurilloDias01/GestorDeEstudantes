using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7
{
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListarEstudantes_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");

            dataGridViewListaDeAlunos.ReadOnly = true;

            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();

            dataGridViewListaDeAlunos.RowTemplate.Height = 80;

            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);

            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewListaDeAlunos.AllowUserToAddRows = false;
        }
    }
}

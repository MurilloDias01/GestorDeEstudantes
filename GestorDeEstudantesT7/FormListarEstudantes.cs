using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaDeAlunos_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizarApagarEstudantes formAtualizarApagarEstudantes = new FormAtualizarApagarEstudantes();

            formAtualizarApagarEstudantes.textBoxId.Text = 
                dataGridViewListaDeAlunos.CurrentRow.Cells[0].Value.ToString();
            formAtualizarApagarEstudantes.textBoxNome.Text = 
                dataGridViewListaDeAlunos.CurrentRow.Cells[1].Value.ToString();
            formAtualizarApagarEstudantes.textBoxSobrenome.Text = 
                dataGridViewListaDeAlunos.CurrentRow.Cells[2].Value.ToString();
           
            formAtualizarApagarEstudantes.dateTimePickerNascimento.Value =
               (DateTime) dataGridViewListaDeAlunos.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeAlunos.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            { 
               formAtualizarApagarEstudantes.
                    radioButtonFeminino.Checked = true;
            }
            else 
            {
                formAtualizarApagarEstudantes.
                    radioButtonMasculino.Checked = true;
            }

            formAtualizarApagarEstudantes.textBoxTelefone.Text =
                dataGridViewListaDeAlunos.CurrentRow.Cells[5].Value.ToString();
            formAtualizarApagarEstudantes.textBoxEndereco.Text =
                dataGridViewListaDeAlunos.CurrentRow.Cells[6].Value.ToString();

            byte[] foto;
            foto = (byte[]) dataGridViewListaDeAlunos.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(foto);
            formAtualizarApagarEstudantes.pictureBoxFoto.Image =
                Image.FromStream(fotoDoAluno);

            formAtualizarApagarEstudantes.Show();
        }
    }
}

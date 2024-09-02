using MySql.Data.MySqlClient;
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

namespace GestorDeEstudantesT7
{
    public partial class FormImprimirAlunos : Form
    {
        public FormImprimirAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormImprimirAlunos_Load(object sender, EventArgs e)
        {

        }

        private void preencheTabela(MySqlCommand comando)
        {
            // Preenche o dataGridView com as informações dos estudantes.
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = true;
            dateTimePickerFinal.Enabled = true;

        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = false;
            dateTimePickerFinal.Enabled = false;
        }


        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando;
            string busca;

            if (radioButtonSim.Checked == true)
            {
                string dataInicial = dateTimePickerInicial.Value.ToString("dd-MM-yyyy");
                string dataFinal = dateTimePickerFinal.Value.ToString("dd-MM-yyyy");

                if (radioButtonMasculino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Masculino'";
                       
                }
                else if (radioButtonFeminino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Feminino'";
                        
                }
                else
                {
                    busca = "SELECT * FROM 'estudantes'";
                     
                }
                comando = new MySqlCommand(busca);
                preencheTabela(comando);
            }
        }
        
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Salva o arquivo em arquivo de texto.
            //por padrão vai salvar na área de trabalho.
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\lista_de_estudantes.txt";

            // usamos issso somente ao salvar em arquivo de texto.
            using (var escritor = new StreamWriter(caminho))
            {
                // verificar se o arquivo de texto já existe.
                if (!File.Exists(caminho))
                {
                    File.Create(caminho);
                }
                
                DateTime dataDeNascimento;


                // percorre as linhas
                for (int i = 0;i<dataGridViewListaDeAlunos.Rows.Count;i++)
                {
                    //Percorre as colunas
                    for(int j = 0;j< dataGridViewListaDeAlunos.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            dataDeNascimento = Convert.ToDateTime(dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());
                            //escreve as informções de cada coluna (célula) de uma mesma linha.
                            escritor.Write("\t" + dataDeNascimento.ToString("dd/MM-yyyy") + "\t" + "|");
                        }
                        else if(j == dataGridViewListaDeAlunos.Columns.Count - 2)
                        {
                            escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            //escreve as informações de cada coluna (célula) de uma mesma liha.
                            escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        
                        
                    }
                    escritor.WriteLine();

                    escritor.WriteLine();
                    escritor.WriteLine("------------------------------------------------------------" +
                        "----------------------------------------------------" +
                        "---------------------------------------------------------------------------");
                }
                escritor.Close();
                MessageBox.Show("Dados Salvos!");
            }
        }
    }
}

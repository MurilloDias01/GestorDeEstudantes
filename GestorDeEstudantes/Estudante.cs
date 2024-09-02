using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantes
{
    internal class Estudante
    {
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

        public bool inserirEstudante(string Nome, string Sobrenome, DateTime Nascimento, string Telefone, string Genero, string Endereco, MemoryStream Foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`id`, `Nome`, `Sobrenome`, `Nascimento`, `Genero`, `Telefone`, `Endereco`, `Foto`)  VALUES (@Nome, @Sobrenome, @Nascimento, @Genero, @Telefone, @Endereco, @Foto)");

            comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value= Nome;
            comando.Parameters.Add("@Sobrenome", MySqlDbType.VarChar).Value = Sobrenome;
            comando.Parameters.Add("@Nascimento", MySqlDbType.Date).Value = Nascimento;
            comando.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = Genero;
            comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = Telefone;
            comando.Parameters.Add("@Endereco", MySqlDbType.Text).Value = Endereco;
            comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = Foto.ToArray();

            meuBancoDeDados.abrirConexao();

            if(comando.ExecuteNonQuery() == 1)
            { 
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
        } 
        
        //RETORNA a tabela dos estudantes que estão no banco de dados

        public DataTable getEstudantes(MySqlCommand comando)
        {
            comando.Connection = meuBancoDeDados.getConexao;

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaDeDados = new DataTable();
            adaptador.Fill(tabelaDeDados);

            return tabelaDeDados;
        } 
        
    }
}

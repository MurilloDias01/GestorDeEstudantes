using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorDeEstudantes
{
    internal class MeuBancoDeDados
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;passworld=;database=sga_estudantes_bd_t7");

        public MySqlConnection getConexao
        {
            get
            {
                return conexao; 
            
            }
        }
        public void abrirConexao()
        { 
            if (conexao.State == ConnectionState.Closed) 
            {
                conexao.Open();
            }
        }
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            { 
                conexao.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantes
{
    internal class MeuBancoDeDados
    {
        MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;passworld=;database=sga_estudantes_bd_t7"); 
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace AppFila.DAL
{
    internal class FabricaConexao
    {
        MySqlConnection conexao = null;
        public MySqlConnection Conectar()
        {
            try
            {
                string conn = @"Persist Security Info = false;
                            server = localhost;
                            database = gleison;
                            uid = root;
                            pwd = ;";
                conexao = new MySqlConnection(conn);
                conexao.Open();
                Console.WriteLine("Conectado");
            }
            catch (MySqlException)
            {
                throw new Exception("Houve um Erro na conexao");
            }
            finally
            {
                conexao.Close();
            }
            return conexao;
        }
    }
}

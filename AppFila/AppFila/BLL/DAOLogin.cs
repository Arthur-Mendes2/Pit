using MySql.Data.MySqlClient;
using AppFila.DAL;
using AppFila.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace AppFila.BLL
{
    internal class DAOLogin
    {
        public void Login(string l, string s)
        {
            MySqlConnection conexao = null;
            FabricaConexao f = new FabricaConexao();
            conexao = f.Conectar();
            string sql = "SELECT * FROM login WHERE email = '" + l.ToString() + "' and senha = '" + s.ToString() + "'";
            MySqlCommand query = new MySqlCommand(sql, conexao);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    TelaPrincipal principal = new TelaPrincipal();
                    principal.Show();
                    Form1 form = new Form1();
                    form.Hide();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    f.Conectar().Close();
                }
            }
            else
            {
                MessageBox.Show("Email ou Senha Invalidos!!!");
                Form1 form = new Form1();
                form.limparForm();
            }
        }
    }
}

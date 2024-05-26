using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using AppFila.UI;
using AppFila.BLL;

namespace AppFila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidaLogin();
        }
        public void ValidaLogin()
        {
            if (txtEmail.Text == "" && txtmaskSenha.Text == "")
            {
                MessageBox.Show("Email e Senha NAO pode ser Vazio");
                txtEmail.Focus();
            }
            else
            {
                DAOLogin dAO = new DAOLogin();
                string l = txtEmail.Text;
                string s = txtmaskSenha.Text;
                dAO.Login(l, s);
            }
        }
        public void limparForm()
        {
            txtEmail.Focus();
            txtmaskSenha.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

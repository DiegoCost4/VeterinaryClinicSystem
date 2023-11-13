using cldal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaui
{
    public partial class frmCadastro : Form
    {
            private MySqlConnection _conexaoUsers;
            private MySqlCommand _comandoSql;
            private Conexao _conexaoBanco;

            public frmCadastro()
            {
                InitializeComponent();
                _conexaoBanco = new Conexao();
            _conexaoUsers = _conexaoBanco.ObterConexao();
            }

            private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string userpassword = tbSenha.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(userpassword))
            {
                try
                {
                    _comandoSql = new MySqlCommand();
                    _comandoSql.Connection = _conexaoUsers;
                    _comandoSql.CommandText = "INSERT INTO users (username, userpassword) VALUES (@username, @userpassword)";

                    _comandoSql.Parameters.AddWithValue("@username", username);
                    _comandoSql.Parameters.AddWithValue("@userpassword", userpassword);

                    _comandoSql.ExecuteNonQuery();

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário. Verifique os detalhes da conexão com o banco de dados.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }
    }
}

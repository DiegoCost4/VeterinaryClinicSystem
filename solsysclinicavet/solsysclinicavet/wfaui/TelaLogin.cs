using System;
using System.Windows.Forms;
using cldal;
using MySql.Data.MySqlClient;

namespace wfaui
{
    public partial class TelaLogin : Form
    {
        private MySqlConnection _conexaoPets;
        private MySqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de cadastro
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpassword = textBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(userpassword))
            {
                _conexaoBanco = new Conexao();
                _conexaoPets = _conexaoBanco.ObterConexao();

                try
                {
                    // Use _conexaoPets em vez de connection
                    string query = "SELECT username, userpassword FROM users WHERE username = @username AND userpassword = @userpassword";
                    _comandoSql = new MySqlCommand(query, _conexaoPets); // Use _comandoSql em vez de cmd
                    _comandoSql.Parameters.AddWithValue("@username", username);
                    _comandoSql.Parameters.AddWithValue("@userpassword", userpassword);

                    using (MySqlDataReader reader = _comandoSql.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Credenciais válidas, o usuário está logado
                            MessageBox.Show("Login bem-sucedido!");
                            frmPrincipal frm = new frmPrincipal();
                            //Abre formulario principal
                            frm.Show();

                        }
                        else
                        {
                            // Credenciais inválidas, exibir uma mensagem de erro
                            MessageBox.Show("Credenciais inválidas. Tente novamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados. Verifique os detalhes da conexão: " + ex.Message);
                }
                finally
                {
                    _conexaoBanco.FecharConexao(_conexaoPets); // Feche a conexão
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

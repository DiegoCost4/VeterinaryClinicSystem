using clmodel;
using MySql.Data.MySqlClient;
using System.Data;

using cldal;
using MySqlX.XDevAPI.Relational;
using System.Globalization;
using System.Xml.Linq;

namespace cldal
{
    public class ClientesDal
    {
        private MySqlConnection _conexaoClientes;
        private MySqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public ClientesDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoClientes = _conexaoBanco.ObterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    " select isnull(max(cliid), 0) + 1 as codigo" +
                    "  from clientes";

                codigo = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;

            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(ClientesModel parCliente)
        {
            int codigo = obterProximoId();
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    "INSERT INTO clientes ( clinome, clicpf, cliemail, clidatacadastro)" +
                    " VALUES (@clinome, @clicpf, @cliemail, @clidatacadastro) ";
                //_comandoSql.Parameters.Add("@cliid", MySqlDbType.Int32).Value = codigo;
                _comandoSql.Parameters.Add("@clinome", MySqlDbType.VarChar).Value = parCliente.Nome;
                _comandoSql.Parameters.Add("@clicpf", MySqlDbType.Decimal).Value = parCliente.Cpf;
                _comandoSql.Parameters.Add("@cliemail", MySqlDbType.VarChar).Value = parCliente.Email;
                _comandoSql.Parameters.Add("@clidatacadastro", MySqlDbType.DateTime).Value = parCliente.DataCad;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(ClientesModel parCliente)
        {
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    "UPDATE clientes" +
                    "  SET clinome = @clinome," +
                    "      clicpf = @clicpf, " +
                    "      cliemail = @cliemail " +
                    "WHERE cliid = @cliid";

                _comandoSql.Parameters.Add("@cliid", MySqlDbType.Int32).Value = parCliente.Codigo;
                _comandoSql.Parameters.Add("@clinome", MySqlDbType.VarChar).Value = parCliente.Nome;
                _comandoSql.Parameters.Add("@clicpf", MySqlDbType.Decimal).Value = parCliente.Cpf;
                _comandoSql.Parameters.Add("@cliemail", MySqlDbType.VarChar).Value = parCliente.Email;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void excluir(int parCodigoCliente)
        {
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    "DELETE FROM clientes WHERE cliid = @cliid";

                _comandoSql.Parameters.AddWithValue("@cliid", parCodigoCliente);
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarTodos()
        {
            DataTable tabela;
            MySqlDataAdapter adaptador;
           
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    "SELECT cliid, clinome, clicpf, cliemail" +
                    "FROM clientes" +
                    "ORDER BY clinome";
                tabela = new DataTable();
                adaptador = new MySqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }

        }

        public List<ClientesModel> listarTodosArray()
        {
            List<ClientesModel> lista = new List<ClientesModel>();
            MySqlDataReader leitor;

            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText =
                    "SELECT cliid, clinome, clicpf, cliemail, clidatacadastro" +
                    "  FROM clientes" + 
                    "  order by clinome asc";
                leitor = _comandoSql.ExecuteReader();

                    while (leitor.Read())
                    {
                        ClientesModel item = new ClientesModel();
                        item.Codigo = Convert.ToInt32(leitor["cliid"]);
                        item.Nome = leitor["clinome"].ToString();
                        item.Cpf = Convert.ToDecimal(leitor["clicpf"]);
                        item.Email = leitor["cliemail"].ToString();
                        //item.DataCad = leitor["clidatacadastro"].ToString();

                        lista.Add(item);
                    }
                    leitor.Close();
                    
                    return lista;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }

        }

        public bool VerificarEmailExistente(string Email)
        {
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoClientes;
                _comandoSql.CommandText = "SELECT COUNT(*) FROM clientes WHERE cliemail = @cliemail";
                _comandoSql.Parameters.Add("@cliemail", MySqlDbType.VarChar).Value = Email;

                int count = Convert.ToInt32(_comandoSql.ExecuteScalar());

                return count > 0; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}

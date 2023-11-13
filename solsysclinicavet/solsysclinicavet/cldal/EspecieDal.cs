using clmodel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cldal;

namespace cldal
{
    public class EspecieDal
    {
        private MySqlConnection _conexaoEspecies;
        private MySqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public EspecieDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoEspecies = _conexaoBanco.ObterConexao();
        }
        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    " SELECT ISNULL(MAX(espid), 0) + 1 AS codigo" +
                    "  FROM especies";

                codigo = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;

            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }
        public void inserir(EspecieModel parEspecie)
        {
            int codigo = obterProximoId();
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    "INSERT INTO especies ( espnome)" +
                    " VALUES (@espnome) ";                
                _comandoSql.Parameters.Add("@espnome", MySqlDbType.VarChar).Value = parEspecie.Nome;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void atualizar(EspecieModel parEspecie)
        {
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    "UPDATE especies" +
                    "  SET espnome = @espnome " +

                    "WHERE espid = @espid";

                _comandoSql.Parameters.Add("@espid", MySqlDbType.Int32).Value = parEspecie.Codigo;
                _comandoSql.Parameters.Add("@espnome", MySqlDbType.VarChar).Value = parEspecie.Nome;

                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void excluir(int parCodigoEspecie)
        {
            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    "DELETE FROM especies WHERE espid = @espid";

                _comandoSql.Parameters.AddWithValue("@espid", parCodigoEspecie);
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
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    "SELECT espid, espnome" +
                    "FROM especies" +
                    "ORDER BY espnome";
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
        public List<EspecieModel> listarTodosArray()
        {
            List<EspecieModel> lista = new List<EspecieModel>();
            MySqlDataReader leitor;

            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoEspecies;
                _comandoSql.CommandText =
                    "SELECT espid, espnome" +
                    "  FROM especies" +
                    "  order by espnome asc";
                leitor = _comandoSql.ExecuteReader();

                while (leitor.Read())
                {
                    EspecieModel item = new EspecieModel();
                    item.Codigo = Convert.ToInt32(leitor["espid"]);
                    item.Nome = leitor["espnome"].ToString();

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

    }
}

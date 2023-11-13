using clmodel;
using MySql.Data.MySqlClient;
using System.Data;

using cldal;
using MySqlX.XDevAPI.Relational;

namespace cldal
{
    public class PetsDal
    {
        private MySqlConnection _conexaoPets;
        private MySqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public PetsDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoPets = _conexaoBanco.ObterConexao();
        }


        private int ObterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new MySqlCommand();
                _comandoSql.Connection = _conexaoPets;
                _comandoSql.CommandText =
                    " select isnull(max(aniid), 0) + 1 as codigo" +
                    "  from animais";

                codigo = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;

            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }
        public void inserir(PetsModel parPets)
        {
                int codigo = ObterProximoId();
                try
                {
                    _comandoSql = new MySqlCommand();
                    _comandoSql.Connection = _conexaoPets;
                    _comandoSql.CommandText =
                        "INSERT INTO animais (aninome, aniapelido, anidatanasc, aniobservacoes)" +
                        " VALUES (@aninome, @aniapelido, @anidatanasc,@aniobservacoes) ";
                    //_comandoSql.Parameters.Add("@aniid", (MySqlDbType)SqlDbType.Int).Value = codigo;
                    _comandoSql.Parameters.Add("@aninome", MySqlDbType.VarChar).Value = parPets.Nome;
                    _comandoSql.Parameters.Add("@aniapelido", MySqlDbType.VarChar).Value = parPets.Apelido;
                    _comandoSql.Parameters.Add("@anidatanasc", MySqlDbType.DateTime).Value = parPets.Datanasc;
                    _comandoSql.Parameters.Add("@aniobservacoes", MySqlDbType.VarChar).Value = parPets.Observ;
                    //_comandoSql.Parameters.Add("@espid", MySqlDbType.Int32).Value = parPets.Especie;
                    _comandoSql.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
            public void atualizar(PetsModel parPets)
            {
                try
                {
                    _comandoSql = new MySqlCommand();
                    _comandoSql.Connection = _conexaoPets;
                _comandoSql.CommandText =
                    "UPDATE animais " +
                    "  SET aninome = @aninome," +
                    "      aniapelido = @aniapelido," +
                    "      anidatanasc = @anidatanasc," +
                    "      aniobservacoes = @aniobservacoes " +  
                    "WHERE aniid = @aniid";


                _comandoSql.Parameters.Add("@aniid", MySqlDbType.Int32).Value = parPets.Codigo;
                    _comandoSql.Parameters.Add("@aninome", MySqlDbType.VarChar).Value = parPets.Nome;
                    _comandoSql.Parameters.Add("@aniapelido", MySqlDbType.VarChar).Value = parPets.Apelido;
                    _comandoSql.Parameters.Add("@anidatanasc", MySqlDbType.DateTime).Value = parPets.Datanasc;
                    _comandoSql.Parameters.Add("@aniobservacoes", MySqlDbType.VarChar).Value = parPets.Observ;
                    //_comandoSql.Parameters.Add("@espid", MySqlDbType.Int32).Value = parPets.Especie;
                    _comandoSql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            public void excluir(int parCodigoPet)
            {
                try
                {
                    _comandoSql = new MySqlCommand();
                    _comandoSql.Connection = _conexaoPets;
                    _comandoSql.CommandText =
                        "DELETE FROM animais WHERE aniid = @aniid";

                    _comandoSql.Parameters.AddWithValue("@aniid", parCodigoPet);
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
                    _comandoSql.Connection = _conexaoPets;
                    _comandoSql.CommandText =
                        "SELECT aniid, aninome, aniapelido, anidatanasc, aniobservacoes, espid" +
                        "FROM animais" +
                        "ORDER BY aninome ASC";

                    tabela = new DataTable();
                    adaptador = new MySqlDataAdapter(_comandoSql);
                    adaptador.Fill(tabela);

                    return tabela;

                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }

            }

            public List<PetsModel> listarTodosArray()
            {
                List<PetsModel> lista = new List<PetsModel>();
                MySqlDataReader leitor;

                try
                {
                    _comandoSql = new MySqlCommand();
                    _comandoSql.Connection = _conexaoPets;
                    _comandoSql.CommandText =
                        "SELECT aniid, aninome, aniapelido, anidatanasc, aniobservacoes, espid" +
                        "  FROM animais" +
                        "  ORDER BY aninome ASC";
                    leitor = _comandoSql.ExecuteReader();

                    while (leitor.Read())
                    {
                       
                        PetsModel item = new PetsModel();
                        item.Codigo = Convert.ToInt32(leitor["aniid"]);
                        item.Nome = leitor["aninome"].ToString();
                        item.Apelido = leitor["aniapelido"].ToString();
                        item.Datanasc = Convert.ToDateTime(leitor["anidatanasc"]);
                        item.Observ = leitor["aniobservacoes"].ToString();
                        item.Especie = Convert.ToString(leitor["espid"]);

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

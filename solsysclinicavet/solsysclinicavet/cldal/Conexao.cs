using System.Data;
using System;
using MySql.Data.MySqlClient;

namespace cldal
{
    public class Conexao
    {
        private MySqlConnection _conexao;
        private MySqlCommand _comandosql;
        private String _stringConexao = "Server=localhost;Database=dbclinicavet;User=root;Password=;";

        public MySqlConnection? ObterConexao()
        {
            try
            {
                _conexao = new MySqlConnection(_stringConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }

        
        }

        public void FecharConexao(MySqlConnection parConexao)
        {
            try 
            {
                if (parConexao != null)
                {
                    if(parConexao.State == ConnectionState.Open)
                    {
                        parConexao.Close();
                    }
                }
            } 
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        public static implicit operator Conexao(MySqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}
using MySql.Data.MySqlClient;

namespace clinica_app
{
    public static class Conexao
    {
        private static string conexaoString = "server=localhost;database=clinica_app;uid=root;pwd=;";

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoString);
            return conexao;
        }
       
    }
}
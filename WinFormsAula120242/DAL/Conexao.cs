using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAula120242.DAL
{
    internal class Conexao
    {
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ConnectionString = "Server=localhost;Database=treino;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=sa;Password=Ad#1an01;Encrypt=False"
            };

            SqlConnection? conexao = null;
            try
            {
                conexao = new SqlConnection(builder.ConnectionString);
                conexao.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return conexao;
        }
    }
}

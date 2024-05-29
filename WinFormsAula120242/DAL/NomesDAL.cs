using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAula120242.DTO;

namespace WinFormsAula120242.DAL
{
    internal class NomesDAL
    {
        public bool CadastrarDados(NomesDTO objetoNomes)
        {
            SqlConnection? conexao = null;
            SqlCommand? comando = null;
            try
            {
                conexao = Conexao.GetConnection();

                if(conexao.State == ConnectionState.Open)
                {
                    string declaracao = $"insert into nomes (nome, email, telefone) values ('{objetoNomes.Nome}', '{objetoNomes.Email}', '{objetoNomes.Telefone}')";
                    comando = new SqlCommand(declaracao, conexao);
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            { 
                return false;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }
            return true;
        }
    }
}

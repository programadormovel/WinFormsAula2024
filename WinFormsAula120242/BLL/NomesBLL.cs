using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAula120242.DAL;
using WinFormsAula120242.DTO;

namespace WinFormsAula120242.BLL
{
    internal class NomesBLL
    {
        /**
         * Aula de .NET 
         * 
         */

        public int CadastrarDados(NomesDTO objetoNomes)
        {
            int retornoDeSucesso = 1;
            int retornoDeFalha = 0;

            // Validações
            if (objetoNomes == null || objetoNomes.Nome == null || objetoNomes.Nome.Equals(""))
            {
                return retornoDeFalha;
            }

            // TODO - Validação para email e telefone

            NomesDAL nomesDAL = new NomesDAL();
            bool retorno = nomesDAL.CadastrarDados(objetoNomes);
            if (!retorno)
            {
                return retornoDeFalha;
            }

            return retornoDeSucesso;
        }
    }
}

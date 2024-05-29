using WinFormsAula120242.BLL;
using WinFormsAula120242.DTO;
using WinFormsAula120242.Util;

namespace WinFormsAula120242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nomeRecebido = txtNome.Text.Trim();
            var emailRecebido = txtEmail.Text.Trim();
            var telefoneRecebido = txtTelefone.Text.Trim();

            // TODO - Validacoes
            if (!Validacao.validarNome(nomeRecebido))
            {
                MessageBox.Show("Nome não cadastrado!");
                return;
            }

            if(!string.IsNullOrEmpty(nomeRecebido) && !lstNomes.Items.Contains(nomeRecebido) && !string.IsNullOrEmpty(emailRecebido))
            {
                NomesDTO objetoNomes = new NomesDTO()
                {
                    Nome = nomeRecebido,
                    Email = emailRecebido,
                    Telefone = telefoneRecebido
                };
                NomesBLL nomesBLL = new NomesBLL();
                int retorno = nomesBLL.CadastrarDados(objetoNomes);

                if(retorno == 0)
                {
                    MessageBox.Show("Nome não cadastrado!");
                } else if(retorno == 1)
                {
                    lstNomes.Items.Add(nomeRecebido);
                }
            }
        }

        
    }
}

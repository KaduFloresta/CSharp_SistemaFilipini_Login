using System;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        // Botão de acesso a tela Cadastro do Usuário
        // Nível de Acesso (Usuário Proprietário)
        private void btn_CadastroClick(object sender, EventArgs e)
        {
            Cadastro cadastroClick = new Cadastro(this);
            cadastroClick.Show();
        }

        // Botão de acesso a tela de Vendas
        // Nível de Acesso (Usuário Proprietário e Funcionário)
        private void btn_VendasClick(object sender, EventArgs e)
        {
            
            // if (usuario.TipoUsuario == "Proprietário")
            // {
            //     MessageBox.Show("Acesso Concedido!");
            // }
            // else
            // {
            //     MessageBox.Show("Acesso Negado!");
            // }
        }

        // Botão de acesso a tela de Compras
        // Nível de Acesso (Usuário Proprietário)
        private void btn_ComprasClick(object sender, EventArgs e)
        {
            // if (usuario.TipoUsuario == "Proprietário"
            // && usuario.TipoUsuario == "Fornecedor")
            // {
            //     MessageBox.Show("Acesso Concedido!");
            // }
            // else
            // {
            //     MessageBox.Show("Acesso Negado!");
            // }
        }

        // Botão de acesso a tela de Relatórios 
        // Nível de Acesso (Usuário Proprietário)
        private void btn_RelatoriosClick(object sender, EventArgs e)
        {
            // if (usuario.TipoUsuario == "Proprietário")
            // {
            //     MessageBox.Show("Acesso Concedido!");
            // }
            // else
            // {
            //     MessageBox.Show("Acesso Negado!");
            // }
        }

        // Botão Sair
        private void btn_MenuSairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

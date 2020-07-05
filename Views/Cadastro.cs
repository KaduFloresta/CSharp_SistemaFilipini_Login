using System;
using Models;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class Cadastro : Form
    {
        public Cadastro(Form parent)
        {
            InitializeComponent(parent);
        }

        // Botão de acesso a tela Cadastro do Usuário
        // Nível de Acesso (Usuário Proprietário e Funcionário)
        private void btn_ClientesClick(object sender, EventArgs e)
        {
            // if (usuario.TipoUsuario != "Fornecedor")
            // {
            //     MessageBox.Show("Acesso Concedido!");
            // }
            // else
            // {
            //     MessageBox.Show("Acesso Negado!");
            // }
        }

        // Botão de acesso a tela Cadastro de Produtos
        // Nível de Acesso (Usuário Proprietário e Funcionário)
        private void btn_ProdutosClick(object sender, EventArgs e)
        {
            // if (usuario.TipoUsuario != "Fornecedor")
            // {
            //     MessageBox.Show("Acesso Concedido!");
            // }
            // else
            // {
            //     MessageBox.Show("Acesso Negado!");
            // }
        }

        // Botão de acesso a tela Cadastro de Fornecedores
        // Nível de Acesso (Usuário Proprietário)
        private void btn_FornecedoresClick(object sender, EventArgs e)
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

        // Botão de acesso a tela Cadastro de Usuários
        // Nível de Acesso (Usuário Proprietário)
        private void btn_UsuariosClick(object sender, EventArgs e)
        {
            CadastroLogin cadastroClick = new CadastroLogin(this);
            cadastroClick.Show();
        }

        // Botão de acesso a tela com a Lista de Usuários (CRUD)
        // Nível de Acesso (Usuário Proprietário)
        private void btn_ListaUsuariosClick(object sender, EventArgs e)
        {
            ListaUsuario listaUsuarioClick = new ListaUsuario(this);
            listaUsuarioClick.Show();
        }

        // Botão Sair
        private void btn_MenuSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
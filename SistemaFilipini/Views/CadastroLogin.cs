using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class CadastroLogin : Form
    {
        // Tentativa para distinguir Cadastro e ALteração
        UsuarioModels usuario;
        public CadastroLogin(Form parent, int id = 0)
        {
            try
            {
                usuario = UsuarioController.GetUsuario(id);
            }
            catch
            {

            }
            InitializeComponent(parent, id > 0);
        }

        // Botão Confirma Cadastro ou Alteração do Usuário
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if (Controllers.UsuarioController.CamposPreenchidosCadastroUsuario(txt_NomeCompleto.Text, txt_Usuario.Text, txt_Senha.Text, txt_ConfirmarSenha.Text, cb_Tipo.Text))
                {
                    if (Controllers.UsuarioController.ConfirmarSenhasIguais(txt_Senha.Text, txt_ConfirmarSenha.Text))
                    {
                        if (usuario == null)
                        {
                            UsuarioController.CadastrarUsuario(
                            txt_NomeCompleto.Text,
                            txt_Usuario.Text,
                            txt_Senha.Text,
                            cb_Tipo.Text == "Usuário Proprietário"
                                ? "Proprietario"
                                : cb_Tipo.Text == "Usuário Funcionário"
                                    ? "Funcionario"
                                    : "Fornecedor"
                            );
                            MessageBox.Show("Cadastrado Com Sucesso!");
                        }
                        else
                        {
                            UsuarioController.AlterarUsuario(
                            usuario.IdUsuario,
                            txt_NomeCompleto.Text,
                            txt_Usuario.Text,
                            txt_Senha.Text,
                            cb_Tipo.Text == "Usuário Proprietário"
                                ? "Proprietario"
                                : cb_Tipo.Text == "Usuário Funcionário"
                                    ? "Funcionario"
                                    : "Fornecedor"
                           );
                            MessageBox.Show("Alterado Com Sucesso!");

                        }
                        this.Close();
                        this.parent.Show();
                    }
                    else
                    {
                        MessageBox.Show("As Senhas São Diferentes!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
            }
        }

        // Botão Cancelar Cadastro
        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para preencher campos para alteração
        private void LoadForm(object sender, EventArgs e)
        {
            this.txt_NomeCompleto.Text = usuario.NomeCompleto;
            this.txt_Usuario.Text = usuario.UsuarioLogin;
            this.txt_Senha.Text = usuario.Senha;
            this.cb_Tipo.SelectedValue = usuario.TipoUsuario;
        }
    }
}
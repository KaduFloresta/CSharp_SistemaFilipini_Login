using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace SistemaFilipini
{
    public partial class CadastroLogin : Form
    {
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

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((txt_NomeCompleto.Text != string.Empty)
                && (txt_Usuario.Text != string.Empty)
                && (txt_Senha.Text != string.Empty)
                && (cb_Tipo.Text != string.Empty))
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
                    UsuarioController.UpdateUsuario(
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
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.txt_NomeCompleto.Text = usuario.NomeCompleto;
            this.txt_Usuario.Text = usuario.UsuarioLogin;
            this.txt_Senha.Text = usuario.Senha;
            this.cb_Tipo.SelectedValue = usuario.TipoUsuario;
        }
    }
}
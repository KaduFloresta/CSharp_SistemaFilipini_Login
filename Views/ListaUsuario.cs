using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace SistemaFilipini
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario(Form parent)
        {
            InitializeComponent(parent);
        }

        private void btn_ListaConsultaClick(object sender, EventArgs e)
        {
            int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
            UsuarioModels usuario = UsuarioController.GetUsuario(IdUsuario);
            MessageBox.Show(
            $"---[ Dados do Usuário ]---------------------------\n" +
            $"Nome Completo: {usuario.NomeCompleto}\n" +
            $"Login: {usuario.UsuarioLogin}\n" +
            $"Senha: {usuario.Senha}\n" +
            $"Tipo de Usuário: {usuario.TipoUsuario}\n" +
            $"-------------------------------------------------------\n",
            "Consulta Cliente",
            MessageBoxButtons.OK
            );
        }

        private void btn_ListaAlterarClick(object sender, EventArgs e)
        {
            int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
            CadastroLogin btn_UpdateUsuarioClick = new CadastroLogin(this, IdUsuario);
            btn_UpdateUsuarioClick.Show();
        }

        private void btn_ListaDeletarClick(object sender, EventArgs e)
        {
            int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
            DialogResult result = MessageBox.Show("Deseja Exluir Esse Usuário?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    UsuarioController.DeleteUsuario(IdUsuario);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ListaSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
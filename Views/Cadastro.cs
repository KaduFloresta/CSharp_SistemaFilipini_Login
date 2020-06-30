using System;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class Cadastro : Form
    {
        public Cadastro(Form parent)
        {
            InitializeComponent(parent);
        }

        private void btn_UsuariosClick(object sender, EventArgs e)
        {
            CadastroLogin cadastroClick = new CadastroLogin(this);
            cadastroClick.Show();
        }

        private void btn_MenuSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
using System;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class Login : Form
    {
        public Login(Form parent)
        {
            InitializeComponent(parent);
        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
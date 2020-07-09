using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaFilipini
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Solicitando o login dentro da MAIN
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        public class Login : Form
        {
            // public bool logado = false;
            // public static string usuarioConectado;
            Library.GroupBox lbl_DadosUsuario;
            Library.Label lbl_Usuario;
            Library.Label lbl_Senha;
            Library.TextBox txt_Usuario;
            Library.TextBox txt_Senha;
            Library.Button btn_OK;
            Library.Button btn_Sair;
            // Dados de entrada do Login do Usuário
            public Login()
            {
                // Parêmetros da janela de login
                this.Text = "Login";
                this.BackColor = Color.LightGray;
                this.Font = new Font(this.Font, FontStyle.Bold);
                this.Size = new Size(400, 270);

                // Componentes da Janela
                this.lbl_Usuario = new Library.Label();
                this.lbl_Usuario.Text = "Usuário:";
                this.lbl_Usuario.Location = new Point(90, 40);
                this.Controls.Add(lbl_Usuario);

                this.txt_Usuario = new Library.TextBox();
                this.txt_Usuario.Location = new Point(90, 60);
                this.Controls.Add(txt_Usuario);

                this.lbl_Senha = new Library.Label();
                this.lbl_Senha.Text = "Senha :";
                this.lbl_Senha.Location = new Point(90, 100);
                this.Controls.Add(lbl_Senha);

                this.txt_Senha = new Library.TextBox();
                this.txt_Senha.Location = new Point(90, 120);
                this.Controls.Add(txt_Senha);

                this.btn_OK = new Library.Button();
                this.btn_OK.Text = "OK";
                this.btn_OK.Location = new Point(50, 160);
                this.btn_OK.BackColor = Color.Green;
                this.btn_OK.ForeColor = Color.Black;
                this.btn_OK.Click += new EventHandler(this.btn_OKClick);
                this.Controls.Add(btn_OK);

                this.btn_Sair = new Library.Button();
                this.btn_Sair.Text = "SAIR";
                this.btn_Sair.Location = new Point(210, 160);
                this.btn_Sair.BackColor = Color.Red;
                this.btn_Sair.ForeColor = Color.Black;
                this.btn_Sair.Click += new EventHandler(this.btn_SairClick);
                this.Controls.Add(btn_Sair);

                this.lbl_DadosUsuario = new Library.GroupBox();
                this.lbl_DadosUsuario.Location = new Point(10, 10);
                this.lbl_DadosUsuario.Text = "Dados do Usuário";
                this.Controls.Add(lbl_DadosUsuario);
            }

            // Botão de confirmação do Login
            private void btn_OKClick(object sender, EventArgs e)
            {
                try
                {
                    // Salva no usuario do form o usuario ue foi pesuisado no banco
                    Models.UsuarioModels usuario = Models.UsuarioModels.ValidaUsuario(txt_Usuario.Text, txt_Senha.Text);
                    new TelaPrincipal(usuario).Show();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            // Botão Sair do Login
            private void btn_SairClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}
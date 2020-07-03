using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaFilipini
{
    partial class Login : Form
    {
        Library.GroupBox lbl_DadosUsuario;
        Library.Label lbl_Nome;
        Library.Label lbl_Usuario;
        Library.TextBox txt_NomeCompleto;
        Library.TextBox txt_Usuario;
        Library.Button btn_Confirmar;
        Form parent;

        // Customer data entry
        public void InitializeComponent(Form parent)
        {
            this.Text = "Login";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 270);
            this.parent = parent;

            this.lbl_Nome = new Library.Label();
            this.lbl_Nome.Text = "Usuário:";
            this.lbl_Nome.Location = new Point(90, 40);
            this.Controls.Add(lbl_Nome);

            this.txt_NomeCompleto = new Library.TextBox();
            this.txt_NomeCompleto.Location = new Point(90, 60);
            this.Controls.Add(txt_NomeCompleto);

            this.lbl_Usuario = new Library.Label();
            this.lbl_Usuario.Text = "Senha :";
            this.lbl_Usuario.Location = new Point(90, 100);
            this.Controls.Add(lbl_Usuario);

            this.txt_Usuario = new Library.TextBox();
            this.txt_Usuario.Location = new Point(90, 120);
            this.Controls.Add(txt_Usuario);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "OK";
            this.btn_Confirmar.Location = new Point(130, 160);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.lbl_DadosUsuario = new Library.GroupBox();
            this.lbl_DadosUsuario.Location = new Point(10, 10);
            this.lbl_DadosUsuario.Text = "Dados do Usuário";
            this.Controls.Add(lbl_DadosUsuario);

        }
    }
}
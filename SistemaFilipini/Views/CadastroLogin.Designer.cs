using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaFilipini
{
    partial class CadastroLogin : Form
    {
        Library.Label lbl_Nome;
        Library.Label lbl_Usuario;
        Library.Label lbl_Senha;
        Library.Label lbl_ConfirmaSenha;
        Library.Label lbl_Tipo;
        Library.TextBox txt_NomeCompleto;
        Library.TextBox txt_Usuario;
        Library.TextBox txt_Senha;
        Library.TextBox txt_ConfirmarSenha;
        ComboBox cb_Tipo;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            // Parêmetros da janela Cadastro Usuário
            this.Text = "Cadastro Usuário";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 300);
            this.parent = parent;

            // Tratativa para evento do LoadForm (Alterção) 
            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            // Componentes da janela
            this.lbl_Nome = new Library.Label();
            this.lbl_Nome.Text = "Nome Completo:";
            this.lbl_Nome.Location = new Point(20, 20);
            this.Controls.Add(lbl_Nome);

            this.txt_NomeCompleto = new Library.TextBox();
            this.txt_NomeCompleto.Location = new Point(150, 20);
            this.Controls.Add(txt_NomeCompleto);

            this.lbl_Usuario = new Library.Label();
            this.lbl_Usuario.Text = "Usuário :";
            this.lbl_Usuario.Location = new Point(20, 50);
            this.Controls.Add(lbl_Usuario);

            this.txt_Usuario = new Library.TextBox();
            this.txt_Usuario.Location = new Point(150, 50);
            this.Controls.Add(txt_Usuario);

            this.lbl_Senha = new Library.Label();
            this.lbl_Senha.Text = "Senha :";
            this.lbl_Senha.Location = new Point(20, 80);
            this.Controls.Add(lbl_Senha);

            this.txt_Senha = new Library.TextBox();
            this.txt_Senha.Location = new Point(150, 80);
            this.Controls.Add(txt_Senha);

            this.lbl_ConfirmaSenha = new Library.Label();
            this.lbl_ConfirmaSenha.Text = "Confirmar Senha :";
            this.lbl_ConfirmaSenha.Location = new Point(20, 110);
            this.Controls.Add(lbl_ConfirmaSenha);

            this.txt_ConfirmarSenha = new Library.TextBox();
            this.txt_ConfirmarSenha.Location = new Point(150, 110);
            this.Controls.Add(txt_ConfirmarSenha);

            this.lbl_Tipo = new Library.Label();
            this.lbl_Tipo.Text = "Tipo de Usuário :";
            this.lbl_Tipo.Location = new Point(20, 140);
            this.Controls.Add(lbl_Tipo);

            this.cb_Tipo = new ComboBox();
            this.cb_Tipo.Items.Add("Usuário Proprietário");
            this.cb_Tipo.Items.Add("Usuário Funcionário");
            this.cb_Tipo.Items.Add("Usuário Fornecedor");
            this.cb_Tipo.AutoCompleteMode = AutoCompleteMode.Append;
            this.cb_Tipo.Location = new Point(150, 140);
            this.cb_Tipo.Size = new Size(200, 20);
            this.Controls.Add(cb_Tipo);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(60, 190);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(200, 190);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}
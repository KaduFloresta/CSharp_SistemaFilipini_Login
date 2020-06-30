using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaFilipini
{
    partial class Cadastro : Form
    {
        Library.Button btn_Cientes;
        Library.Button btn_Produtos;
        Library.Button btn_Fornecedores;
        Library.Button btn_Usuarios;
        Library.Button btn_MenuSair;
        Form parent;

        // Customer data entry
        public void InitializeComponent(Form parent)
        {
            this.Text = "Cadastro";
            this.BackColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 300);
            this. parent = parent;

            this.btn_Cientes = new Library.Button();
            this.btn_Cientes.Location = new Point(40, 50);
            this.btn_Cientes.Text = "CLIENTES";
            this.Controls.Add(btn_Cientes);
            //this.btn_Cientes.Click += new EventHandler(btn_CientesClick);

            this.btn_Produtos = new Library.Button();
            this.btn_Produtos.Location = new Point(220, 50);
            this.btn_Produtos.Text = "PRODUTOS";
            this.Controls.Add(btn_Produtos);
            //this.btn_Produtos.Click += new EventHandler(btn_ProdutosClick);

            this.btn_Fornecedores = new Library.Button();
            this.btn_Fornecedores.Location = new Point(40, 120);
            this.btn_Fornecedores.Text = "FORNECEDORES";
            this.Controls.Add(btn_Fornecedores);
            //this.btn_Fornecedores.Click += new EventHandler(btn_FornecedoresClick);

            this.btn_Usuarios = new Library.Button();
            this.btn_Usuarios.Location = new Point(220, 120);
            this.btn_Usuarios.Text = "USUÁRIOS";
            this.Controls.Add(btn_Usuarios);
            this.btn_Usuarios.Click += new EventHandler(btn_UsuariosClick);

            this.btn_MenuSair = new Library.Button();
            this.btn_MenuSair.Location = new Point(130, 190);
            this.btn_MenuSair.Text = "SAIR";
            this.Controls.Add(btn_MenuSair);
            this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
        }
    }
}
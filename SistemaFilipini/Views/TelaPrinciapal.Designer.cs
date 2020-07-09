using System;
using Models;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaFilipini
{
    partial class TelaPrincipal : Form
    {
        Library.PictureBox pb_Cadastro;
        Library.Button btn_Cadastro;
        Library.Button btn_Vendas;
        Library.Button btn_Compras;
        Library.Button btn_Relatorios;
        Library.Button btn_MenuSair;

        public void InitializeComponent()
        {
            // Parêmetros da janela principal do sistema
            this.Text = "SISTEMA FILIPINI";
            this.BackColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 320);

            // Componentes da janela
            // Abaixo, inserindo a imagem na janela
            this.pb_Cadastro = new Library.PictureBox();
            this.pb_Cadastro.Load($"./Views/assets/embutidos.jpg");
            this.Controls.Add(pb_Cadastro);

            this.btn_Cadastro = new Library.Button();
            this.btn_Cadastro.Location = new Point(40, 90);
            this.btn_Cadastro.Text = "CADASTRO";
            this.Controls.Add(btn_Cadastro);
            this.btn_Cadastro.Click += new EventHandler(btn_CadastroClick);

            this.btn_Vendas = new Library.Button();
            this.btn_Vendas.Location = new Point(220, 90);
            this.btn_Vendas.Text = "VENDAS";
            this.Controls.Add(btn_Vendas);
            this.btn_Vendas.Click += new EventHandler(btn_VendasClick);

            this.btn_Compras = new Library.Button();
            this.btn_Compras.Location = new Point(40, 150);
            this.btn_Compras.Text = "COMPRAS";
            this.Controls.Add(btn_Compras);
            this.btn_Compras.Click += new EventHandler(btn_ComprasClick);

            this.btn_Relatorios = new Library.Button();
            this.btn_Relatorios.Location = new Point(220, 150);
            this.btn_Relatorios.Text = "RELATÓRIOS";
            this.Controls.Add(btn_Relatorios);
            this.btn_Relatorios.Click += new EventHandler(btn_RelatoriosClick);


            this.btn_MenuSair = new Library.Button();
            this.btn_MenuSair.Location = new Point(130, 210);
            this.btn_MenuSair.Text = "SAIR";
            this.Controls.Add(btn_MenuSair);
            this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);

        }
    }
}

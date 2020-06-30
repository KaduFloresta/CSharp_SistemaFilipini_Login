using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaFilipini
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }

        public class TelaPrincipal : Form
        {
            Library.Button btn_Cadastro;
            Library.Button btn_Vendas;
            Library.Button btn_Compras;
            Library.Button btn_Relatorios;
            Library.Button btn_MenuSair;

            public TelaPrincipal()
            {
                this.Text = "SISTEMA FILIPINI";
                this.BackColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Bold);
                this.Size = new Size(400, 300);
     
                this.btn_Cadastro = new Library.Button();
                this.btn_Cadastro.Location = new Point(40, 50);
                this.btn_Cadastro.Text = "CADASTRO";
                this.Controls.Add(btn_Cadastro);
                this.btn_Cadastro.Click += new EventHandler(btn_CadastroClick);

                this.btn_Vendas = new Library.Button();
                this.btn_Vendas.Location = new Point(220, 50);
                this.btn_Vendas.Text = "VENDAS";
                this.Controls.Add(btn_Vendas);
                this.btn_Vendas.Click += new EventHandler(btn_VendasClick);

                this.btn_Compras = new Library.Button();
                this.btn_Compras.Location = new Point(40, 120);
                this.btn_Compras.Text = "COMPRAS";
                this.Controls.Add(btn_Compras);
                //this.btn_Compras.Click += new EventHandler(btn_ComprasClick);

                this.btn_Relatorios = new Library.Button();
                this.btn_Relatorios.Location = new Point(220, 120);
                this.btn_Relatorios.Text = "RELATÓRIOS";
                this.Controls.Add(btn_Relatorios);
                //this.btn_Relatorios.Click += new EventHandler(btn_RelatoriosClick);

                this.btn_MenuSair = new Library.Button();
                this.btn_MenuSair.Location = new Point(130, 190);
                this.btn_MenuSair.Text = "SAIR";
                this.Controls.Add(btn_MenuSair);
                this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
            }

            private void btn_CadastroClick(object sender, EventArgs e)
            {
                Cadastro cadastroClick = new Cadastro(this);
                cadastroClick.Show();
            }

            private void btn_VendasClick(object sender, EventArgs e)
            {
                // Usando o Botão Vendas para testar a interface de Login
                Login vendasClick = new Login(this);
                vendasClick.Show();
            }

            private void btn_ComprasClick(object sender, EventArgs e)
            {
                // CadastroLogin cadastrarClienteClick = new CadastroLogin(this);
                // cadastrarClienteClick.Show();
            }

            private void btn_RelatoriosClick(object sender, EventArgs e)
            {
                // CadastroLogin cadastrarClienteClick = new CadastroLogin(this);
                // cadastrarClienteClick.Show();
            }

            // Method to close system
            private void btn_MenuSairClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}

using System;
using Models;
using Controllers;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SistemaFilipini
{
    partial class ListaUsuario : Form
    {
        Library.ListView lv_ListaUsuarios;
        Library.Button btn_ListaConsulta;
        Library.Button btn_ListaAlterar;
        Library.Button btn_ListaDeletar;
        Library.Button btn_ListaSair;
        Form parent;
        
        public void InitializeComponent(Form parent)
        {
            // Parêmetros da janela Lista de Usuários
            this.Text = "Lista Usuários";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 380);
            this.parent = parent;

            // Componentes da janela
            this.lv_ListaUsuarios = new Library.ListView();
            this.lv_ListaUsuarios.Location = new Point(10, 10);
            this.lv_ListaUsuarios.Size = new Size(350, 200);
            ListViewItem usuarios = new ListViewItem();
            List<UsuarioModels> usuariosLista = UsuarioController.GetUsuarios();
            foreach (var usuario in usuariosLista)
            {
                ListViewItem lv_ListaUsuario = new ListViewItem(usuario.IdUsuario.ToString());
                lv_ListaUsuario.SubItems.Add(usuario.NomeCompleto);
                lv_ListaUsuario.SubItems.Add(usuario.UsuarioLogin);
                lv_ListaUsuario.SubItems.Add(usuario.Senha);
                lv_ListaUsuario.SubItems.Add(usuario.TipoUsuario.ToString());
                lv_ListaUsuarios.Items.Add(lv_ListaUsuario);
            }
            this.lv_ListaUsuarios.MultiSelect = false;
            this.lv_ListaUsuarios.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaUsuarios.Columns.Add("Usuário", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Senha", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Tipo de Usuário", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaUsuarios);

            // 3 Botões de acesso ao CRUD dentro da Lista
            // Consulta (Read), Altera (Update) e Deleta (Delete)
            this.btn_ListaConsulta = new Library.Button();
            this.btn_ListaConsulta.Location = new Point(30, 230);
            this.btn_ListaConsulta.Size = new Size(150, 30);
            this.btn_ListaConsulta.BackColor = Color.LightBlue;
            this.btn_ListaConsulta.ForeColor = Color.Black;
            this.btn_ListaConsulta.Text = "CONSULTA";
            this.Controls.Add(btn_ListaConsulta);
            this.btn_ListaConsulta.Click += new EventHandler(btn_ListaConsultaClick);

            this.btn_ListaAlterar = new Library.Button();
            this.btn_ListaAlterar.Location = new Point(200, 230);
            this.btn_ListaAlterar.Size = new Size(150, 30);
            this.btn_ListaAlterar.BackColor = Color.Yellow;
            this.btn_ListaAlterar.ForeColor = Color.Black;
            this.btn_ListaAlterar.Text = "ALTERA";
            this.Controls.Add(btn_ListaAlterar);
            this.btn_ListaAlterar.Click += new EventHandler(btn_ListaAlterarClick);

            this.btn_ListaDeletar = new Library.Button();
            this.btn_ListaDeletar.Location = new Point(30, 280);
            this.btn_ListaDeletar.Size = new Size(150, 30);
            this.btn_ListaDeletar.BackColor = Color.Red;
            this.btn_ListaDeletar.ForeColor = Color.Black;
            this.btn_ListaDeletar.Text = "DELETA";
            this.Controls.Add(btn_ListaDeletar);
            this.btn_ListaDeletar.Click += new EventHandler(btn_ListaDeletarClick);

            this.btn_ListaSair = new Library.Button();
            this.btn_ListaSair.Location = new Point(200, 280);
            this.btn_ListaSair.Size = new Size(150, 30);
            this.btn_ListaSair.BackColor = Color.Green;
            this.btn_ListaSair.ForeColor = Color.Black;
            this.btn_ListaSair.Text = "SAIR";
            this.btn_ListaSair.Click += new EventHandler(btn_ListaSairClick);
            this.Controls.Add(btn_ListaSair);
        }
    }
}
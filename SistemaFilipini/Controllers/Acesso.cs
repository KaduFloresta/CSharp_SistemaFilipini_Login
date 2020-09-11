using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class AcessoController
    {
        // Métodos de acesso aos botões 
        public static bool Acesso_TelaCadastro(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario != "Fornecedor")
            {
                return false;
            }
            return true;
        }

        public static bool Acesso_TelaCadastroClientes(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario != "Fornecedor")
            {
                return false;
            }
            return true;
        }

         public static bool Acesso_TelaCadastroProdutos(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario != "Fornecedor")
            {
                return false;
            }
            return true;
        }

         public static bool Acesso_TelaCadastroFornecedores(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario == "Proprietario")
            {
                return false;
            }
            return true;
        }

         public static bool Acesso_TelaCadastroUsuario(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario == "Proprietario")
            {
                return false;
            }
            return true;
        }

        public static bool AcessoTela_Vendas(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario != "Fornecedor")
            {
                return false;
            }
            return true;
        }

        public static bool AcessoTela_Compras(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario != "Funcionario")
            {
                return false;
            }
            return true;
        }

        public static bool AcessoTela_Relatorios(Models.UsuarioModels usuario, string TipoUsuario)
        {
            if (usuario.TipoUsuario == "Proprietario")
            {
                return false;
            }
            return true;
        }
    }
}
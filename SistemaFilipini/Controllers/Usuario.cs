using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class UsuarioController
    {
        // Inserindo usuário no banco de dados
        public static void CadastrarUsuario(
            string nomeCompleto,
            string usuarioLogin,
            string senha,
            string tipoUsuario
            )
        {
            new UsuarioModels(
                nomeCompleto,
                usuarioLogin,
                senha,
                tipoUsuario);
        }

        // Acessando usuário no BD pelo ID
        public static UsuarioModels GetUsuario(int idUsuario)
        {
            return UsuarioModels.GetUsuario(idUsuario);
        }

        // Acessando todos usuários
        public static List<UsuarioModels> GetUsuarios()
        {
            return UsuarioModels.GetUsuarios();
        }

        // Acessando o método de alteração
        public static void AlterarUsuario(
            int idUsuario,
            string nomeCompleto,
            string usuarioLogin,
            string senha,
            string tipoUsuario
            )
        {
            UsuarioModels.AlterarUsuario(
            idUsuario,
            nomeCompleto,
            usuarioLogin,
            senha,
            tipoUsuario
            );
        }

        // Acessando o método de deleção
        public static void DeletarUsuario(int idUsuario)
        {
            UsuarioModels.DeletarUsuario(idUsuario);
        }

        public static bool ConfirmarSenhasIguais(string senha1, string senha2)
        {
            if (senha1 == senha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CamposPreenchidosCadastroUsuario(
            string nomeCompleto,
            string usuario,
            string senha,
            string confirmarSenha,
            string tipo)
        {
            if ((nomeCompleto == string.Empty)
                || (usuario == string.Empty)
                || (senha == string.Empty)
                || (confirmarSenha == string.Empty)
                || (tipo == string.Empty))
            {
                return false;
            }
            return true;
        }
    }
}
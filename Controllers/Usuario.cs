using System;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controllers
{
    public class UsuarioController
    {
        /// <summary>
        /// Insert user into the database
        /// </summary>
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

        /// <summary>
        ///  Access to find a user by ID
        /// </summary>
        public static UsuarioModels GetUsuario(int idUsuario)
        {
            return UsuarioModels.GetUsuario(idUsuario);
        }

        /// <summary>
        /// Access all users
        /// </summary>
        public static List<UsuarioModels> GetUsuarios()
        {
            return UsuarioModels.GetUsuarios();
        }

        /// <summary>
        /// Access to Update user
        /// </summary>
        public static void UpdateUsuario(
            int idUsuario,
            string nomeCompleto,
            string usuarioLogin,
            string senha,
            string tipoUsuario
            )
        {
            UsuarioModels.UpdateUsuario(
            idUsuario,
            nomeCompleto,
            usuarioLogin,
            senha,
            tipoUsuario
            );
        }

        /// <summary>
        /// Access to Delete user
        /// </summary>
        public static void DeleteUsuario(int idUsuario)
        {
            UsuarioModels.DeleteUsuario(idUsuario);
        }
    }
}
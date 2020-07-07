using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class LoginController
    {
        // Métodos se os campos estiverem vazios
        public static bool CamposPreenchidosLogin(string UsuarioLogin, string Senha)
        {
            if (UsuarioLogin == "" || Senha == "")
            {
                return false;
            }
            return true;
        }
    }
}
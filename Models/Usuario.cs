using System;
using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UsuarioModels
    {
        [Key] // Data Annotations - Main key
        public int IdUsuario { get; set; }
        [Required] // Mandatory data entry
        public string NomeCompleto { get; set; }
        [Required] // Mandatory data entry
        public string UsuarioLogin { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
        //public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        /// <summary>
        /// Constructor - UsuarioModels Object
        /// </summary>
        public UsuarioModels(string nomeCompleto, string usuarioLogin, string senha, string tipoUsuario)
        {
            NomeCompleto = nomeCompleto;
            UsuarioLogin = usuarioLogin;
            Senha = senha;
            TipoUsuario = tipoUsuario;
            //locacoes = new List<LocacaoModels>();

            var db = new Context();
            db.Usuarios.Add(this);
            db.SaveChanges();
        }

        /// <summary>
        /// 2nd Constructor - UsuarioModels Object
        /// Using on Entity Framework DONT REMOVE!!!
        /// </summary>
        public UsuarioModels()
        {

        }

        /// <summary>
        ///  To find a user (LinQ)
        /// </summary>
        public static UsuarioModels GetUsuario(int idUsuario)
        {
            var db = new Context();
            return (from usuario in db.Usuarios
                    where usuario.IdUsuario == idUsuario
                    select usuario).First();
        }

        /// <summary>
        /// Return customer list from DB
        /// </summary>
        public static List<UsuarioModels> GetUsuarios()
        {
            var db = new Context();
            return db.Usuarios.ToList();
        }

        /// <summary>
        /// Update user into the database
        /// </summary>
        public static void UpdateUsuario(
            int IdUsuario,
            string nomeCompleto,
            string usuarioLogin,
            string senha,
            string tipoUsuario
        )
        {
            Context db = new Context();
            try
            {UsuarioModels usuario = db.Usuarios.First(usuario => usuario.IdUsuario == IdUsuario);
                usuario.NomeCompleto = nomeCompleto;
                usuario.UsuarioLogin = usuarioLogin;
                usuario.Senha = senha;
                usuario.TipoUsuario = tipoUsuario;
                db.SaveChanges(); // Cria a transação do BD
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Delete user into the database
        /// </summary>
        public static void DeleteUsuario(int idUsuario)
        {
            Context db = new Context();
            try
            {
                UsuarioModels usuario = db.Usuarios.First(usuario => usuario.IdUsuario == idUsuario);
                db.Remove(usuario);
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
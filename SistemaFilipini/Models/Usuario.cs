using System;
using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UsuarioModels
    {
        [Key] // Data Annotations - Chave principal
        public int IdUsuario { get; set; }
        [Required] // Propriedades requeridas na classe
        public string NomeCompleto { get; set; }
        [Required]
        public string UsuarioLogin { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string TipoUsuario { get; set; }

        // Construtor do objeto UsuarioModels
        public UsuarioModels(string nomeCompleto, string usuarioLogin, string senha, string tipoUsuario)
        {
            NomeCompleto = nomeCompleto;
            UsuarioLogin = usuarioLogin;
            Senha = senha;
            TipoUsuario = tipoUsuario;

            Context db = new Context();
            db.Usuarios.Add(this);
            db.SaveChanges();
        }

        // 2º Constructor do obejto UsuarioModels
        // Usado pelo Entity Framework NÃO REMOVA!!!
        public UsuarioModels()
        {

        }

        // Método para pegar o usuário pelo ID        
        public static UsuarioModels GetUsuario(int idUsuario)
        {
            var db = new Context();
            return (from usuario in db.Usuarios
                    where usuario.IdUsuario == idUsuario
                    select usuario).First();
        }

        // Método para pegar a lista de usuários       
        public static List<UsuarioModels> GetUsuarios()
        {
            var db = new Context();
            return db.Usuarios.ToList();
        }

        // Método para alterar os dados do usuário       
        public static void AlterarUsuario(
            int IdUsuario,
            string nomeCompleto,
            string usuarioLogin,
            string senha,
            string tipoUsuario
        )
        {
            Context db = new Context();
            try
            {
                UsuarioModels usuario = db.Usuarios.First(usuario => usuario.IdUsuario == IdUsuario);
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

        // Método de deleção do usuário        
        public static void DeletarUsuario(int idUsuario)
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

        // LinQ para validar usuario dentro do BD
        public static UsuarioModels ValidaUsuario(string login, string senha)
        {
            try
            {
            Context db = new Context();
            IEnumerable<UsuarioModels> usuario = from UsuarioModels in db.Usuarios
                                                 where UsuarioModels.UsuarioLogin == login && UsuarioModels.Senha == senha
                                                 select UsuarioModels;
            return usuario.ToArray().First();
            }
            catch
            {
                throw new Exception("Usuário e/ou Senha Inválido!");
            }
        }
    }
}
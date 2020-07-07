using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using Models;

namespace Filipini.Tests
{
    [TestClass]
    public class Usuario_Tests
    {
        [TestMethod]
        public void Usuario_ConfirmacaoDeSenhaCorreta()
        {
            string senha1 = "123";
            string senha2 = "123";
            bool resultado = UsuarioController.ConfirmarSenhasIguais(senha1, senha2);
            Assert.AreEqual(resultado, true);
        }

        [TestMethod]
        public void Usuario_ConfirmacaoDeSenhaErrada()
        {
            string senha1 = "123";
            string senha2 = "456";
            bool resultado = UsuarioController.ConfirmarSenhasIguais(senha1, senha2);
            Assert.AreEqual(resultado, false);
        }

        [TestMethod]
        public void CadastroUsuario_ValidarCamposObrigatoriosPreenchidos()
        {
            string nomeCompleto = "Carlos Eduardo Floresta";
            string usuario = "KaduFloresta";
            string senha = "123";
            string confirmarSenha = "123";
            string tipo = "Proprietario";
            bool resultado = UsuarioController.CamposPreenchidosCadastroUsuario(nomeCompleto, usuario, senha, confirmarSenha, tipo);
            Assert.AreEqual(resultado, true);
        }

        [DataTestMethod]
        [DataRow("", "a", "a", "a", "a")]
        [DataRow("a", "", "a", "a", "a")]
        [DataRow("a", "a", "", "a", "a")]
        [DataRow("a", "a", "a", "", "a")]
        [DataRow("a", "a", "a", "a", "")]
        public void CadastroUsuario_ValidarCamposObrigatoriosNãoPreenchidos(
            string nomeCompleto,
            string usuario,
            string senha,
            string confirmarSenha,
            string tipo)
        {
            bool resultado = UsuarioController.CamposPreenchidosCadastroUsuario(nomeCompleto, usuario, senha, confirmarSenha, tipo);
            Assert.AreEqual(resultado, false);
        }
    }
}

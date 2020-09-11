using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using Models;

namespace Filipini.Tests
{
    [TestClass]
    public class Login_Tests
    {
        [TestMethod]
        public void Login_ValidarCamposObrigatoriosPreenchidos()
        {
            string login = "KaduFloresta";
            string senha = "123";
            bool resultado = LoginController.CamposPreenchidosLogin(login, senha);
            Assert.AreEqual(resultado, true);
        }

        [DataTestMethod]
        [DataRow("", "a")]
        [DataRow("a", "")]
        public void Login_ValidarCamposObrigatoriosNãoPreenchidos(string login, string senha)
        {
            bool resultado = LoginController.CamposPreenchidosLogin(login, senha);
            Assert.AreEqual(resultado, false);
        }
        
        // Teste de Quais os caracteres para Login
        // Teste de Quais os caracteres para Senha
        // Teste de Qtde de caracteres para Login
        // Teste de Qtde de caracteres para Senha
        // Reconhecer Letras Maísculas e minusculas do Usuário
        // Reconhecer Letras Maísculas e minusculas da Senha
    }
}

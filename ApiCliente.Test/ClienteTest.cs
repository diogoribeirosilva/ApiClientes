using ApiCliente.Domain.Models;
using ApiCliente.Domain.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiCliente.Test
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void Test_NomeObrigatorio()
        {
            Cliente clienteSemNome = new Cliente()
            {
                Nome = ""
            };
            Cliente clienteComNome = new Cliente()
            {
                Nome = "Diogo"
            };
            ClienteValidation clienteValidation2 = new ClienteValidation();
            Assert.IsTrue(clienteValidation2.ValidaNome(clienteSemNome.Nome));
          //  Assert.IsTrue(clienteValidation2.ValidaNome(clienteComNome));
        }
        [TestMethod]
        public void Test_NomeMaiorQue30Caracteres()
        {
            Cliente clienteMaiorQue30Caracteres = new Cliente()
            {
                Nome = "123123123123123123212312312312313213213213213213213213213213213333"
            };
            Cliente clienteMenorQue30Caracteres = new Cliente()
            {
                Nome = "12312312312"
            };
            ClienteValidation clienteValidation2 = new ClienteValidation();
            Assert.IsTrue(clienteValidation2.ValidaNome(clienteMaiorQue30Caracteres.Nome));
           // Assert.IsTrue(clienteValidation2.ValidaNome(clienteMenorQue30Caracteres));
        }
        [TestMethod]
        public void Test_ValidarCpf()
        {
            Cliente clienteMaiorQue30Caracteres = new Cliente()
            {
                Cpf = "12345612345"
            };
            Cliente clienteMenorQue30Caracteres = new Cliente()
            {
                Nome = ""
            };
            ClienteValidation clienteValidation2 = new ClienteValidation();
            Assert.IsTrue(clienteValidation2.ValidaNome(clienteMaiorQue30Caracteres.Cpf));
            // Assert.IsTrue(clienteValidation2.ValidaNome(clienteMenorQue30Caracteres));
        }
    }
}

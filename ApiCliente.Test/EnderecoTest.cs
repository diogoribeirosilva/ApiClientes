using ApiCliente.Domain.Models;
using ApiCliente.Domain.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiCliente.Test
{
    [TestClass]
    public class EnderecoTest
    {
        [TestMethod]
        public void Test_LogradouroObrigatorio()
        {
            Endereco enderecoSemLogradouro = new Endereco()
            {
                Logradouro = ""
            };
            Endereco enderecoComLogradouro = new Endereco()
            {
                Logradouro = "Avenida Central"
            };
            EnderecoValidation enderecoValidation = new EnderecoValidation();
            Assert.IsTrue(enderecoValidation.ValidarLogradouro(enderecoSemLogradouro.Logradouro));
        }
        [TestMethod]
        public void Test_LogradouroMaiorQue50Caracteres()
        {
            Endereco EnderecoMaiorQue50Caracteres = new Endereco()
            {
                Logradouro = "Avenida CentralAvenida CentralAvenida CentralAvenida CentralAvenida CentralAvenida Central"
            };
            Endereco EnderecoMenorQue50Caracteres = new Endereco()
            {
                Logradouro = "Avenida Central"
            };
            EnderecoValidation EnderecoValidation = new EnderecoValidation();
            Assert.IsTrue(EnderecoValidation.ValidarLogradouro(EnderecoMaiorQue50Caracteres.Logradouro));
            // Assert.IsTrue(clienteValidation2.ValidaNome(clienteMenorQue30Caracteres));
        }
        [TestMethod]
        public void Test_BairroObrigatorio()
        {
            Endereco enderecoSemBairro = new Endereco()
            {
                Bairro = ""
            };
            Endereco enderecoComBairro = new Endereco()
            {
                Bairro = "Avenida Central"
            };
            EnderecoValidation enderecoValidation = new EnderecoValidation();
            Assert.IsTrue(enderecoValidation.ValidarBairro(enderecoSemBairro.Bairro));
        }
        [TestMethod]
        public void Test_BairroMaiorQue40Caracteres()
        {
            Endereco enderecoSemBairroMaiorQue50Caracteres = new Endereco()
            {
                Bairro = "Avenida CentralAvenida CentralAvenida CentralAvenida CentralAvenida CentralAvenida Central"
            };
            Endereco bairroMenorQue50Caracteres = new Endereco()
            {
                Bairro = "Avenida Central"
            };
            EnderecoValidation EnderecoValidation = new EnderecoValidation();
            Assert.IsTrue(EnderecoValidation.ValidarBairro(enderecoSemBairroMaiorQue50Caracteres.Bairro));
            //Assert.IsFalse(EnderecoValidation.ValidarBairro(enderecoSemBairroMaiorQue50Caracteres));
        }
        [TestMethod]
        public void Test_CidadeObrigatorio()
        {
            Endereco enderecoSemCidade = new Endereco()
            {
                Cidade = ""
            };
            Endereco cidadeComCidade = new Endereco()
            {
                Cidade = "Rio de Janeiro"
            };
            EnderecoValidation enderecoValidation = new EnderecoValidation();
            Assert.IsTrue(enderecoValidation.ValidarCidade(enderecoSemCidade.Cidade));
        }
        [TestMethod]
        public void Test_CidadeMaiorQue40Caracteres()
        {
            Endereco cidadeMaiorQue50Caracteres = new Endereco()
            {
                Cidade = "Rio de Janeiro Rio de Janeiro Rio de Janeiro Rio de Janeiro Rio de Janeiro Rio de JaneiroRio de Janeiro"
            };
            Endereco cidadeMenorQue50Caracteres = new Endereco()
            {
                Cidade = "Rio de Janeiro"
            };
            EnderecoValidation EnderecoValidation = new EnderecoValidation();
            Assert.IsTrue(EnderecoValidation.ValidarCidade(cidadeMaiorQue50Caracteres.Cidade));
            // Assert.IsTrue(EnderecoValidation.ValidaNome(clienteMenorQue30Caracteres));
        }
        [TestMethod]
        public void Test_EstadoObrigatorio()
        {
            Endereco enderecoSemEstado = new Endereco()
            {
                Estado = ""
            };
            Endereco enderecoComEstado = new Endereco()
            {
                Estado = "Rio de Janeiro"
            };
            EnderecoValidation enderecoValidation = new EnderecoValidation();
            Assert.IsTrue(enderecoValidation.ValidarEstado(enderecoSemEstado.Estado));
        }
        [TestMethod]
        public void Test_EstadoMaiorQue40Caracteres()
        {
            Endereco estadoMaiorQue50Caracteres = new Endereco()
            {
                Estado = "Rio de JaneiroRio de Janeiro Rio de Janeiro Rio de Janeiro Rio de Janeiro Rio de Janeiro Rio de Janeiro"
            };
            Endereco estadoMenorQue50Caracteres = new Endereco()
            {
                Estado = "Rio de Janeiro"
            };
            EnderecoValidation EnderecoValidation = new EnderecoValidation();
            Assert.IsTrue(EnderecoValidation.ValidarEstado(estadoMaiorQue50Caracteres.Estado));
            // Assert.IsTrue(clienteValidation2.ValidaNome(clienteMenorQue30Caracteres));
        }
    }
}

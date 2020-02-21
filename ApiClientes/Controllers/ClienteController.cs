using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCliente.Application.DTO.DTO;
using ApiCliente.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApplicationService _clienteApplicationService;
        
        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            _clienteApplicationService = clienteApplicationService;
        }
  
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var results = _clienteApplicationService.GetAll();

                return Ok(results);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco Dados Falhou {ex.Message}");
            }

       }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                var result = _clienteApplicationService.GetById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco Dados Falhou {ex.Message}");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _clienteApplicationService.Add(clienteDTO);

                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $" {ex.Message}");
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _clienteApplicationService.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $" {ex.Message}");
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                var clienteDTO = _clienteApplicationService.GetById(id);
                if (clienteDTO != null)
                {
                    _clienteApplicationService.Remove(clienteDTO);
                    return Ok("Cliente Removido com sucesso!");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
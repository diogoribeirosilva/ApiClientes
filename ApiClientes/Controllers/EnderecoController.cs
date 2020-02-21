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
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public EnderecoController(IEnderecoApplicationService enderecoApplicationService)
        {
            _enderecoApplicationService = enderecoApplicationService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var results = _enderecoApplicationService.GetAll();

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

                var result = _enderecoApplicationService.GetById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Falha: {ex.Message}");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _enderecoApplicationService.Add(enderecoDTO);
                return Ok("Endereço Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Falha: {ex.Message}");
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _enderecoApplicationService.Update(enderecoDTO);
                return Ok("Endereço Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Falha: {ex.Message}");
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _enderecoApplicationService.Remove(enderecoDTO);
                return Ok("Endereço Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Falha: {ex.Message}");
            }
        }
    }
}
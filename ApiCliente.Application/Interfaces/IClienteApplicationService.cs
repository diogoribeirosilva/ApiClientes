using ApiCliente.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        void Dispose();

    }
}

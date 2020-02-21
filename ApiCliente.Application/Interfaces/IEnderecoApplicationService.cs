using ApiCliente.Application.DTO.DTO;
using System.Collections.Generic;

namespace ApiCliente.Application.Interfaces
{
    public interface IEnderecoApplicationService
    {
        void Add(EnderecoDTO obj);

        EnderecoDTO GetById(int id);

        IEnumerable<EnderecoDTO> GetAll();

        void Update(EnderecoDTO obj);

        void Remove(EnderecoDTO obj);

        void Dispose();

    }
}

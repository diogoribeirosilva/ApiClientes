namespace ApiCliente.Application.DTO.DTO
{
    public class EnderecoDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}

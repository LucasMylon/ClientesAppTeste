using AutoMapper;
using ClientesApp.Domain.Entities;

namespace ClientesApp.API.DTOs
{
    public class MapPrifile : Profile
    {
        public MapPrifile()
        {
            CreateMap<ClienteRequest, Cliente>();
            CreateMap<EnderecoRequest, Endereco>();
        }
    }
}

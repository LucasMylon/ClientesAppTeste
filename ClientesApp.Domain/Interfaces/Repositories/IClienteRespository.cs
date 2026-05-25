using ClientesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesApp.Domain.Interfaces.Repositories
{
    public interface IClienteRespository
    {
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(Cliente cliente);
        Cliente ObterPorId(Guid id);
        List<Cliente> Listar();
    }
}

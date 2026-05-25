using ClientesApp.Domain.Entities;
using ClientesApp.Domain.Interfaces.Repositories;
using ClientesApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesApp.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRespository
    {
        public void Adicionar(Cliente cliente)
        {
            using (var context = new DataContext())
            {
                context.Add(cliente);
                context.SaveChanges();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            using (var context = new DataContext())
            {
                context.Update(cliente);
                context.SaveChanges();
            }
        }

        public void Excluir(Cliente cliente)
        {
            using (var context = new DataContext())
            {
                context.Remove(cliente);
                context.SaveChanges();
            }
        }
        public Cliente ObterPorId(Guid id)
        {
            using (var context = new DataContext())
            {
                if (context.Set<Cliente>().Find(id) is Cliente cliente)
                {
                    return cliente;
                }
                else
                {
                    throw new Exception("Cliente não encontrado.");
                }

            }
        }

        List<Cliente> IClienteRespository.Listar()
        {
            using (var context = new DataContext())
            {
                return context.Set<Cliente>().ToList();
            }
        }
    }
}

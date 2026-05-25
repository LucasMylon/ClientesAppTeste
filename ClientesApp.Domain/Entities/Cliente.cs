using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesApp.Domain.Entities
{
    public class Cliente
    {
        public Guid Id  { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefone { get; set; }


        public Endereco Endereco { get; set; } = null;
    }
}

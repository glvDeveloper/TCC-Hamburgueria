using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AplicacaoDeEstudoASPNETMVC.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("ClientesConnection")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
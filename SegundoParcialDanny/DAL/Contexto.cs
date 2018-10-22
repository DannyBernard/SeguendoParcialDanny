using SegundoParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialDanny.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Vendedor> Vendedor { get; set; }

        public Contexto() : base("ConStr")
        {

        }
           

    }
}
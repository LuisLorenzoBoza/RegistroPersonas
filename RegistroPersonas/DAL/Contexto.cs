using RegistroPersonas.Entidades;
using System.Data.Entity;


namespace RegistroPersonas.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        public Contexto() : base("Constr") { }
    }
}

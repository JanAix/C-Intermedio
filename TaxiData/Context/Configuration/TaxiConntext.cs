
using Microsoft.EntityFrameworkCore;
using Taxi.Data.Entities;


namespace Taxi.Data.Context
{
    public partial class TaxiContext
    {

        public DbSet<Taxis>Taxises { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Viaje> viajes { get; set; }
    }
}

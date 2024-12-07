
using Microsoft.EntityFrameworkCore;

namespace Taxi.Data.Context
{
    public partial class TaxiContext : DbContext

    {

        TaxiContext(DbContextOptions<TaxiContext> options) : base(options)
        {

        }
    }
}

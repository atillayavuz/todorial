using System.Data.Entity;

namespace Todorial.Data.Context
{
    public class TodorialContext : DbContext
    {
        public TodorialContext():base("DefaultConnection")
        {

        }
    }
}

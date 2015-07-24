using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todorial.Data.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}

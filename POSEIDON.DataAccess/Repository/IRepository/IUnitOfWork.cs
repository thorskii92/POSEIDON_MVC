using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //ICategoryRepository Category { get; }
        //IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        
        void Save();
    }
}

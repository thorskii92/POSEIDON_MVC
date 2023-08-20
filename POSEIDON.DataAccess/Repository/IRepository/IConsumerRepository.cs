using POSEIDON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Repository.IRepository
{
    public interface IConsumerRepository : IRepository<Consumer>
    {
        void Update(Consumer obj);
    }
}

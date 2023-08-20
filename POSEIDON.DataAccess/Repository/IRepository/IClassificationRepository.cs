using POSEIDON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Repository.IRepository
{
    public interface IClassificationRepository : IRepository<Classification>
    {
        void Update(Classification obj);
    }
}

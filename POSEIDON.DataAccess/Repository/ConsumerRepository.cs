using POSEIDON.DataAccess.Data;
using POSEIDON.DataAccess.Repository.IRepository;
using POSEIDON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Repository
{
    public class ConsumerRepository : Repository<Consumer>, IConsumerRepository
    {
        private ApplicationDbContext _db;
        public ConsumerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Consumer obj)
        {
            _db.Consumers.Update(obj);
        }
    }
}

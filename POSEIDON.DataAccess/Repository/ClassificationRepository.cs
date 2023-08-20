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
    public class ClassificationRepository : Repository<Classification>, IClassificationRepository
    {
        private ApplicationDbContext _db;
        public ClassificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Classification obj)
        {
            _db.Classifications.Update(obj);
        }
    }
}

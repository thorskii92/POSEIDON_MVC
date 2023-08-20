using POSEIDON.DataAccess.Data;
using POSEIDON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Repository
{
    public class DistrictRepository : Repository<District>, IProductRepository
    {
        private ApplicationDbContext _db;
        public DistrictRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(District obj)
        {
            _db.Districts.Update(obj);
        }
    }
}

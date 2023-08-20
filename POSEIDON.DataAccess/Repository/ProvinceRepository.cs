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
    public class PorivinceRepository : Repository<Province>, IProvinceRepository
    {
        private ApplicationDbContext _db;
        public PorivinceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Province obj)
        {
            _db.Provinces.Update(obj);
        }
    }
}

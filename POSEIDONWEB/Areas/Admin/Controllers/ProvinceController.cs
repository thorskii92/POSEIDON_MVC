using Microsoft.AspNetCore.Mvc;
using POSEIDON.DataAccess.Repository;
using POSEIDON.DataAccess.Repository.IRepository;

namespace POSEIDONWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProvinceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProvinceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

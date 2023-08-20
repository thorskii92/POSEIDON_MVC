using Microsoft.AspNetCore.Mvc;
using POSEIDON.DataAccess.Repository.IRepository;

namespace POSEIDONWEB.Areas.Employee.Pages.Accounts.Controllers
{
    [Area("Employee")]
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

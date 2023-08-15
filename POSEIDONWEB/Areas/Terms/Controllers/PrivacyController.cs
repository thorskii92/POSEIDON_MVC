using Microsoft.AspNetCore.Mvc;
using POSEIDON.DataAccess.Repository.IRepository;
using POSEIDONWEB.Areas.Consumer.Controllers;

namespace POSEIDONWEB.Areas.Terms.Controllers
{
    [Area("Terms")]
    public class PrivacyController : Controller
    {
        private readonly ILogger<PrivacyController> _logger;
        private readonly IUnitOfWork _iUnitOfWork;

        public PrivacyController(ILogger<PrivacyController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _iUnitOfWork = unitOfWork;
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}

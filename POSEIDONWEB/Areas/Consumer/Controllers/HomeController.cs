﻿using Microsoft.AspNetCore.Mvc;
using POSEIDON.DataAccess.Repository.IRepository;
using POSEIDON.Models.ViewModels;
using POSEIDON.Models;
using System.Diagnostics;

namespace POSEIDONWEB.Areas.Consumer.Controllers
{
    [Area("Consumer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _iUnitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _iUnitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
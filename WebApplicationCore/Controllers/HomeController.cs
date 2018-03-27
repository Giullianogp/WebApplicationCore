using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore.Models;
using WebApplicationCore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository repository)
        {
            _pieRepository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                Title = "Welcome to Pie shop",
                Pies = _pieRepository.GetAllPies().OrderBy(x => x.Name).ToList()
            };


            return View(viewModel);
        }
    }
}

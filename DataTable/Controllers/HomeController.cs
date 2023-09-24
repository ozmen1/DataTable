using DataTable.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(GetProducts());
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

        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();

            for (int i = 0; i < 20; i++)
            {
                Product product = new Product();

                product.Code = i.ToString();
                product.Name = "PRODUCT - " + i;
                product.BarcodeId = "BARCODE #" + i;

                productList.Add(product);
            }

            return productList;
        }
    }
}
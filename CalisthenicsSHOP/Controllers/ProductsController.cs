using CalisthenicsSHOP.Models;
using CalisthenicsSHOP.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalisthenicsSHOP.Controllers
{
    public class ProductsController : Controller
    {
        private List<Product> _products;

        public ProductsController(Data data)
        {
            _products = data.Products;
        }

        public IActionResult Index()
        {
            return View(_products);
        }

        public IActionResult View(int id)
        {
            var product = _products[_products.FindIndex(prod => prod.Id == id)];
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var prodIndex = _products.FindIndex(prod => prod.Id == id);
            if (prodIndex == -1)
            {
                return Content("Product wasn't found!");
            }

            return View(_products[prodIndex]);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var prodIndex = _products.FindIndex(prod => prod.Id == product.Id);
            if (_products[prodIndex] == product)
            {
                return View();
            }

            _products[prodIndex] = product;

            return View("Index", _products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var id = (_products.Any()) ? _products.Select(prod => prod.Id).Max() + 1 : 1;
            return View(new Product { Id = id });
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product.IsValid())
            {
                _products.Add(product);
                return View("Index", _products);
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            var prodIndex = _products.FindIndex(prod => prod.Id == id);
            if (prodIndex == -1)
            {
                return Content("Product wasn't found!");
            }

            _products.RemoveAt(prodIndex);
            return View("Index", _products);
        }
    }
}

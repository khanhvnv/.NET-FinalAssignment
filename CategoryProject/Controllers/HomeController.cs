using Microsoft.AspNetCore.Mvc;
using CategoryProject.Services;
using SharedLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CategoryProject.Models;
using System.Diagnostics;

namespace CategoryProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        // Hard-coded data for the homepage
        private readonly List<ProductDto> _featuredProducts = new()
        {
            new ProductDto { Id = 1, Name = "Bánh kem nhân dâu", Description = $"Như 1 trái dâu tươi đỏ mọng", Price = 335.000M, Images = "/images/Banh-Kem-Dau-1.jpg", CreatedDate = new DateOnly(2024,11,08) },
            new ProductDto { Id = 2, Name = "Bánh quy bơ đậu phộng", Description = $"Thơm ngon giòn béo", Price = 25.000M, Images = "/images/Quy-Bo-Dau-Phong-2.jpg", CreatedDate = new DateOnly(2024,11,08) },
            new ProductDto { Id = 2, Name = "Bánh Flan", Description = $"Núng nính tan mềm trên đầu lưỡi", Price = 12.000M, Images = "/images/Banh-Flan-2.jpg", CreatedDate = new DateOnly(2024,11,08) },
        };

        public async Task<IActionResult> Index(int? categoryId)
        {
            if (categoryId.HasValue)
            {
                // Fetch products by category from the API
                var products = await _productService.GetProductsByCategoryAsync(categoryId.Value);
                ViewBag.CategoryId = categoryId.Value; // To highlight the selected category
                return View(products);
            }

            // Serve hard-coded products for the default homepage
            ViewBag.CategoryId = null; // No category selected
            return View(_featuredProducts);
        }

        /* public async Task<IActionResult> CategoryList()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return PartialView("_CategoryList", categories);

        } */
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
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
using CRUD.BLL;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_N_Tier.Controllers
{
   //   Product controller
    public class ProductController : Controller
    {
        //  use product services
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            return View(_service.GetAll());
        }


        public IActionResult Create()
        {
            return PartialView("_Form", new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return PartialView("_Form", product);

            _service.AddProduct(product);
            return Json(true);
        }

        public IActionResult Edit(int id)
        {
            return View(_service.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
           // _service.GetProductById(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteProduct(id);
            return RedirectToAction("Index");
        }




    }
}

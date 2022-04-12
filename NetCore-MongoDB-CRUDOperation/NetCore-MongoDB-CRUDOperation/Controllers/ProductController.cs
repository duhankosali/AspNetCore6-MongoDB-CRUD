using Microsoft.AspNetCore.Mvc;
using NetCore_MongoDB_CRUDOperation.Interfaces.Manager;
using NetCore_MongoDB_CRUDOperation.Manager;
using NetCore_MongoDB_CRUDOperation.Models;

namespace NetCore_MongoDB_CRUDOperation.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager = new ProductManager();

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = Guid.NewGuid().ToString();
            bool isSaved = _productManager.Add(product);

            string msg = "";
            if(isSaved)
            {
                msg = "Product has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Save failed";
            }
            ViewBag.Mgs = msg;

            return View();
        }



        public IActionResult Edit(string id)
        {
            var product = _productManager.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool isUpdated = _productManager.Update(product.Id, product);
            if(isUpdated)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }



        public ActionResult Details(string id)
        {
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }

            return View(product);
        }



        public ActionResult Delete(string id)
        {
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            bool isDelete = _productManager.Delete(product.Id);
            if(isDelete)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Mgs = "Product delete failed";
            return View();
        }
    }
}

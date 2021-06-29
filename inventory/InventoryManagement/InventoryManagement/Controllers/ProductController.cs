using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.BL;
using InventoryManagement.Models;
using InventoryManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> pm = new List<ProductModel>();

            try
            {
                pm = new ProductBL().GetAllProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View(pm);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("Insert")]
        public ActionResult Insert(ProductRequest pr)
        {
            return View("Testing", pr);
        }
    }
}
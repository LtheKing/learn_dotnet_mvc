using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.BL.Model;
using InventoryManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index(AuthModel authModel)
        {
            return View("Login", authModel);
        }

        [HttpPost]
        public IActionResult Login(AuthRequest ar)
        {
            return View("Product/Index");
        }
    }
}
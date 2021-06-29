using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BookStore.DA;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IConfiguration configuration;
        public BooksController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            try
            {
                BooksDA bd = new BooksDA(configuration);
                List<BooksModel> listBooks = new List<BooksModel>(bd.Read());
                return View(listBooks);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public IActionResult Insert()
        {
            try
            {
                BooksDA bd = new BooksDA(configuration);
                List<BooksModel> listBooks = new List<BooksModel>(bd.Read());
                return View(listBooks);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Edit(int id)
        {
            BooksDA bd = new BooksDA(configuration);
            BooksModel bm = bd.getBooksByID(id);
            return View(bm);
        }

        [HttpPost]
        public IActionResult UpdateBooks(BooksModel bm)
        {
            BooksDA bd = new BooksDA(configuration);
            bd.UpdateBooks(bm);
            List<BooksModel> listBooks = new List<BooksModel>(bd.Read());

            return View("Index",listBooks);
        }

        public IActionResult DeleteBooks(int id)
        {
            BooksDA bd = new BooksDA(configuration);
            bd.DeleteBooks(id);
            List<BooksModel> listBooks = new List<BooksModel>(bd.Read());
            return View("Index",listBooks);
        }
    }
}
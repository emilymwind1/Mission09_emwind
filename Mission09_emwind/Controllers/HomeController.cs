﻿using Microsoft.AspNetCore.Mvc;
using Mission09_emwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_emwind.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var bookList = repo.Books.ToList();

            return View(bookList);
        }

    }
}

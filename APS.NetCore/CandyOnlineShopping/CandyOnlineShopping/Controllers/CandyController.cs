﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyOnlineShopping.Models.Services.Interfaces;
using CandyOnlineShopping.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyOnlineShopping.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyService _candyService;
        private readonly ICategoryService _categoryService;

        public CandyController(ICandyService candyService, ICategoryService categoryService)
        {
            _candyService = candyService;
            _categoryService = categoryService;
        }
        public IActionResult List()
        {
            var candyListView = new CandyListView();
            candyListView.CurrentCategory = "Best Sellers!";
            candyListView.Candies = _candyService.GetAll();
            return View(candyListView);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyService.GetById(id);
            if (candy == null)
            {
                return NotFound();
            }
            return View(candy);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Services.Interfaces;
using CandyOnlineShopping.Models.ViewModels;
using CandyOnlineShopping.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CandyOnlineShopping.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly ICandyService _candyService;

        public ShoppingCartController(ICandyService candyService, ShoppingCart shoppingCart)
        {
            _candyService = candyService;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCartItem = _shoppingCart.GetShoppingCartItems(),
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCArt(int candyId)
        {
            var selectedCandy = _candyService.GetAll().FirstOrDefault(c => c.Id == candyId);
            if (selectedCandy != null)
            {
                _shoppingCart.AddToCart(selectedCandy, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int candyId)
        {
            var selectedCandy = _candyService.GetAll().FirstOrDefault(c => c.Id == candyId);
            if (selectedCandy != null)
            {
                _shoppingCart.RemoveFromCart(selectedCandy);
            }

            return RedirectToAction("Index");
        }
    }
}

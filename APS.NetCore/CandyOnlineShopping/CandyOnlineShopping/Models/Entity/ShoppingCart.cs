using CandyOnlineShopping.Models.DataModels;
using CandyOnlineShopping.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Entity
{
    public class ShoppingCart
    {
        private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCart(IShoppingCartItemRepository shoppingCartItemRepository, IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        [Column("ShoppingCartId")]
        public string Id { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public void AddToCart(Candy candy, int amount)
        {
            _shoppingCartItemRepository.AddToCart(candy, amount, Id);
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetCart(IServiceProvider serviceProvider)
        {
            return _shoppingCartRepository.Create(serviceProvider);
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Candy candy)
        {
            return _shoppingCartItemRepository.RemoveFromCart(candy, Id);
        }
    }
}

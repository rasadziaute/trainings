using CandyOnlineShopping.Models.DataModels;
using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Repositories
{
    public class ShoppingCartItemRepository : IShoppingCartItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ShoppingCartItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public void AddToCart(Candy candy, int amount, string shoppingCartId)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItem.SingleOrDefault(s => s.Candy.Id == candy.Id && s.ShoppingCartId == shoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = shoppingCartId,
                    Candy = candy,
                    Amount = amount
                };
                _appDbContext.ShoppingCartItem.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public void ClearCart(string shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems(string shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal(string shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Candy candy, string shoppingCartId)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItem.SingleOrDefault(s => s.Candy.Id == candy.Id && s.ShoppingCartId == shoppingCartId);

            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
            }
            else
            {
                _appDbContext.ShoppingCartItem.Remove(shoppingCartItem);
            }
            _appDbContext.SaveChanges();

            return localAmount;
        }
    }
}

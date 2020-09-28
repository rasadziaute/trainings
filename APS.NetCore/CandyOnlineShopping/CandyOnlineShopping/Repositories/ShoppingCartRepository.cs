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
    public class ShoppingCartRepository: IShoppingCartRepository
    {
        private readonly IShoppingCartItemRepository _shoppingCartItemRepository;

        public ShoppingCartRepository(IShoppingCartItemRepository shoppingCartItemRepository)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
        }

        public ShoppingCart Create(IServiceProvider serviceProvider)
        {
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = serviceProvider.GetService<IShoppingCartRepository>();
            string cartId = session.GetString("Id") ?? Guid.NewGuid().ToString();
            session.SetString("Id", cartId);
            return new ShoppingCart(_shoppingCartItemRepository, context)
            {
                Id = cartId
            };
        }
    }
}

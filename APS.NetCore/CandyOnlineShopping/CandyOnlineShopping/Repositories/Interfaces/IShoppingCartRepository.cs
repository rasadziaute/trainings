using CandyOnlineShopping.Models.Entity;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Repositories.Interfaces
{
    public interface IShoppingCartRepository
    {
        ShoppingCart Create(IServiceProvider serviceProvider);
    }
}

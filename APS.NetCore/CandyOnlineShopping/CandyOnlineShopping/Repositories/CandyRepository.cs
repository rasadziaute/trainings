using CandyOnlineShopping.Models.DataModels;
using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Repositories
{
    public class CandyRepository : ICandyRepository
    {
        //private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;

        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Candy> GetAll()
        {
            return _appDbContext.Candy.Include(c => c.Category);
        }

        public Candy GetById(int Id)
        {
            return _appDbContext.Candy.Include(c=> c.Category).FirstOrDefault(c => c.Id == Id);
        }

        public IEnumerable<Candy> GetOnSale()
        {
            return _appDbContext.Candy.Include(c => c.Category).Where(p=> p.IsOnSale);
        }
    }
}

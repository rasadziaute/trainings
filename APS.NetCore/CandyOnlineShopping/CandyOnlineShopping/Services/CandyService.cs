using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using CandyOnlineShopping.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Services
{
    public class CandyService: ICandyService
    {
        private readonly ICandyRepository _candyRepository;

        public CandyService(ICandyRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }

        public IEnumerable<Candy> GetAll()
        {
            return _candyRepository.GetAll();
        }

        public Candy GetById(int Id)
        {
            return _candyRepository.GetById(Id);
        }

        public IEnumerable<Candy> GetOnSale()
        {
            return _candyRepository.GetOnSale();
        }
    }
}

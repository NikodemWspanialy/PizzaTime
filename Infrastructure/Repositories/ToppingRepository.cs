using Domain.Interfaces.IRepositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class ToppingRepository : IToppingRepository
    {
        public Task<Topping?> AddAsync(Topping topping)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Topping>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Topping?> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}

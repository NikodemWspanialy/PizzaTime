using Domain.Interfaces.IRepositories;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class ToppingRepository(ApplicationDbContext dbContext) : IToppingRepository
    {

        public async Task<Topping?> AddAsync(Topping topping)
        {
            if (topping == null)
            {
                return null;
            }
            using (var transaction = await dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    await dbContext.AddAsync(topping);
                    await dbContext.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return topping;
                }
                catch
                {
                    //log
                    return null;
                }
            }
        }

        public async Task<bool> ExistAsync(Topping topping)
        {
            if (topping is not null)
            {
                using (var transaction = await dbContext.Database.BeginTransactionAsync())
                {
                    var t = await dbContext.toppings.FindAsync(topping?.NormalizeName);
                    await transaction.CommitAsync();
                    if (t is not null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public async Task<IEnumerable<Topping>?> GetAllAsync()
        {
            IEnumerable<Topping> result;
            using (var transaction = await dbContext.Database.BeginTransactionAsync())
            {
                result = await dbContext.toppings.ToListAsync();
                await transaction.CommitAsync();
            }
            return result;
        }

        public async Task<Topping?> GetAsync(string id)
        {
            using (var transaction = await dbContext.Database.BeginTransactionAsync())
            {
                return await dbContext.toppings.FirstOrDefaultAsync(x => x.Id == id);
            }
        }
    }
}

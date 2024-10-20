using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
    /// <summary>
    /// Interface for tooping managment in db
    /// </summary>
    public interface IToppingRepository
    {
        Task<Topping?> AddAsync(Topping topping);
        Task<Topping?> GetAsync(string id);
        Task<IEnumerable<Topping>?> GetAllAsync();
        Task<bool> ExistAsync(Topping topping);
    }
}

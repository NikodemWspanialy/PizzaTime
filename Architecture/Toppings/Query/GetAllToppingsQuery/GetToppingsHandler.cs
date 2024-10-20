using Domain.Interfaces.IRepositories;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Toppings.Query.GetAllToppingsQuery
{
    internal class GetToppingsHandler(IToppingRepository toppingRepository) : IRequestHandler<GetToppingsQuery, IEnumerable<Topping>?>
    {
        public async Task<IEnumerable<Topping>?> Handle(GetToppingsQuery request, CancellationToken cancellationToken)
        {
            //TODO przy rozszerzanu aplikacji o DTO dodac mapping 
            return await toppingRepository.GetAllAsync();
        }
    }
}

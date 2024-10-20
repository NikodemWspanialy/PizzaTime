using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Toppings.Query.GetAllToppingsQuery
{
    internal class GetToppingsHandler : IRequestHandler<GetToppingsQuery, IEnumerable<Topping>?>
    {
        public Task<IEnumerable<Topping>?> Handle(GetToppingsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

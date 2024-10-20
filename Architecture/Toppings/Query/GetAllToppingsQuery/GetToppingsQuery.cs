using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Toppings.Query.GetAllToppingsQuery
{
    public class GetToppingsQuery : IRequest<IEnumerable<Topping>?>
    {
    }
}

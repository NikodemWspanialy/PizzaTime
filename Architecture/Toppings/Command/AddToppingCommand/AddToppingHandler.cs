using Domain.Interfaces.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Toppings.Command.AddToppingCommand
{
    internal class AddToppingHandler(IToppingRepository toppingRepo) : IRequestHandler<AddToppingCommand>
    {
        Task IRequestHandler<AddToppingCommand>.Handle(AddToppingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

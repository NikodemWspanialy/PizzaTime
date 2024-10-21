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
		async Task IRequestHandler<AddToppingCommand>.Handle(AddToppingCommand request, CancellationToken cancellationToken)
		{
			if (!(await toppingRepo.ExistAsync(request)))
			{
				await toppingRepo.AddAsync(request);
			}
			return;

		}
	}
}

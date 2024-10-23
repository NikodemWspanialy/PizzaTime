using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Toppings.Command.AddToppingCommand
{
    /// <summary>
    /// Command for creating new topping , returning result 
    /// </summary>
    public class AddToppingCommand : Topping, IRequest<bool>
    {
    }
}

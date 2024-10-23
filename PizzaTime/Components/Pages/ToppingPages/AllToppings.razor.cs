using Architecture.Toppings.Query.GetAllToppingsQuery;
using Domain.Models;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace PizzaTime.Components.Pages.ToppingPages
{
	public partial class AllToppings
	{
		private List<Topping> toppings = [];
		private List<Topping> allToppings = [];
		private bool IsProcessing = true;

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				await LoadToppings();
			}
		}

		private async Task LoadToppings()
		{
			await Task.Delay(2000);
			var result = await mediator.Send(new GetToppingsQuery());
			if (result is not null)
			{
				allToppings = result.ToList();
				toppings = allToppings;
				IsProcessing = false;
				StateHasChanged();
			}
		}

		private void filterToppings(ChangeEventArgs e)
		{
			if (e is not null)
			{
				string filter = e.Value?.ToString();

				if (!string.IsNullOrEmpty(filter))
				{
					toppings = allToppings.Where(t => t.Name.Contains(filter)).ToList();
				}
				else
				{
					toppings = allToppings;
				}
			}

			StateHasChanged();
		}
	}
}

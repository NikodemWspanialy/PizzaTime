using Architecture.Toppings.Query.GetAllToppingsQuery;
using Domain.Models;

namespace PizzaTime.Components.Pages.ToppingPages
{
	public partial class AllToppings
	{
		private List<Topping> toppings = [];
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
				toppings = result.ToList();
				IsProcessing = false;
				StateHasChanged();
			}
		}
	}
}

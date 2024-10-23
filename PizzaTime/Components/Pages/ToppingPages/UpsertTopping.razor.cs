using Domain.Models;
using Microsoft.AspNetCore.Components;

namespace PizzaTime.Components.Pages.ToppingPages;
public partial class UpsertTopping
{
	[Parameter]
	public string Id { get; set; } = string.Empty;

	protected Topping topping = null!;

	private bool isProccessing = false;
	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		{
			if (firstRender)
			{
				if (!string.IsNullOrEmpty(Id))
				{
					isProccessing = true;
					StateHasChanged();

					await Task.Yield(); // usunaæ po dodaniu gettera
					topping = new(); //get by Id
				}
				isProccessing = false;
				StateHasChanged();
			}
		}
	}
}

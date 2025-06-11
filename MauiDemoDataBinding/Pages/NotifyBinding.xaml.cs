using System.Threading.Tasks;
using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();

	public NotifyBinding()
	{
		InitializeComponent();

		produto = new Produto
		{
			Nome = "IPhone 5",
			Preco = 5000.00m,
			Estoque = 5
		};

		BindingContext = produto;
	}

	private async void btnAtualiza_Clicked(object sender, EventArgs e)
	{
		produto.Nome = "Samsung G20";
		produto.Preco = 2000.00m;
		produto.Estoque = 12;

		await DisplayAlert("Produto Atualizado",
			$"{produto.Nome} - {produto.Preco} " +
			$" - {produto.Estoque}", "OK");
	}
}
using System.Text.Json;

namespace MauiDemoDataBinding.Pages;

public partial class MauiResorces : ContentPage
{
    Pessoa pessoa;

    public MauiResorces()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("tim.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();

        var pessoa = JsonSerializer.Deserialize<Pessoa>(contents);

        BindingContext = pessoa;
    }
}
public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int Idade { get; set; }

    public string Foto { get; set; }
}


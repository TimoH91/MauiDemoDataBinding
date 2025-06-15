using System.ComponentModel;
using System.Diagnostics;
using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {


        public MainPage()
        {
            InitializeComponent();

        }





        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    var produto = new Produto
        //    {
        //        Nome = "IPhone 5",
        //        Preco = 5000.00m,
        //        Estoque = 5
        //    };

        //    //Binding produtoBinding = new Binding();
        //    //produtoBinding.Source = produto;
        //    //produtoBinding.Path = "Nome";

        //    Binding nomeBinding = new Binding
        //    {
        //        Source = produto,
        //        Path = "Nome",
        //        StringFormat = "Produto: {0}"
        //    };

        //    lblNome.SetBinding(Label.TextProperty, nomeBinding);
        //    //lblNome.SetBinding(Label.TextProperty, produtoBinding);

        //    Binding precoBinding = new Binding
        //    {
        //        Source = produto,
        //        Path = "Preco",
        //        StringFormat = "Preço: {0}"
        //    };

        //    lblPreco.SetBinding(Label.TextProperty, precoBinding);

        //    Binding estoqueBinding = new Binding
        //    {
        //        Source = produto,
        //        Path = "Estoque",
        //        StringFormat = "Estoque: {0}"
        //    };

        //    lblPreco.SetBinding(Label.TextProperty, estoqueBinding);
        //}

    }
    
}



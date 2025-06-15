using MauiDemoDataBinding.Pages;

namespace MauiDemoDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage1 = new NavigationPage(new SliderBinding());
            NavigationPage navPage2 = new NavigationPage(new BindingModes());
            NavigationPage navPage3 = new NavigationPage(new NotifyBinding());

            MainPage = new NavigationPage(new JogoDeForca());
        }
    }
}

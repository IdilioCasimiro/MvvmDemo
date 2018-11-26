using MvvmDemo.ViewModels;
using SimpleInjector;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MvvmDemo
{
    public partial class App : Application
    {
        public static Container Container { get; private set; }

        public App()
        {
            //1 - Create de container
            Container = new Container();
            //2 - Register Services
            Container.Register<IPageService, PageService>();
            Container.Register<PlaylistsViewModel>();
            //3 - Verify the configuration
            Container.Verify();

            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
        }
    }
}

using MvvmDemo.Models;
using MvvmDemo.ViewModels;
using System;
using Xamarin.Forms;

namespace MvvmDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = App.Container.GetInstance<PlaylistsViewModel>();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void ListaPlaylists_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            (BindingContext as PlaylistsViewModel).SelectItemCommand.Execute(e.SelectedItem as PlaylistViewModel);
        }
    }
}

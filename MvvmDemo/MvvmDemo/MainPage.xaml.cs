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
            BindingContext = new PlaylistViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Add(object sender, EventArgs e)
        {
            (BindingContext as PlaylistViewModel).Adicionar();
        }

        private void ListaPlaylists_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //(BindingContext as PlaylistViewModel).SeleccionarItem(
            //    e.SelectedItem as Playlist);
            var playlist = e.SelectedItem as Playlist;
            playlist.Favorito = !playlist.Favorito;
        }
    }
}

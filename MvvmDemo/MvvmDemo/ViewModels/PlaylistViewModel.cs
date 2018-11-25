using MvvmDemo.Models;
using System.Collections.ObjectModel;

namespace MvvmDemo.ViewModels
{
    class PlaylistViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();
        public Playlist PlaylistSeleccionada { get; set; }

        public void Adicionar()
        {
            Playlists.Add(new Playlist()
            {
                Titulo = "Playlist " + Playlists.Count
            });
        }

        public void SeleccionarItem(Playlist playlist)
        {
            PlaylistSeleccionada = playlist;
            PlaylistSeleccionada.Favorito = !PlaylistSeleccionada.Favorito;
            PlaylistSeleccionada = null;
        }
    }
}

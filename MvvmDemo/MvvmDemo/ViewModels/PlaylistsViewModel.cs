using MvvmDemo.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmDemo.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel playlistSeleccionada;
        public PlaylistViewModel PlaylistSeleccionada
        {
            get { return playlistSeleccionada; }
            set { SetProperty(ref playlistSeleccionada, value); }
        }

        private readonly IPageService pageService;
        public ICommand AddPlaylistCommand { get; private set; }
        public ICommand SelectItemCommand { get; private set; }

        public PlaylistsViewModel(IPageService pageService)
        {
            this.pageService = pageService;
            AddPlaylistCommand = new Command(Adicionar);
            SelectItemCommand = new Command<PlaylistViewModel>(
                vm => SeleccionarItem(vm));
        }

        private void Adicionar()
        {
            Playlists.Add(new PlaylistViewModel()
            {
                Titulo = "Playlist " + Playlists.Count
            });
        }

        private async void SeleccionarItem(PlaylistViewModel playlist)
        {
            playlist.Favorito = !playlist.Favorito;
            PlaylistSeleccionada = null;
            await pageService.PushAsync(new PlaylistDetails(playlist));
        }
    }
}

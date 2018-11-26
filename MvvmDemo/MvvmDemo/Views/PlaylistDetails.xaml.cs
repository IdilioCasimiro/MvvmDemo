using MvvmDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetails : ContentPage
	{
        private PlaylistViewModel playlist;
		public PlaylistDetails (PlaylistViewModel playlist)
        {
            this.playlist = playlist;
            BindingContext = this.playlist;
            InitializeComponent ();
		}
	}
}
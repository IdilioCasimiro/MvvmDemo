using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmDemo.ViewModels
{
    public class PlaylistViewModel : BaseViewModel
    {
        public string Titulo { get; set; }

        private bool favorito;
        public bool Favorito
        {
            get { return favorito; }
            set { SetProperty(ref favorito, value); }
        }
    }
}

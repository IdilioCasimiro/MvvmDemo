using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmDemo.Models
{
    public class Playlist : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Titulo { get; set; }
        private bool favorito;

        public bool Favorito { get; set; }

        
    }
}

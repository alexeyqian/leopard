using System;
using System.ComponentModel;

namespace Leopard.Models
{
    public class Project : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private string _description;
        private string _imageUrl;
        private bool _isStarted;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                OnPropertyChanged(nameof(ImageUrl));
            }
        }

        public bool IsStarted
        {
            get => _isStarted;
            set
            {
                _isStarted = value;
                OnPropertyChanged(nameof(IsStarted));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

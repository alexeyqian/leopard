using System;
using System.ComponentModel;

namespace Leopard.Models
{
    public class Show : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private string _description;
        private string _imageUrl;
        private bool _isFinished;

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

        public bool IsFinished
        {
            get => _isFinished;
            set
            {
                _isFinished = value;
                OnPropertyChanged(nameof(IsFinished));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

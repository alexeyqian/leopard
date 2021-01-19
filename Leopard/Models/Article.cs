using System;
using System.ComponentModel;

namespace Leopard.Models
{
    public class Article : INotifyPropertyChanged
    {
        private Guid _id;
        private string _generatedUrl;
        private string _title;
        private string _content;
        private string _description;
        private string _imageUrl;
        private bool _isPublished;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string GeneratedUrl
        {
            get => _generatedUrl;
            set
            {
                _generatedUrl = value;
                OnPropertyChanged(nameof(GeneratedUrl));
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
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

        public bool IsPublished
        {
            get => _isPublished;
            set
            {
                _isPublished = value;
                OnPropertyChanged(nameof(IsPublished));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace APIDemoApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBussy;

        public bool IsBussy
        {
            get => _isBussy;
            set
            {
                _isBussy = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

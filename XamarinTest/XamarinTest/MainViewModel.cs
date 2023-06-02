using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinTest
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _count = 0;
        private string _buttonText;
        public MainViewModel()
        {
            _buttonText = $"Count is {_count}";
        }
        public string ButtonText { get { return _buttonText; } set { _buttonText = value; OnPropertyChanged("ButtonText"); } }
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand IncrementCommand => new Command(() =>
        {
            _count++;
            ButtonText = $"Count is {_count}"; 
        });
    }
}

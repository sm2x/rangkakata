using System;
using System.ComponentModel;

namespace Rangkakata.ViewModels.Core
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

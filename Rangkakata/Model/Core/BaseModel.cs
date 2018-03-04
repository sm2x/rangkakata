using System;
using System.ComponentModel;

namespace Rangkakata.Model.Core
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

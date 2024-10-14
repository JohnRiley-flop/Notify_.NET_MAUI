using Notify.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Notify.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //Properties
        public ObservableCollection<Note> ShowingEntries;

        public MainPageViewModel()
        {
            ShowingEntries =
            [
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
                new Note { ID=1, Title="Entry", Entry="Fill"},
            ];
        }


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

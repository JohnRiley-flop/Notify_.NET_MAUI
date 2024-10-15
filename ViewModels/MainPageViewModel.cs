using Notify.Models;
using Notify.Services;
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
        public ObservableCollection<Note> ShowingEntries { get; set; }
        //Commands
        public Command GoToAddEntryPage { get; set; }

        public MainPageViewModel()
        {
            //Displaying List of Entries
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

            //Commands to link front and back
            GoToAddEntryPage = new (AddNewEntry);


        }

        private async void AddNewEntry()
        {
            //await Shell.Current.GoToAsync("");
        }

        private void UpdateList()
        {

        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

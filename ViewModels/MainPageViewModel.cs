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
        public Command AddNewEntryCommand { get; set; }

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
            AddNewEntryCommand = new (AddNewEntry);


        }

        private async void AddNewEntry()
        {
            //Note toAdd = NAVIGATE TO ADD PAGE AND RETURN NEW NOTE ARGUMENTS
            Note toAdd = new() { ID=1, Title="Note", Entry="Fill" };
            if (null == toAdd) { return; }
            await DatabaseService.AddNoteAsync(toAdd);
            //Reload Page because a change was made
        }

        private void UpdateList()
        {

        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

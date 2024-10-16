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
    public class AddNotePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //Commands
        public Command AddNewNoteCommand { get; set; }

        //Properties
        private readonly DateTime PendingDate;
        public string PendingTitle { get; set; }
        public string PendingEntry { get; set; }
        public AddNotePageViewModel()
        {
            PendingDate = DateTime.Now;
            PendingTitle = "";
            PendingEntry = "";
            AddNewNoteCommand = new(AddNewNote);
        }


        private async void AddNewNote()
        {
            await DatabaseService.AddNoteAsync(
                new Note
                {
                    ID = 1,
                    DateOfCreation = PendingDate,
                    Title = PendingTitle,
                    Entry = PendingEntry,
                }
            );
            await Shell.Current.GoToAsync("Main");
        }
    }
}

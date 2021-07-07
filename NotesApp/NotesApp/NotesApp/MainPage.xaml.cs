using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp.Model;
using Xamarin.Forms;

namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            var Notes = new List<Note>();
            var files = Directory.EnumerateFiles
                (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "*.notes.txt");
            foreach (var filename in files)
            {
                var note = new Note
                {
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename),
                    FileName = filename
                };
                Notes.Add(note);
            }
            NotesListView.ItemsSource = Notes.OrderBy(n => n.Date).ToList();
        }

        private async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddNotePage
            {
                BindingContext = new Note()
            });
        }

        private async void OnNoteItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new AddNotePage
            {
                BindingContext = (Note)e.SelectedItem
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp.Model
{
    public class Note
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string FileName { get; set; }
    }
}

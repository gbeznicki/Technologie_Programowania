using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace czesc1
{
    public class DataContext
    {
        public List<BookReader> bookReaders;
        public Dictionary<string, Book> books;
        public ObservableCollection<Event> events;
        public List<BookState> bookStates;
    }
}

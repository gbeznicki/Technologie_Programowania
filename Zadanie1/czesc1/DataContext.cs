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
        public List<Wykaz> wykaz;
        public Dictionary<string, Katalog> katalog;
        public ObservableCollection<Zdarzenie> zdarzenia;
        public List<OpisStanu> opisyStanu;
    }
}

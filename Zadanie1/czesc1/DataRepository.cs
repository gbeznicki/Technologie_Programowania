using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czesc1
{
    public class DataRepository
    {
        private DataContext data;

        private DataContext Data
        {
            set => data = value;
        }
    }
}

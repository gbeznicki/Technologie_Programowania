using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czesc1
{
    public class ConstDataFiller : DataFiller
    {
        public override void Fill(DataContext context)
        {
            var bookReaders = context.bookReaders;
            
        }
    }
}

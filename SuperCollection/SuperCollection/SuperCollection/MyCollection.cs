using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCollection
{
    public class MySuperList : IEnumerable //сделать дженирековый
    {
        private string[] _data;

        public MySuperList()
        {
            _data = new string[5];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}

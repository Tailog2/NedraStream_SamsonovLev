using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedraStreamSamsonovLev
{
    public interface ITree
    {
        public void Add(int value);
        public bool HasValue(int value);
        public int GetMaxSum();
    }
}

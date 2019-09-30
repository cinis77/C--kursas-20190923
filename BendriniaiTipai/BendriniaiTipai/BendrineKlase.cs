using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendriniaiTipai
{
    internal class BendrineKlase<T, K, M> where T : IList<T>
    {
        public T elementas;

        public T GautiElementa()
        {
            return elementas;
        }
    }

    internal class PushPullDataBase<T> where T : class
    {
        public void PushToDatabse(T data)
        {
        }
    }
}
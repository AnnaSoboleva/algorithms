using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ListExtensions
    {
        public static List<T> Clone<T>(this List<T> list) where T: ICloneable
        {
            return list.Select(item => (T)item.Clone()).ToList();
        }
    }
}

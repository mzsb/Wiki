using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Helpers
{
    public static class ListHelper
    {
        public static string ToString<T>(this List<T> list, 
                                            string separator = ", ")
        => string.Join(separator, list);
    }
}

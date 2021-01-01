using System.Collections.Generic;
using System.Linq;

namespace YoukaiFox.CsharpExtensions
{
    public static class IEnumerableExtensions 
    {
        // Author: github.com/sponticelli.
        /// <summary>
        /// Returns true if the list is null or has 0 objects.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> self)
        {
            return self == null || !self.Any();
        }
    }
}
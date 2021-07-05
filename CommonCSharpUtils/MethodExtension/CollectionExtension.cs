using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonCSharpUtils.MethodExtension
{
    public static class CollectionExtension
    {
        /// <summary>
        /// Allows to fetch a WHOLE row based on Distinct value of one of it's columns.<br/>
        /// It does this by: GroupBy -> FirstOrDefault Linq methods.
        /// </summary>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {
            return items.GroupBy(property).Select(x => x.FirstOrDefault());
        }
    }
}

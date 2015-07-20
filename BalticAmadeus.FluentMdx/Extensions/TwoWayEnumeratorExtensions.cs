using System;
using System.Collections.Generic;

namespace BalticAmadeus.FluentMdx.Extensions
{
    internal static class TwoWayEnumeratorExtensions
    {
        public static ITwoWayEnumerator<T> GetTwoWayEnumerator<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            return new TwoWayEnumerator<T>(source.GetEnumerator());
        }
    }
}
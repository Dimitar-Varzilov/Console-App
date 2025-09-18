using System.Collections.Generic;

namespace Console_App.Utilities
{
    internal static class NumberUtilities
    {
        public static int GetFirstMismatchIndex<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            using IEnumerator<T> enum1 = first.GetEnumerator();
            using IEnumerator<T> enum2 = second.GetEnumerator();
            int index = 0;
            while (enum1.MoveNext() && enum2.MoveNext())
            {
                if (!EqualityComparer<T>.Default.Equals(enum1.Current, enum2.Current))
                    return index; // Mismatch found
                index++;
            }
            // If lengths differ, return index of first missing element
            if (enum1.MoveNext() || enum2.MoveNext())
                return index;
            return -1; // No mismatch
        }
    }
}

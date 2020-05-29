using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraftsnMoreGalore.Helpers
{
    public static class Extensions
    {

        // Select the specified number of elements from a list, chosen randomly.
        public static List<T> RandomElements<T>(this List<T> list, int count)
        {

            // Create a copy of the list so the original list is not affected by the randomization process.
            var listCopy = new List<T>();
            foreach (T e in list)
            {
                listCopy.Add(e);
            }
            // Randomize the copy of the list.
            listCopy.Randomize();
            // Grab "count" elements from the randomized list.
            return listCopy.Take(count).ToList();

        }

        public static void Randomize<T>(this List<T> list)
        {
            var rng = new Random();

            void Swap(int i, int j, List<T> l)
            {
                var temp = l[i];
                l[i] = l[j];
                l[j] = temp;
            }

            for (var j = 0; j < 2; j++)
            {
                for (var i = list.Count; i > 0; i--)
                {
                    Swap(0, rng.Next(1, i), list);
                }
            }
        }

    }
}
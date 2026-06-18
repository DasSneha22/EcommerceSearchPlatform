using System;

namespace EcommerceSearchPlatform
{
    public class SearchEngine
    {
        // LINEAR SEARCH
        // Scans the array one by one from start to finish.
        public static Product LinearSearch(Product[] catalog, string targetId)
        {
            int steps = 0;
            for (int i = 0; i < catalog.Length; i++)
            {
                steps++;
                if (catalog[i].ProductId == targetId)
                {
                    Console.WriteLine($"> Linear Search: Found in {steps} steps.");
                    return catalog[i];
                }
            }
            Console.WriteLine($"> Linear Search: Not found after {steps} steps.");
            return null;
        }

        // BINARY SEARCH
        // Repeatedly divides a SORTED array in half.
        public static Product BinarySearch(Product[] catalog, string targetId)
        {
            int steps = 0;
            int left = 0;
            int right = catalog.Length - 1;

            while (left <= right)
            {
                steps++;
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(targetId, catalog[mid].ProductId);

                if (comparison == 0) // Match found
                {
                    Console.WriteLine($"> Binary Search: Found in {steps} steps.");
                    return catalog[mid];
                }
                if (comparison < 0) // Target is smaller, ignore right half
                {
                    right = mid - 1;
                }
                else // Target is larger, ignore left half
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine($"> Binary Search: Not found after {steps} steps.");
            return null;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int n in numbers)
                total += n;
            return total;
        }

        public static string RepeatString(this string value, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
                sb.Append(value);
            return sb.ToString();
        }
    }
}

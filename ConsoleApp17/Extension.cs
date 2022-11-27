using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
   static class Extension
    {

        public static string[] CustomSplit(this string sentence, char symbol = ' ')
        {
            string str = "";
            string[] arr = new string[0];

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = str;
                    str = string.Empty;
                }
                else
                {
                    str += sentence[i];
                }
            }

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;

            return arr;
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace DI_String_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            diStringMatch("IDID");
            Console.WriteLine("Hello World!");
        }

        public static int[] diStringMatch(string S)
        {
            int len = S.Length;
            int[] arr = new int[len + 1];
            int I = 0;
            int D = len;
            int k = 0;

            for(int i = 0; i< len; i++)
            {
                arr[k++] = S[i] == 'D' ? D-- : I++;
            }

            arr[k] = D;
            return arr;
        }
    }
}

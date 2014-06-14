using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveString
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = " Brown fox jump";
            Print(source);
            Console.WriteLine();
            Print(ReverseString(source.ToCharArray()));

        }

        static void Print(string source) 
        {
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i]);
            }
        }
        static void Print(char[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i]);
            }
        }

        static char[] ReverseString(char[] source,int i, int j)
        {

            while (i < j)
            {
                char tmp = source[i];
                source[i] = source[j];
                source[j] = tmp;
                i++; j--;
            }

            return source;

        }

        static char[] ReverseString(Char[] source)
        {
            int i = 0, j = 0;
            char space = ' ';
            source = ReverseString(source, i, source.Length-1);

            while (i < source.Length -1 )
            {
                while (source[j] != space && j < source.Length - 1) { j++; }
                
                source = ReverseString(source, i, j == source.Length -1 ?  j : j-1);
                j++;
                i = j;
               
            }

            return source;
        }
    }


   
}









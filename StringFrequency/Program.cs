using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of character");
            Frequency("helloloo");
            Console.WriteLine();
            Console.WriteLine("Remove Duplicate");
            RemoveDuplicate("heelloo");
            Console.WriteLine();
            Console.WriteLine("Possible substring");
            Substring("abcd");
        }

        public static void Frequency(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach(var character in s)
            {
                if(character != ' ')
                {
                    if(!freq.ContainsKey(character))
                    {
                        freq.Add(character, 1);
                    }
                    else
                    {
                        freq[character]++;
                    }
                }
            }

            foreach(var character in freq)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }

        }

        public static void RemoveDuplicate(string s)
        {
            string result = string.Empty;

            for(int i=0; i < s.Length; i++)
            {
                if (!result.Contains(s[i]))
                {
                    result += s[i];
                }
            }
            Console.WriteLine(result);
        }

        public static void Substring(string s)
        {
            for(int i=0; i < s.Length; i++)
            {
                StringBuilder sb = new StringBuilder(s.Length - i);

                for(int j = i; j < s.Length; j++)
                {
                    sb.Append(s[j]);
                    Console.WriteLine(sb+ " ");
                }

            }
        }
    }
}

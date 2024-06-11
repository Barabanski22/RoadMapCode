using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP_algorithum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naive algorithm
            // При даден стринг и даден шаблон (pattern) да проверим дали дадения шаблон се намира в дадения стринг, като изкараме индексите, на които се намира

            // Даден пример: string text = abcabaabcabac, string pattern = abba
            string text = "abcabbabcabakkokokkjhf";
            string pattern = "abba";

            int i = 0;
            int j = 0;
            string ans = "";
            bool contain = false;
            int pos;

            while (i < text.Length)
            {
                if (text[i] == pattern[j])
                {
                    ans += text[i];
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    j = 0;
                    ans = "";
                }
                if(ans.Length == pattern.Length)
                {
                    Console.WriteLine($"{ans} is locaited at position: {i - pattern.Length}");
                    j = 0;
                    ans = "";
                    contain= true;
                }
            }
            if(!contain) Console.WriteLine("the string doesn't contain this pattern");
        }
    }
}

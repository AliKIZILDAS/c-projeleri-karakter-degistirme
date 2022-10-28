using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s="Merhaba Hello Algoritma x";
            string ilkKarakter="";
            string yeniS="";

            for (int i = 0; i <= s.Count(); i++)
            {
                if (i==0)
                {
                    ilkKarakter=s[i].ToString();
                }
                else if (i==s.Length)
                {
                     yeniS+=ilkKarakter;
                } 
                else if (s[i].ToString()==" ")
                {
                     yeniS+=ilkKarakter+" ";
                }
                else if (s[i-1].ToString()==" ")
                {
                     ilkKarakter=s[i].ToString();
                }                                 
                else
                {
                    yeniS+=s[i].ToString();
                }                             
            }             
                      
            Console.WriteLine(yeniS);
        }
    }
}
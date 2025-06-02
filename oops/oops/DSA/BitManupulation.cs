using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.DSA
{
     public static class BitManupulation
    {
         public static void BinaryRepresentation()
         {
             int n = 10;
             string ans = "";
             string rsult = "";
             string final = "";
             while (n > 0)
             {
                 ans += (n % 2).ToString();
                 n = n / 2;
             }
             for (int i = ans.Length-1; i >=0; i--)
             {
                 rsult += ans[i].ToString(); 
                 Console.WriteLine("Binary number is " + rsult);
             }
             for (int i = 0; i < (32 - ans.Length); i++)
             {
                 final += 0;
             }
             Console.WriteLine("Final Bianry number is " + (final + rsult));
         }
         public static void Countsetbits()
         {
             int n = 10;
             string ans = "";
             string rsult = "";
             string final = "";
             while (n > 0)
             {
                 ans += (n % 2).ToString();
                 n = n / 2;
             }
             for (int i = ans.Length - 1; i >= 0; i--)
             {
                 rsult += ans[i].ToString();
             }
             int count = 0;
             for (int i = 0; i < rsult.Length; i++)
             {
                 int dd = (int)rsult[i];
                 if (rsult[i].ToString() == "1")
                 {
                     count++;
                 }
             }
             Console.WriteLine("set bit is " + count);
         }

         public static void AddTwoBinary()
         {
             string s1 = "1101", s2 = "111";
             int s1lwngth = s1.Length;
             int s2lwngth = s2.Length;
             string result = "";
             int ans = 0, ans2 = 0, carray = 0;
             for (int i = 0; i < s1lwngth; i++)
             {
                 int n = (int)s1[s1lwngth - 1 - i]-'0';
                 if (n == 1)
                 {
                     ans += 1 << i;
                 }
             }
             for (int i = 0; i < s2lwngth; i++)
             {
                 int n = (int)s2[s2lwngth - 1 - i] - '0';
                 if (n == 1)
                 {
                     ans2 += 1 << i;
                 }
             }
             int final = ans + ans2;
             string ret = "";
             while (final > 0)
             {
                 ret += (final % 2).ToString();
                 final = final / 2;
             }

             Console.WriteLine("Add Two Binary " + (ans+ ans2) + "");
         }
    }
}

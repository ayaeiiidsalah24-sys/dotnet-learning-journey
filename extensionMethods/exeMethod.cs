using OOP.extensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//exmaples

//int x = 4;
//Console.WriteLine(x.IsGreaterByAya(3));

//string ss = "300";
//Console.WriteLine(ss.IsNumber());

//string stat = "welcome to the dot net world ";
//Console.WriteLine(stat.CountWordsAya());

namespace OOP.extensionMethods
{
    static class exeMethod
    {
        public static bool IsGreaterByAya(this int number , int num2)
        {
            return number>num2;
        }

        public static bool IsNumber(this string str) {
          if (!string.IsNullOrEmpty(str))
            return int.TryParse(str, out int n);
            
            
            else
                return false;
        }

        public static int CountWordsAya(this string statment) {
            if (!string.IsNullOrEmpty(statment)) { 
                Array s = statment.Split(' ');
                return s.Length;
            
            }
            else {return 0; }   
        
        
        }




    }
}
using OOP.recursiveMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Console.WriteLine("the result of recursion for the number (4) is :: " );
//Console.WriteLine("result from our three funtions  ");
//Console.WriteLine("first one result:: ");
//Console.WriteLine(recursiveMethod.factRecursive(4));
//Console.WriteLine("second one result");
//Console.WriteLine(recursiveMethod.factRecursive2(4));
//Console.WriteLine("the last one result");
//Console.WriteLine(recursiveMethod.factNonRecursive(4));


string path = string.Empty;
path = "D:\\rwwad";
recursiveMethod.DisplayFolders(path, 0); 



namespace OOP.recursiveMethods
{
    static class recursiveMethod
    {


        public static int factNonRecursive(int num) {

            
            if (num == 0) return 1;
            int res = 1;

            for (int i = num; i > 0; i--) {
                
            res*= i;    
            }
        return res;
        }


        public static int factRecursive(int num)
        {
            if (num == 0) return 1;
            return num*factRecursive(num-1);
        }

        //let's recap extension method 

        public static int factRecursive2( this int num)
        {
            if (num == 0) return 1;
            return num * factRecursive2(num - 1);
        }

       public static void DisplayFolders(string path , int indent ) {
            foreach (var folder in Directory.GetDirectories(path)) {
                Console.WriteLine($"{new string(' ' , indent)}{Path.GetFileName(folder)}");
                DisplayFolders(folder, indent + 3); 
            }
        }
            

    }
}

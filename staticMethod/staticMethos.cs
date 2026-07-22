using OOP.staticMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//staticMethos stat = new staticMethos();
//stat.helloWorld2(); 
namespace OOP.staticMethod
{
    internal class staticMethos
    {

        public static void helloWorld() {

            Console.WriteLine("hello from static method , you can call me just if you a class not instance !");
        }

        public void helloWorld2() {
            Console.WriteLine("hello ya instance !"); 
                
                
                }



    }
}

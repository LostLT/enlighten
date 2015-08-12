using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



        }


        public static void PreExport()
        {

            Console.WriteLine("This is a pre-export method firing");
           

        }

        public static void PostExport(string path)
        {

            Console.WriteLine("This is a post-export method firing, and this is the path we ingested: " + path);
         
        }

    }
}

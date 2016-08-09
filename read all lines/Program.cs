using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_all_lines
{
    class Program
    {
        static void Main(string[] args)
        {

            //object
            string line;
            StreamReader reader = new StreamReader("TextFile1.txt");
            using (reader)

                int lineNumer = 0;
            //read first line
            stringline = reader.ReadLine();
            {
                {
                    line = reader.ReadLine();


                }
                Console.WriteLine(line);
            }
        }
    }
}

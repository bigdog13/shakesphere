using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace shakesphere
{          class Program
        {
            static void Main(string[] args)
            {
                string line;
                StreamReader shakespeare = new StreamReader(@"..\..\Shakespeare.txt");
                line = shakespeare.ReadLine();
                Console.WriteLine(line);
                Console.WriteLine();
                shakespeare.Close();

                StreamReader shakespeare2 = new StreamReader(@"..\..\Shakespeare.txt");
                line = shakespeare2.ReadToEnd();
                Console.WriteLine(line);
                Console.WriteLine();
                shakespeare2.Close();

                StreamReader shakespeare3 = new StreamReader(@"..\..\Shakespeare.txt");
                line = shakespeare3.ReadToEnd();
                foreach (char c in line)
                {
                    string changeUp = c.ToString();
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        changeUp = c.ToString().ToUpper();
                    }
                    Console.Write(changeUp);

                }
                shakespeare3.Close();
            }
        }
}




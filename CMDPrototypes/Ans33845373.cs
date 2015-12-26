using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDPrototypes
{
    class Ans33845373
    {
        public Ans33845373()
        {
            
        }

        public bool Execute(String[] args)
        {
            bool retValue = false;
            Console.Clear();
            SafeForWork();
            Console.WriteLine();
            JustShowingOff();
            return retValue;
        }
        private static void SafeForWork()
        {
            StreamReader myReader = new StreamReader(@"C:\Users\Public\NumbersFile.txt");
            string line = "";

            while (line != null)
            {

                line = myReader.ReadLine();
                int number = -1;
                if (Int32.TryParse(line, out number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }

            myReader.Close();
        }
        private static void JustShowingOff()
        {
            List<String> Contents = File.ReadAllLines(@"C:\Users\Public\NumbersFile.txt").ToList();
            List<String> Evens = Contents.Where(var => (Int32.Parse(var)) % 2 == 0).ToList();
            Evens.ForEach(var => Console.WriteLine(var));
        }
    }
}

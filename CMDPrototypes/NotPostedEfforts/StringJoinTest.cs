using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDPrototypes.NotPostedEfforts
{
    class StringJoinTest
    {
        public StringJoinTest()
        {

        }

        public bool Execute (String[] args)
        {
            bool retValue = true;
            Console.Clear();
            int[] numbers = { 155, 192, 178, 192 };
            string[] names = { "Sam", "Nick", "Pete", "Doug" };
            var results = numbers.Select((var, i) => var.ToString() + " " + names[i]).ToList();
            results.ForEach(var => Console.WriteLine(var));
            Console.ReadLine();
            return retValue;
        }
    }
}

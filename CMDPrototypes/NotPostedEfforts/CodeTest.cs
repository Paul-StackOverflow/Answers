using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMDPrototypes.NotPostedEfforts
{
    class CodeTest
    {
        public CodeTest()
        {

        }

        public bool Execute(String[] args)
        {
            bool retValue = false;
            Console.Clear();
            List<string> CodeKey = new List<string>();
            List<string> GUIKey = new List<string>();
            for (int i = 0; i < 200000; i++)
            {
                string result = GetGUIDCodeKeyCode();
                if (GUIKey.Contains(result))
                {
                    Console.WriteLine("Duplicate GUID @ position " + i);
                    Thread.Sleep(3);
                }
                else
                {
                    Console.WriteLine(result);
                    GUIKey.Add(result);
                }
            }
            Console.ReadLine();
            return retValue;
        }
        private string GetGUIDCodeKeyCode()
        {//There are certainly schemes that use encryption as well.
            Guid GU = Guid.NewGuid();
            string seed = GU.ToString().Replace("-", "");
            int max = seed.Length - 8;
            Random rnd = new Random(seed.Length);
            int start = rnd.Next(1, max);
            string Code = string.Join("", seed.Skip(start).Take(8).ToArray());
            return Code;
        }
    }
}

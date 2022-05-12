using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.MyClass;

namespace Delegates
{
    public delegate void Funct(string str);

    public class MyClass
    {
      
        public MyClass(string s)
        {
           
        }

        public void Space(string str)
        {
            for (int i = 1; i < str.Length; i += 2)
            {
                str = str.Insert(i, "_");
            }
            Console.WriteLine(str);
        }

        public void Reverse(string str)
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            Console.WriteLine(s);
        }
    }
    class Run
    {
        public void runFunc(Funct delg, string str)
        {
            delg.Invoke(str);
        }
    }
}

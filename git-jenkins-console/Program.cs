using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_jenkins_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException("args");

            if (args.Length == 0) throw new ArgumentOutOfRangeException("args");

            Console.WriteLine(SayHello(args[0]));
        }

        public static string SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");

            var strBuilder = new StringBuilder("Hello, ");
            strBuilder.Append(name);

            return strBuilder.ToString();
        }
    }
}

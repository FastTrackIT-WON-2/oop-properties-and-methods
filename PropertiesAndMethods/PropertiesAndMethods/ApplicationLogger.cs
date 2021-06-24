using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class ApplicationLogger
    {
        private ApplicationLogger()
        {
        }

        public static ApplicationLogger Instance = new ApplicationLogger();

        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}

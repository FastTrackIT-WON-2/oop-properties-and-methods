using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public static class ConsoleHelper
    {
        public static void PrintMessage(string message)
        {
            PrintMessageWithOptions(message, null, 1);
        }

        public static void PrintMessage(string message, string label)
        {
            PrintMessageWithOptions(message, label, 1);
        }

        public static void PrintMessage(string message, int count)
        {
            PrintMessageWithOptions(message, null, count);
        }

        private static void PrintMessageWithOptions(string message, string label, int count)
        {
            string labelWithMessage = (!string.IsNullOrEmpty(label)
                                        ? $"{label}: "
                                        : string.Empty) +
                                      message;

            StringBuilder builderRepeatedText = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builderRepeatedText.AppendLine(labelWithMessage);
            }


            Console.WriteLine(builderRepeatedText.ToString());
        }
    }
}

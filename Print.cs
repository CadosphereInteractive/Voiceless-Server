using System;
using System.IO;

namespace Voiceless_Server
{
    class WriteOut
    {
        /// <summary>
        /// A convience class to simplify printing in a standard format
        /// Replaces Console.Write()
        /// </summary>
        /// <param name="text"> The text you want printed </param>
        public static void Print(string text)
        {
            string outputString = "[" + DateTime.Now.ToString("h:mm:ss tt") + "] " + text;
            File.AppendAllText("log.txt", outputString + Environment.NewLine);
            Console.Write(outputString);
        }

        /// <summary>
        /// A convience class to simplify printing in a standard format
        /// Replaces Console.WriteLine()
        /// </summary>
        /// <param name="text"> The text you want printed </param>
        public static void PrintLine(string text)
        {
            string outputString = "[" + DateTime.Now.ToString("h:mm:ss tt") + "] " + text;
            File.AppendAllText("log.txt", outputString + Environment.NewLine);
            Console.WriteLine(outputString);
        }
    }
}
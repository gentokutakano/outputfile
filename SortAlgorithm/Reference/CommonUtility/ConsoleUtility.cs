using System;

namespace StringSort.Command
{
    class ConsoleUtility
    {
        /// <summary>
        /// Get String value from Console
        /// </summary>
        /// <returns></returns>
        public static string GetStringConsole()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }

        /// <summary>
        /// Get Char value form Console
        /// </summary>
        /// <returns></returns>
        public static char[] GetCharArrayConsole()
        {
            string userInput = Console.ReadLine();
            char[] charValue = StringUtility.GetCharArray(userInput);
            return charValue;
        }

        /// <summary>
        /// Message Display Output
        /// </summary>
        /// <param name="sMessage"></param>
        public static void DisplayToConsole(string sMessage)
        {
            Console.WriteLine(sMessage);
        }
    }
}

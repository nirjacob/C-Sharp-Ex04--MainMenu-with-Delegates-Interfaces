using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class ActionMethods
    {
        static public void showVerison()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }
        static public void countSpaces()
        {
            int numberOfSpaces = 0;
            Console.WriteLine("Please enter a sentence: ");
            string userInput = Console.ReadLine();
            foreach(char charecter in userInput)
            {
                if (char.IsWhiteSpace(charecter))
                {
                    numberOfSpaces++;
                }
            }
            Console.WriteLine("The number of spaces in the sentence is: {0}", numberOfSpaces);
        }
        static public void showDate()
        {
            Console.WriteLine(DateTime.Today.ToString());
        }
        static public void showTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}

﻿namespace magicVilla_VillaAPI.logging
{
    public class Loggingv2 :ILogging
    {
        public void Log(string message, string type)
        {
            if (type == " error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR - " + message);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                if(type == "warning")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ERROR - " + message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine(message);
                }
                
            }
        }
    }
}

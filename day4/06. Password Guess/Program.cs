﻿using System;

namespace _06._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            if (name == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

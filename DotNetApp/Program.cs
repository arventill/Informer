﻿using DotNetApp.Resources;
using System;

namespace DotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AppConst.Welcome();
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        {
                            Console.WriteLine("In progress");
                            break;
                        }
                    case "2":
                        {
                            About();
                            break;
                        }
                    case "3":
                        {
                            ExitApp();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nie znaleziono takiej opcji!");
                            break;
                        }
                }
            }

        }

        private static void ExitApp()
        {
            System.Environment.Exit(0);
        }

        private static void About()
        {
            foreach (var item in AppConst.AppAboutInfo)
            {
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
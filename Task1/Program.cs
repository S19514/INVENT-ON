using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Task1.Models;
using Task1.Repository;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnLoad();

        }

        static void OnLoad()
        {
            int Param = new int();
            
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter Param 1(word) 2(Cars) or ESC to Close");
                if (Int32.TryParse(Console.ReadLine(), out Param))
                {
                    switch (Param)
                    {
                        case 1:
                            SeedWithData.SeedWords();
                            Console.WriteLine("Press ESC to stop or Enter char and press enter to proceed");
                            GetFromUserP1();
                            break;
                        case 2:
                            SeedWithData.SeedCars();
                            Console.WriteLine("Enter Make and press enter to proceed");
                            GetFromUserP2();
                            break;
                        default:
                            break;
                    }                    
                    GetFromUserP2();
                }
            }
                Environment.Exit(1);
        }

        static void GetFromUserP1()
        {
            Char LetterKey = new char();
            String UserInput = new String("");
            
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {                
                UserInput = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(UserInput) && Regex.IsMatch(UserInput, "[a-zA-Z]"))
                {
                    LetterKey = Convert.ToChar(UserInput.Substring(0, 1).ToUpper());
                    Console.WriteLine("Your input: {0}", LetterKey);
                    IEnumerable<Word> ToPrintout = Word.GetWord(LetterKey);
                    foreach (Word item in ToPrintout)
                    {
                        Console.WriteLine(item._word);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Value should be a Literal.");
                }
                Console.WriteLine("Press ESC to stop or Enter char and press enter to proceed");
            }
            
        }

        static void GetFromUserP2()
        {            
            String UserInput = new String("");
            
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                UserInput = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(UserInput) && Regex.IsMatch(UserInput, "[a-zA-Z]"))
                {                    
                    Console.WriteLine("Your input: {0}", UserInput);
                   Car ToPrintout = Car.GetCarWithModels(UserInput);
                    if (!(ToPrintout is null))
                    {
                        foreach (CarModel _carModel in ToPrintout.Models)
                        {
                            Console.WriteLine("Make  | Model  |  price  | priceWdiscount ");
                            Console.WriteLine($"{ToPrintout.Make} | {_carModel.name} | {_carModel.price} | {_carModel.price / 1 + _carModel.discountRate}");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Value should be a Make.");
                }
                Console.WriteLine("Press ESC to stop or Enter Make and press enter to proceed");
            }

        }
    }
}

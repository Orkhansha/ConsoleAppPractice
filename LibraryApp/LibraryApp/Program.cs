using Domain.Models;
using Service.Services;
using Service.Services.Helpers;
using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();
            Helper.WriteConsole(ConsoleColor.Yellow, "Select one option:");
            Helper.WriteConsole(ConsoleColor.Green, "1 - Create library, 2 - Get library by Id, 3 - Update library, 4 - Delete library");

            while (true)
            {
                SelectOption: string SelectOption = Console.ReadLine();
                int selectTrueOption;
                bool isSelectOption = int.TryParse(SelectOption, out selectTrueOption);
                if (isSelectOption)
                {
                    switch (selectTrueOption)
                    {
                        case 1:
                            Helper.WriteConsole(ConsoleColor.Yellow, "Add library name:");
                            string labraryName = Console.ReadLine();

                            Helper.WriteConsole(ConsoleColor.Yellow, "Add seat count:");
                            SeatCount: string librarySeatCount = Console.ReadLine();
                            int seatCount;
                            bool isSeatCount = int.TryParse(librarySeatCount, out seatCount);
                            if (isSeatCount)
                            {
                                Library library = new Library
                                {
                                    Name = labraryName,
                                    SeatCount = seatCount

                                };
                                var result = libraryService.Create(library);
                                Helper.WriteConsole(ConsoleColor.Green, $"Library Id: {result.Id}, Library name: {result.Name}, Library seat count: {result.SeatCount}");

                            }
                            else
                            {
                                Helper.WriteConsole(ConsoleColor.Red, "Add correct seat count:");
                                goto SeatCount;
                            }

                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            break;
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select correct option number:");
                            break;
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select correct option:");
                    goto SelectOption;
                }
            }
        }
    }
}

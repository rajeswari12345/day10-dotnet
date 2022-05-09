// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Are you sure you want to delete this person from your address book? (Y/N)");
PrintPerson(person);

if (Console.ReadKey().Key == ConsoleKey.Y)
{
    People.delete(person);
    Console.WriteLine("Person deleted. Press any key to continue.");
    Console.ReadKey();
}
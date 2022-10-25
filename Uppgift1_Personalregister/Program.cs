using Uppgift1_Personalregister;

Console.WriteLine("Uppgift 1: Personal register\n" +
                  "Kriterier:\n" +
                  "\n1. Registret skall kunna ta emot och lagra anställda med namn och lön\n" +
                  "2. Programmet skall kunna skriva ut registret i konsolen\n");
Console.WriteLine("####### Welcome #######\n");

bool exit = true;
do
{
    Console.WriteLine("What would you like to do?\n\n" +
                      "1) ADD new employee\n" +
                      "2) PRINT employees\n" +
                      "3) EXIT");

    int userChoice = int.Parse(Console.ReadLine());

    if (userChoice == 1)
    {
        Employee.AddEmployee(firstName: "Stefan", lastName: "Brunotte", salary: 38_000);
    }
    else if (userChoice == 2)
    {
        Console.WriteLine("Print employee");
    }
    else
    {
        Environment.Exit(3);
    }
} while (exit);



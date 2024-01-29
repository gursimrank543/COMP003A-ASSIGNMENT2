/*
 * 
 * Author: Gursimran Kaur
 * Course: COMP-003A--L01
 * Purpose: Code for Assignment2
 */
{
    Console.Title = "COMP-003A-Assignment2";
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    {
        string firstName = Console.ReadLine();
        string middleName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string inputAge = Console.ReadLine();
        int yearBorn = 2023 - Convert.ToInt32(inputAge);
        Console.WriteLine($"Hello,[firstName) {middleName} {lastName}. You were Born in {yearBorn}.");
        {
            Console.WriteLine($"(integer1)+(integer2)=(integer1+integer2)");
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;
            }
        }
    }
}
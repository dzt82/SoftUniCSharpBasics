using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte employeeAge = 30;
        char employeeGender = 'm';
        ulong employeePersonalIDNumb = 8306112507;
        ushort employeeUniqueNumb = 55; // For the actual employee unique number we need to sum it with 27560000.
        Console.WriteLine("Employee Data: \nName: {0} {1} \nAge: {2} \nMale/Female: {3} \nPersonal ID Number: {4} \nUnique Employee Number: {5}" ,firstName, lastName, employeeAge, employeeGender, employeePersonalIDNumb, 27560000 + employeeUniqueNumb);
    }
}
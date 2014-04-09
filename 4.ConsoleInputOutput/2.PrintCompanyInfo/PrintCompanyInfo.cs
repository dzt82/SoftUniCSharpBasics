using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string coName = Console.ReadLine();
        Console.Write("Company address: ");
        string coAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string coPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string coFax = Console.ReadLine();
        Console.Write("Web site: ");
        string coWeb = Console.ReadLine();
        Console.Write("Maneger first name: ");
        string maFiName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string maLaName = Console.ReadLine();
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string maPhone = Console.ReadLine();
        {
            Console.WriteLine("\n{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWeb site: {4}\nManager: {5}\n(age: {6},tel. {7})",
            coName, coAddress, coPhone, coFax, coWeb, maFiName + " " + maLaName, age, maPhone);
        }
    }
}

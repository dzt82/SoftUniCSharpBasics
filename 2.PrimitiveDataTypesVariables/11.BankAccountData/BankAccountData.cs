using System;

class bankAccountData
{
    static void Main()
    {
        string firstName, middleName, lastName;
        decimal moneyBalance;
        string bankName, IBAN;
        ulong CC1, CC2, CC3;
        firstName = "Ivan";
        middleName = "Ivanov";
        lastName = "Ivanov";
        moneyBalance = 123465.675m;
        bankName = "Barclays";
        IBAN = "BCL4664";
        CC1 = 28604739573859843;
        CC2 = 75940375648932512;
        CC3 = 98564878364125656;
        Console.WriteLine("Account data: \nHolder Name: {0} {1} {2} \nBalance: {3} lv. \nBank:{4} \nIBAN: {5} \nCredit Card 1: {6} \nCredit Card 2: {7} \nCredit Card 3: {8}", firstName, middleName, lastName, moneyBalance, bankName, IBAN, CC1, CC2, CC3);
    }
}

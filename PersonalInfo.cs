using System;

class PersonalInfo
{
    static void Main()
    {
        string name1 = "Lucinda Potter";
        DateTime birthdate1 = new DateTime(1992, 6, 24);
        string workPhoneNumber1 = "000-000-0101";
        string cellPhoneNumber1 = "000-000-0189";

        Console.WriteLine(name1);
        Console.WriteLine(birthdate1.ToShortDateString());
        Console.WriteLine("work " + workPhoneNumber1);
        Console.WriteLine("cell " + cellPhoneNumber1);
    }




}
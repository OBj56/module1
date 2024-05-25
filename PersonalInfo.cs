
using System.Net;
using static System.Console;

class PersonalInfo
{
    static void Main(string[] args)
    {
           string name1 = "Lucinda Potter";
              string name2 = "John Smith";
                string name3 = "Chris Johnson";
                  string name4 = "Robert Hall";
        
        DateTime birthdate1 = new DateTime(1992, 6, 24);
         DateTime birthdate2 = new DateTime(1978, 8, 15);
            DateTime birthdate3 = new DateTime(1987, 12, 1);
                DateTime birthdate4 = new DateTime(1949, 2, 27);
    

        string workPhoneNumber1 = "000-000-0101";
         string workPhoneNumber2 = "000-111-0101";
         string workPhoneNumber3 = "000-222-0101";
        string workPhoneNumber4 = "000-333-0101";


        string cellPhoneNumber1 = "000-000-0189";
         string cellPhoneNumber2 = "000-111-0189";
         string cellPhoneNumber3 = "000-222-0189";
        string cellPhoneNumber4 = "000-333-0189";


              WriteLine(name1);
            WriteLine(birthdate1.ToShortDateString());
           WriteLine("work " + workPhoneNumber1);
          WriteLine("cell " + cellPhoneNumber1);
        WriteLine();

        WriteLine(name2);
        WriteLine(birthdate2.ToShortDateString());
         WriteLine("work " + workPhoneNumber2);
          WriteLine("cell " + cellPhoneNumber2);
           WriteLine();

           WriteLine(name3);
          WriteLine(birthdate3.ToShortDateString());
         WriteLine("work " + workPhoneNumber3);
        WriteLine("cell " + cellPhoneNumber3);
        WriteLine();

        WriteLine(name4);
          WriteLine(birthdate4.ToShortDateString());
            WriteLine("work " + workPhoneNumber4);
              WriteLine("cell " + cellPhoneNumber4);
                WriteLine();

    }
}


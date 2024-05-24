class PersonalInfo
{
    static void Main()
    {
        string name1 = "Lucinda Potter"; 
            string name2 = "John Smith"; 
                string name3 = "name3"; 
                     string name4 = "dd";

                          DateTime birthdate1 = new DateTime(1992, 6, 24); 
                              DateTime birthdate2 = new DateTime(1992, 6, 24);
                                  DateTime birthdate3 = new DateTime(1992, 6, 24); 
                                        DateTime birthdate4 = new DateTime(1992, 6, 24);


                               string workPhoneNumber1 = "000-000-0101";
                        string workPhoneNumber2 = "000-000-0101";
                string workPhoneNumber3 = "000-000-0101";
            string workPhoneNumber4 = "000-000-0101";

            
        string cellPhoneNumber1 = "000-000-0189"; 
         string cellPhoneNumber2 = "000-000-0189";
         string cellPhoneNumber3 = "000-000-0189";
        string cellPhoneNumber4 = "000-000-0189";


              Console.WriteLine(name1);
                Console.WriteLine(birthdate1.ToShortDateString());
                  Console.WriteLine("work " + workPhoneNumber1);
                      Console.WriteLine("cell " + cellPhoneNumber1);
                          Console.WriteLine();

    


        Console.WriteLine(name2);
        Console.WriteLine(birthdate2.ToShortDateString());
        Console.WriteLine("work " + workPhoneNumber1);
        Console.WriteLine("cell " + cellPhoneNumber1);


    }
}


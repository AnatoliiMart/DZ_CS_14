namespace DZ_CS_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompany companies = new Companies(new List<Company>
            {
               new Company("Abakaban", "Bobby White", "London", "IT", 10, new DateTime(2023, 2, 15), 
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "36958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("OD Food", "John Black", "Paris", "Marketing", 120, new DateTime(2022, 12, 25),
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "36958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("Luxoft", "Duein Jones", "Odesa", "Marketing and IT", 100, new DateTime(2022, 3, 10),
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "36958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("French Food", "Harley Queen", "Krakow", "Restourans", 300, new DateTime(2020, 11, 28), 
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "36958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("White Horse", "David Black", "London", "Logistic", 150, new DateTime(2010, 1, 17), 
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "36958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("TourForU", "White Bobby", "Warsaw", "Travelling", 45, new DateTime(2005, 6, 11),
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "23958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),

               new Company("Nt-IX", "Batman", "Kyiv", "IT", 30, new DateTime(2016, 7, 31),
               new Worker[]
               {
                   new("Lionel", "Manager", "231547845", "diogr@email.com", 12300),
                   new(),
                   new(),
                   new("John", "Programmer", "36521365412", "dior@email.com", 112300),
                   new(),
                   new("Fedor", "Machinery", "23958457122", "ogr@email.com", 15000),
                   new(),
                   new()
               } ),
            });
            bool correct = false;
            do
            {
                Console.WriteLine("Menu\n" +
                             "1.  Get information about all companies\n" +
                             "2.  Get companies that have the word \'Food\' in their name\n" +
                             "3.  Get companies that work in marketing\n" +
                             "4.  Get companies that work in marketing or IT\n" +
                             "5.  Get companies with more than 100 employees\n" +
                             "6.  Get companies with a number of employees ranging from 100 to 300\n" +
                             "7.  Get companies that are based in \'London\'\n" +
                             "8.  Get companies with director last name White\n" +
                             "9.  Get companies that were founded more than two years ago\n" +
                             "10. Get companies from the date of foundation, which have passed 123 days\n" +
                             "11. Get companies whose director's last name is \'Black\' and company name contains the word \'White\'\n" +
                             "12. Get all employees of a particular company\n" +
                             "13. Get all employees of a particular company who have wages above the target\n" +
                             "14. Get employees of all companies that have a position manager\n" +
                             "15. Get employees whose phone number starts with \'23\'\n" +
                             "16. Get employees whose Email starts with \'di\'\n" +
                             "17. Get employees whose name is \'Lionel\'");
                Console.Write("Choose option:\t");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        companies.ShowAllCompanies();
                        break;
                    case 2:
                        companies.GetCompaniesInNameIsFood();
                        break;
                    case 3:
                        companies.GetMarketingCompanies();
                        break;
                    case 4:
                        companies.GetMarketingAndItCompanies();
                        break;
                    case 5:
                        companies.GetMoreThan100WorkersCompanies();
                        break;
                    case 6:
                        companies.GetFrom100to300WorkersCompanies();
                        break;
                    case 7:
                        companies.CompaniesPlacedInLondon();
                        break;
                    case 8:
                        companies.CompaniesDirectorWhite();
                        break;
                    case 9:
                        companies.CompaniesMoreThanTwoYearsAgoCreated();
                        break;
                    case 10:
                        companies.CompaniesMoreThan123DaysAgoCreated();
                        break;
                    case 11:
                        companies.RequestFromHELL();
                        break;
                    case 12:
                        companies.GetWorkersByCompanyName("Abakaban");
                        break;
                    case 13:
                        companies.GetWorkersByFirmNameAndSalary("Nt-IX", 12000);
                        break;
                    case 14:
                        companies.GetAllWorkersManagers();
                        break;
                    case 15:
                        companies.GetWorkersNumberBeginBy23();
                        break;
                    case 16:
                        companies.GetWorkersEMailBeginBy_di_();
                        break;
                    case 17:
                        companies.GetWorkersName_Lionel();
                        break;
                    default:
                        Console.WriteLine("Wrong input!!! Try again!");
                        break;
                }
                Console.WriteLine("Do you want to continue: y/n");
                string? s = Console.ReadLine();
                if (s == "n")
                    correct = false;
                else if (s == "y")
                {
                    Console.Clear();
                    correct = true;
                }

            } while (correct);
           
        }
    }
}
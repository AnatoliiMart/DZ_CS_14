namespace DZ_CS_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompany companies = new Companies(new List<Company>
            {
               new Company("Abakaban", "Bobby White", "London", "IT", 10, new DateTime(2023, 2, 15)),

               new Company("OD Food", "John Black", "Paris", "Marketing", 120, new DateTime(2022, 12, 25)),

               new Company("Luxoft", "Duein Jones", "Odesa", "Marketing and IT", 100, new DateTime(2022, 3, 10)),

               new Company("French Food", "Harley Queen", "Krakow", "Restourans", 300, new DateTime(2020, 11, 28)),

               new Company("White Horse", "David Black", "London", "Logistic", 150, new DateTime(2010, 1, 17)),

               new Company("TourForU", "White Bobby", "Warsaw", "Travelling", 45, new DateTime(2005, 6, 11)),

               new Company("Nt-IX", "Batman", "Kyiv", "IT", 30, new DateTime(2016, 7, 31)),
            });
            companies.ShowAllCompanies();
            companies.RequestFromHELL();
            companies.CompaniesMoreThan123DaysAgoCreated();


        }
    }
}
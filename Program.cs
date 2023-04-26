namespace DZ_CS_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompany companies = new Companies(new List<Company>
            {
               new Company("A", "Bobby White", "London", "IT", 10, new DateTime(2023, 2, 15)),

               new Company("OD Food", "2", "Paris", "Marketing", 120, new DateTime(2022, 12, 25)),

               new Company("C", "4", "Odesa", "Marketing and IT", 100, new DateTime(2022, 3, 10)),

               new Company("French Food", "3", "Krakow", "Restourans", 300, new DateTime(2020, 11, 28)),

               new Company("White Horse", "David Black", "London", "Logistic", 150, new DateTime(2010, 1, 17)),

               new Company("F", "White Bobby", "Warsaw", "Travelling", 45, new DateTime(2005, 6, 11)),

               new Company("G", "7", "Kyiv", "IT", 30, new DateTime(2016, 7, 31)),
            });
            companies.ShowAllCompanies();
            companies.RequestFromHELL();
            companies.CompaniesPlacedInLondon();
           
          
        }
    }
}
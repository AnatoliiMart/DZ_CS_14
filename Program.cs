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
        }
    }
}
namespace DZ_CS_14
{
    public class Company
    {
        public string CompanyName { get; private set; }

        public string directorName { get; private set; }

        public string CompanyAdress { get; private set; }

        public string buisnessProfile { get; private set; }

        public int amountOfWorkers { get; private set; }

        public DateTime dateOfCreation { get; private set; }

        public Company(string CompanyName, string directorName, string CompanyAdress,
                    string businesProfile, int amountOfWorkers, DateTime dateOfCreation)
        {
            this.CompanyName = CompanyName;
            this.directorName = directorName;
            this.CompanyAdress = CompanyAdress;
            this.buisnessProfile = businesProfile;
            this.amountOfWorkers = amountOfWorkers;
            this.dateOfCreation = dateOfCreation;
        }
        public override string ToString()
        {
            return $"Company name:\t\t{CompanyName}\n" +
                   $"Director name:\t\t{directorName}\n" +
                   $"Company adress:\t\t{CompanyAdress}\n" +
                   $"Buisness profile:\t{buisnessProfile}\n" +
                   $"Amount of workers:\t{amountOfWorkers}\n" +
                   $"Date of creation:\t{dateOfCreation.ToShortDateString()}\n";
        }
    }
    public class Companies : ICompany
    {
        private List<Company> companies = new List<Company>();
        public Companies(List<Company> companies)
        {
            this.companies = companies;
        }
        public void CompaniesDirectorWhite()
        {
            var res = from c in companies
                      where c.directorName.Contains("White")
                      select c;

            Console.WriteLine("Companies wich directors name/surname is \'White\'");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void CompaniesMoreThan123DaysAgoCreated() // needs be fixed
        {
            var res = from item in companies
                      where (DateTime.Today.Day - item.dateOfCreation.Day) < 123
                      select item;
            Console.WriteLine("Frims more tham 123 days ago created");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void CompaniesMoreThanTwoYearsAgoCreated()
        {
            var res = from item in companies
                      where item.dateOfCreation.Year < (DateTime.Now.Year - 2)
                      select item;
            Console.WriteLine("Companies more than 2 years ago created");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void CompaniesPlacedInLondon()
        {
            Console.WriteLine("Companies placed in London");
            var res = from c in companies
                      where c.CompanyAdress.Contains("London")
                      select c;
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void GetCompaniesInNameIsFood()
        {
            Console.WriteLine("Companies that have the word \'Food\' in their name ");
            var res = from c in companies
                      where c.CompanyName.Contains("Food")
                      select c;
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");

        }

        public void GetFrom100to300WorkersCompanies()
        {
            var res = from c in companies
                      where c.amountOfWorkers >= 100 && c.amountOfWorkers <= 300
                      select c;
            Console.WriteLine("Companies what have from 100 to 300 workers");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        public void GetMarketingAndItCompanies()
        {
            Console.WriteLine("Companies with Marketing and IT profile");
            var res = from c in companies
                      where c.buisnessProfile.Contains("Marketing") && c.buisnessProfile.Contains("IT")
                      select c;
            foreach (var item in res)
                Console.WriteLine(item.ToString() + "\n");
            Console.WriteLine("------------------------------------------------");
        }

        public void GetMarketingCompanies()
        {
            var res = from c in companies
                      where c.buisnessProfile.Contains("Marketing")
                      select c;
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void GetMoreThan100WorkersCompanies()
        {
            var res = from c in companies
                      where c.amountOfWorkers > 100
                      select c;
            Console.WriteLine("Companies what have more than 100 workers");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void RequestFromHELL()
        {
            var res = from c in companies
                      where c.CompanyName.Contains("White") && c.directorName.Contains("Black")
                      select c;

            Console.WriteLine("Companies what in company name contains \'White\' and director name/surname contains \'Black\'");
            foreach (var item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void ShowAllCompanies()
        {
            foreach (var item in companies)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }
    }
    public interface ICompany
    {
        void ShowAllCompanies();
        void GetCompaniesInNameIsFood();
        void GetMarketingCompanies();
        void GetMarketingAndItCompanies();
        void GetMoreThan100WorkersCompanies();
        void GetFrom100to300WorkersCompanies();
        void CompaniesPlacedInLondon();
        void CompaniesDirectorWhite();
        void CompaniesMoreThanTwoYearsAgoCreated();
        void CompaniesMoreThan123DaysAgoCreated();
        void RequestFromHELL();
    }
}

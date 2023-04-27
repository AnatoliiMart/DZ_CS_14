namespace DZ_CS_14
{
    public class Company
    {
        public string CompanyName { get; private set; }

        public string directorName { get; private set; }

        public string CompanyAdress { get; private set; }

        public string buisnessProfile { get; private set; }

        public int amountOfWorkers { get; private set; }

        public Worker[] workers;
        public DateTime dateOfCreation { get; private set; }

        public Company(string CompanyName, string directorName, string CompanyAdress,
                    string businesProfile, int amountOfWorkers, DateTime dateOfCreation, Worker[] workers )
        {
            this.CompanyName = CompanyName;
            this.directorName = directorName;
            this.CompanyAdress = CompanyAdress;
            this.buisnessProfile = businesProfile;
            this.amountOfWorkers = amountOfWorkers;
            this.dateOfCreation = dateOfCreation;
            this.workers = workers;
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

        public void CompaniesMoreThan123DaysAgoCreated()
        {
            var res = from item in companies
                      where (DateTime.Today.Day - item.dateOfCreation.Day) <= 123
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

        public void GetAllWorkersManagers()
        {
            throw new NotImplementedException();
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
            foreach (Company item in res)
                Console.WriteLine(item.ToString());
            Console.WriteLine("------------------------------------------------");
        }

        public void GetWorkersByCompanyName(string companyName)
        {
           var res = from c in companies
                     where c.CompanyName == companyName
                     select c.workers;

            Console.WriteLine("All workers of company: " + companyName);

            foreach (Worker[] item in res)
                ShowWorkers(item);
            Console.WriteLine("------------------------------------------------");
        }

        public void GetWorkersByFirmNameAndSalary(string companyName, int salarySize)
        {
            var res = from c in companies
                      where c.CompanyName.Contains(companyName)
                      select c.workers;
            foreach (Worker[] item in res)
            {
                var res1 = from w in item
                          where w.Salary >= salarySize
                          select w;
                foreach (Worker item1 in res1)
                    Console.WriteLine(item1.ToString());
            }
            Console.WriteLine("------------------------------------------------");
        }

        public void GetWorkersEMailBeginBy_di_()
        {
           IEnumerable<Worker[]>res = from c in companies
                      select c.workers;
            foreach (Worker[] item in res)
            {
                var res1 = from w in item
                           where w.EMail.Contains("di")
                           select w;
                foreach(Worker item1 in res1)
                    Console.WriteLine(item1.ToString());
            }
        }

        public void GetWorkersName_Lionel()
        {
            var res = from c in companies
                      select c.workers;
            foreach (Worker[] item in res)
            {
                var res1 = from w in item
                           where w.Name.Contains("Lionel")
                           select w;
                foreach (Worker item1 in res1)
                    Console.WriteLine(item1.ToString());
            }
        }

        public void GetWorkersNumberBeginBy23()
        {
            var res = from c in companies
                      select c.workers;
            foreach (Worker[] item in res)
            {
                var res1 = from w in item
                           where w.Phone.Contains("23")
                           select w;
                foreach (Worker item1 in res1)
                    Console.WriteLine(item1.ToString());
            }
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

        private void ShowWorkers(Worker[] workers)
        {
            foreach (Worker item in workers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("************************************");
            }
            
        }
    }

    public class Worker
    {
        public string Name     {get; private set;}
        public string JobTitle { get; private set;}
        public string Phone    { get; private set;}
        public string EMail    { get; private set;}
        public int    Salary   { get; private set;}
        public Worker()
        {
            Name = "noName";
            JobTitle = "noTitle";
            Phone = "0000000000000";
            EMail = "noEMail";
            Salary = 0;
        }
        public Worker(string name, string jobTitle, string phone, string Email, int salary)
        {
            Name = name;
            JobTitle = jobTitle;
            Phone = phone;
            EMail = Email;
            Salary = salary;          
        }
        public override string ToString()
        {
            return $"Name:\t{Name}\n" +
                   $"Job title:\t{JobTitle}\n" +
                   $"Phone:\t{Phone}\n" +
                   $"EMail:\t{EMail}\n" +
                   $"Salary:\t{Salary}\n";
        }
    }
    public interface IWorker
    {
        //void ShowWorkers(Worker[] workers);
       
        void GetWorkersByCompanyName(string companyName);
        void GetWorkersByFirmNameAndSalary(string companyName ,int salarySize);
        void GetAllWorkersManagers();
        void GetWorkersNumberBeginBy23();
        void GetWorkersEMailBeginBy_di_();
        void GetWorkersName_Lionel();
    }
    public interface ICompany : IWorker
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

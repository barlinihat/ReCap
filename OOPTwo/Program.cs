// See https://aka.ms/new-console-template for more information
using OOPTwo;

Console.WriteLine("Hello, World!");


Customer customerOne = new Customer();



IndividualCustomer ındividualCustomer = new IndividualCustomer();
ındividualCustomer.Id = 1;
ındividualCustomer.CustomerNo = "12345";
ındividualCustomer.Name = "Robert";
ındividualCustomer.LastName = "Mikela";
ındividualCustomer.TcNo = "12345678910";

CorporateCustomer corporateCustomer = new CorporateCustomer();
corporateCustomer.Id = 2;
corporateCustomer.CustomerNo = "54321";
corporateCustomer.CompanyName = "code.dev";
corporateCustomer.TaxNo = "98765432110";

Customer customerThree = new IndividualCustomer();
Customer customerFour = new CorporateCustomer();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(customerOne);
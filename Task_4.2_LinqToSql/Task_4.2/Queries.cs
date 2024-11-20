using System;
using System.Linq;
using System.Data.Linq;

namespace Task_4._2
{
    public  class Queries
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public void QueriesRunner()
        {
            SelectFromTable();
            InsertIntoTable();
            UpdateTable();
            DeleteFromTable();
            RunStoredProcedure();
        }
        // Selecting from the table Customers 
        void SelectFromTable()
        {
            Table<Customer> Customers = db.GetTable<Customer>();
            var customerQuery =
                 from customer in Customers
                 where customer.ContactTitle == "Owner"
                 select customer;
            try
            {
                foreach (Customer customer in customerQuery)
                {
                    Console.WriteLine("ID={0}, City={1}", customer.CustomerID,
                        customer.City);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error during execution of Select query");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

        // inserting into Employees table
        void InsertIntoTable()
        {
            Table<Employee> Employees = db.GetTable<Employee>();
            Employee employee = new Employee();
            employee.FirstName = "Jack";
            employee.LastName = "Sparrow";
            employee.Title = "Captain";
            employee.City = "Moscow";
            Employees.InsertOnSubmit(employee);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error during execution of Insert query");
                Console.WriteLine(e.Message);
            }
        }

        // updating name of a city in Customer table
        void UpdateTable()
        {
            var cityNameQuery =
                from customer in db.Customers
                where customer.City.Contains("Berlin")
                select customer;

            foreach (var customer in cityNameQuery)
            {
                if (customer.City == "Berlin")
                {
                    customer.City = "Berlin Forever";
                }
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error during execution of Update query");
                Console.WriteLine(e.Message);
            }
        }

        // deleting the previously inserted record from Customers table
        void DeleteFromTable()
        {
            var deleteNewEmployee =
                from employee in db.Employees
                where employee.LastName == "Sparrow"
                select employee;

            if (deleteNewEmployee.Count() > 0)
            {
                db.Employees.DeleteOnSubmit(deleteNewEmployee.First());
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error during execution of Delete query");
                    Console.WriteLine(e.Message);
                }
            }
        }

        //using stored procedure CustOrdersDetail
        void RunStoredProcedure()
        {
            var productDetail = db.CustOrdersDetail(10248);
            try
            {
                foreach (CustOrdersDetailResult product in productDetail)
                {
                    Console.WriteLine("Product=" + product.ProductName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error during execution of stored procedure CustOrdersDetail");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

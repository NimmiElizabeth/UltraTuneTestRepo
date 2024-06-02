using Microsoft.VisualBasic;
using SampleConsoleApp.Question_1;
using SampleConsoleApp.Question_2;
using SampleConsoleApp.Question_5;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //Inheritance
            Rectangle rectangle = new Rectangle(4.5, 5.0);
            var rArea = rectangle.Area();
            Console.WriteLine($"Area of rectangle = {rArea}");

            Triangle triangle = new Triangle(2.3, 6.7);
            var tArea = triangle.Area();
            Console.WriteLine($"Area of triangle = {tArea}");

            //Compile-time Polymorphism
            //Method overriding
            Calculator calculator = new Calculator();
            Console.WriteLine($"Result 1 = {calculator.Add(2, 3)}");
            Console.WriteLine($"Result 2 = {calculator.Add(2, 3, 4)}");
            Console.WriteLine($"Result 3 = {calculator.Add(2.5, 3.9)}");

            //Operator overriding
            MyString s1 = new MyString("Hello");
            MyString s2 = new MyString(" World!");
            MyString result = s1 + s2;
            Console.WriteLine("Concatenated string:" + result.Value);

            //Run-time Polymorphism
            Shape rec = new Rectangle(2.5, 5.4);
            var recArea = rec.Area();
            Console.WriteLine($"Area of rectangle = {recArea}");

            //Encapsulation
            Person person = new Person(name: "Mark", age: 35);
            Console.WriteLine($"Name: {person.GetName()} Age: {person.GetAge()}");

            person.SetAge(-20);

            #endregion Question 1

            #region Question 2

            //Implement a method to retrieve all records from a SQL Server database table named `Products` using Dapper ORM.
            //Entity Framework is used instead of Dapper

            ProductService productService = new ProductService();
            productService.AddProducts(new List<Product>(){
                new Product(){ Id = 1001, Name = "Shirt", Description = "Cotton" },
                new Product(){ Id = 1002, Name = "Dress", Description = "Silk" } }
            );
            var products = productService.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine(string.Join(",", product.Name));
            }
            #endregion Question 2

            #region Question 5

            //Write an asynchronous method to read all lines from a text file and return them as a list of strings.
            var data = Task.Run(() => FileRead.ReadFile());
            Task.WaitAll(data);
            Console.WriteLine(string.Join("\n", data.Result));

            #endregion Question 5
        }
    }
}

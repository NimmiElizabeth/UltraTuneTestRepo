//Encapsulation is binding the properties and methods defining an object into a single unit called class. 
//Hides the internal implementation of private fields of the object and can be accessed or modified only through provide public methods or interface.

namespace SampleConsoleApp.Question_1
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age should be greater then 0");
            }
        }
        public int GetAge()
        {
            return age;
        }
    }
}

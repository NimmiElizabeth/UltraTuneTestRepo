//Polymorphism is the ability of objects to take multiple forms or behaviors based on their context.

//There is two types of Polymorphism
//1. Compile-time Polymorphism
//2. Run-time Polymorphism

//1. Compile-time Polymorphism
//This occurs when a method or function to be invoked is determined at the compile-time.
//Is done through method overloading or operator overloading.
//Method overloading allows to have multiple methods in a class with same name but different parameters.
//Operator overloading allows operators to have different meanings depending on the context they are used.


//2. Run-time Polymorphism
//This occurs when method or function to be invoked is determined at the runtime.
//It is achieved through method overriding and interface implementation.
//Method overriding allows a subclass to provide an implementation to a method in superclass by overriding it.
//When the method is called using an object of the subclass the overridden method is executed.
//Interface implementation allows different classes to implement the methods of same interface and provide their own implementation.
namespace SampleConsoleApp.Question_1
{
    /// <summary>
    /// Method overriding
    /// </summary>
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    /// <summary>
    /// Operator overriding
    /// </summary>
    public class MyString
    {
        public string Value { get; set; }
        public MyString(string value)
        {
            Value = value;
        }
        public static MyString operator +(MyString a, MyString b)
        {
            return new MyString(a.Value + b.Value);
        }
    }
}

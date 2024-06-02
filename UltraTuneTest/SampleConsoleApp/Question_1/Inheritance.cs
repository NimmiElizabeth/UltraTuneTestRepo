//Inheritance in one of the main Object-Oriented principle.
//Inheritance allows a class to reuse, extend or modify the members from another class.
//The class from which a class is inherited is called the base / parent class and the class inherits is called the child / derived class.
//In C# classes can be inherited from only a single class and can inherit multiple interfaces.

namespace SampleConsoleApp.Question_1
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public virtual double Area()
        {
            return Width * Height;
        }
    }

    /// <summary>
    /// Rectangle child class
    /// </summary>
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }
    }

    /// <summary>
    /// Triangle child class
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }
        public override double Area()
        {
            return 0.5 * Width * Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaitapCsharp1

{
    
    abstract class Shape
    {
        public abstract double CalculateArea();        
        public abstract double CalculatePerimeter();   
    }

    
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Nhap so do cho hinh chu nhat:");
            Console.Write("Nhap chieu rong: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap chieu cao: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Shape rectangle = new Rectangle(width, height);
            Console.WriteLine("Hinh chu nhat:");
            Console.WriteLine("Dien tich: " + rectangle.CalculateArea());
            Console.WriteLine("Chu vi: " + rectangle.CalculatePerimeter());

            
            Console.WriteLine("\nNhap so do cho hinh tron:");
            Console.Write("Nhap ban kinh: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Shape circle = new Circle(radius);
            Console.WriteLine("Hinh tron:");
            Console.WriteLine("Dien tich: " + circle.CalculateArea());
            Console.WriteLine("Chu vi: " + circle.CalculatePerimeter());
        }
    }
}


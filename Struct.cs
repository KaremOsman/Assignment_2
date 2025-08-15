using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    #region Q_1
    //internal struct Person
    //{
        //public string? Name { get; set; }  //the '?' allows Name to be null ==> it's very important
        //public int Age { get; set; }

        //public Person()
        //{
            //Name = default;
            //Age = default;
        //}
        //public override string ToString()
        //{
            //return $"Name : {Name} , Age : {Age} ";
        //}
    //}
    #endregion

    #region Q_2

    internal struct Point
    {
       public double X { get; set; }
       public double Y { get; set; }
       public Point(double x, double y)
       {
           X = x;
           Y = y;
       }
       public override string ToString()
       {
           return $"( {X} , {Y} )";
       }
    }

    #endregion

    #region Q_3

    internal struct Person
    {
        private string? Name { get; set; }
        public int Age { get; set; }
        private string? Address { get; set; }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age} , Address : {Address}";
        }
    }


    #endregion

    #region Q_4

    internal struct Rectangle
    {
        private double width;
        private double height;
        
        
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Error : Width Can't be Nigative Or Zerro");
                }
            }
            get { return Width; }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Error : Height Can't be Nigative Or Zerro");
                }
            }
            get { return height; }
        }
        public double Area
        {
            get { return width * height; } 
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override string ToString()
        {
            return $"Width : {Width} , Height : {Height} , Area : {Area}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Width is : {width}");
            Console.WriteLine($"Height is : {height}");
            Console.WriteLine($"Area is : {Area}");
        }
    }

    #endregion
    
}

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q_1
            //Define a struct "Person" with properties "Name" and "Age".
            //Create an ‎array of three "Person" objects and populate it with data.
            //Then, write a C# ‎program to display the details of all the persons in the array.‎


            //SOL


            //Person[] Persons =
            //{
            //new Person { Name = "Alice", Age = 30 },
            //new Person { Name = "Bob", Age = 25 },
            //new Person { Name = "Charlie", Age = 35 }
            //};
            //foreach (var person in Persons)
            //{
            //Console.WriteLine(person);
            //} 
            #endregion

            #region Q_2
            //‎Create a struct called "Point" to represent a 2D point
            //with properties "X" ‎and   "Y". Write a C# program that
            //takes two points as input from the user ‎and calculates the distance between them.‎



            //sol



            //bool Check1;
            //bool Check2;
            //double Distance;

            //int X1 , Y1 ,X2 , Y2 ;
            //do
            //{
            //Console.Write($"Enter Value Of Two Point :\n X1 = ");
            //Check1 = int.TryParse(Console.ReadLine(), out X1);
            //Console.Write($" Y1 = ");
            //Check2 = int.TryParse(Console.ReadLine(), out Y1);
            //Console.Write($" X2 = ");
            //Check2 = int.TryParse(Console.ReadLine(), out X2);
            //Console.Write($" Y2 = ");
            //Check2 = int.TryParse(Console.ReadLine(), out Y2);
            //}while (!Check1 && !Check2);

            //Point p1 = new Point(X1, Y1);
            //Console.WriteLine($"your First Point : {p1}");

            //Point p2 = new Point(X2, Y2);
            //Console.WriteLine($"your Second Point : {p2}");

            //Distance = Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2));
            //Console.WriteLine($"Distance Between Two Point = {Distance} cm");

            #endregion

            #region Q_3
            //‎3.‎	Create a struct called "Person" with properties "Name" and "Age".
            //Write a ‎C# program that takes details of 3 persons as input from the user
            //and ‎displays the name and age of the oldest person.‎

            //sol

            //int age;
            //string? name = null , address = null;
            //Person[] person = new Person[3];

            //for (int i = 0; i < person.Length; i++)
            //{
            //do
            //{Console.WriteLine($"Enter Name Of Person {i + 1}");
            //name = Console.ReadLine();
            //}while(string.IsNullOrWhiteSpace(name));
            //do
            //{Console.WriteLine($"Enter Age Of Person {i + 1}");
            //int.TryParse(Console.ReadLine(), out age);
            //}while(age <= 0);
            //do
            //{ Console.WriteLine($"Enter Address Of Person {i + 1 }");
            //address = Console.ReadLine();
            //}while(string.IsNullOrWhiteSpace(address));
            //person[i] = new Person(name, age, address);
            //}

            //Person Oldest = person[0];
            //Console.WriteLine("The Persons are : ");
            //for (int i = 0 ; i < person.Length; i++)
            //{
            //Console.WriteLine(person[i]);

            //if (person[i].Age > Oldest.Age)
            //{
            //Oldest = person[i];
            //}
            //}
            //Console.WriteLine($"The Oldest person is : \n {Oldest}");
            #endregion

            #region Q_4
            ///Create a struct named Rectangle that represents a rectangle with the ‎following fields:‎
            ///width(type: double)‎
            ///height(type: double)‎
            ///Implement encapsulation by making the fields private and provide ‎public properties access
            ///and modify these values.Ensure the following ‎conditions are met:‎
            ///The width and height should not be negative. If a negative value is ‎provided,
            ///the setter should not update the field and should instead print ‎an error message.‎
            ///Implement a public read-only property Area that calculates and returns ‎the area of 
            ///the rectangle(Area = width * height).‎
            ///Implement a method DisplayInfo that prints the rectangle's dimensions ‎and area.‎
            ///Write a program to demonstrate the usage of this struct by creating an ‎instance,
            ///setting values via properties, and displaying the area‎



            //sol

            //Rectangle rect = new Rectangle();// Create an instance of Rectangle

            //rect.Width = 5.0;// Set the width
            //rect.Height = 10.0;// Set the height

            //rect.DisplayInfo();// Display the rectangle's information


            #endregion

        }
    }
}

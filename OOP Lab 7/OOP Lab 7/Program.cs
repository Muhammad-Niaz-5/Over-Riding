using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_7
{
    class Vehicle
    {
        public int doors;   //Data Member
        public string color, engine, model;     //Data Members
        public int starting_speed, final_speed, time;
        public Vehicle()    //Default Constructor
        {

        }
        public Vehicle(string model, string color, string engine, int door)      //Parameterized Constructor
        {
            this.model = model;
            this.color = color;
            this.engine = engine;
            this.doors = door;
        }
        public void Start()     //Function
        {
            Console.WriteLine("Input The Starting Speed of Vehicle: ");
            starting_speed = int.Parse(Console.ReadLine());
        }
        public void Stop()    //Function
        {
            Console.WriteLine("Input The Ending Speed of Vehicle: ");
            final_speed = int.Parse(Console.ReadLine());
        }
        public void Run()     //Function
        {
            Console.WriteLine("Input The Time Taken: ");
            time = int.Parse(Console.ReadLine());

        }
        public virtual void CalculateSpeed()
        {

        }
    }

    class Bike : Vehicle    //Inheritance
    {
        public Bike(string m, string c, string e, int d) : base(m, c, e, d)     //Parameterized Constructor Inherited
        {

        }
        public override void CalculateSpeed()   //Overriding
        {
            int speed;
            speed = (starting_speed + final_speed) / time;
            Console.WriteLine("The Vehicle is a Bike");
            Console.WriteLine("Total Speed of Bike is: " + speed);
        }
    }

    class Car : Vehicle     //Inheritance
    {
        public Car(string m, string c, string e, int d) : base(m, c, e, d)      //Parameterized Constructor Inherited
        {

        }
        public override void CalculateSpeed()    //Overriding
        {
            int speed;
            speed = (starting_speed + final_speed) / time;
            Console.WriteLine("The Vehicle is a Car");
            Console.WriteLine("Total Speed of Car is: " + speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Engine Of Vehicle: ");
            string engine = Console.ReadLine();
            Console.WriteLine("Input the Model of Vehicle: ");
            string model = Console.ReadLine();
            Console.WriteLine("Input the Color of Vehicle: ");
            string color = Console.ReadLine();
            Console.WriteLine("Input the No Of Doors of The Vehicle: ");
            int doors = int.Parse(Console.ReadLine());
            if (doors == 4)
            {
                Car c = new Car(model, color, engine, doors);
                c.Start();
                c.Stop();
                c.Run();
                c.CalculateSpeed();
            }
            else if (doors == 0)
            {
                Bike b = new Bike(model, color, engine, doors);
                b.Start();
                b.Stop();
                b.Run();
                b.CalculateSpeed();
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Properties_Smith_Luke
{
    //creates car class
    class Cars
    {
        //model
        public string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        //make
        public string Make
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creates two car objects
            Cars MyCar = new Cars();
            Cars MyOtherCar = new Cars();

            //asks for a make and model of a car
            Console.WriteLine("List the model of a car, then list that car's make");
            MyCar.Model = Console.ReadLine();
            MyCar.Make = Console.ReadLine();

            //asks for a make and model of a car
            Console.WriteLine("List the model of another car, then list that car's make");
            MyOtherCar.Model = Console.ReadLine();
            MyOtherCar.Make = Console.ReadLine();

            //prints the make and model of your cars
            Console.WriteLine($"Your car's model is {MyCar.Model} and its make is {MyCar.Make}");
            Console.WriteLine($"Your other car's model is {MyOtherCar.Model} and its make is {MyOtherCar.Make}");
        }
    }
}

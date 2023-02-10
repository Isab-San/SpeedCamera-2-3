namespace Week3Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the speed limit in mph: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Car c = new Car();

            Console.WriteLine("Enter your first car's make: ");
                c.make = Console.ReadLine();

                Console.WriteLine("Enter your first car's model: ");
                c.model = Console.ReadLine();

                Console.WriteLine("Enter the speed of your first car in mph: ");
                c.speed = Convert.ToInt32(Console.ReadLine());

            ///  Console.WriteLine(c.make + " " + c.model + " " + c.speed + "mph");
              

            int amountOver = c.speed - speedLimit;
            int numDemerits = amountOver / 5;

            if (c.speed <= speedLimit)
            {
                Console.WriteLine(c.make + " " + c.model + " " + c.speed + "mph:" + " OK");
            }
            else if (numDemerits >= 10)
            {
                Console.WriteLine(c.make + " " + c.model + " " + c.speed + "mph:" + " <LICENSE SUSPENDED>");
            }
            else
            {
                Console.WriteLine(c.make + " " + c.model + " " + c.speed + "mph: " + numDemerits + " demerits");
            }
            

            Car c2 = new Car();
                Console.WriteLine("Enter your second car's make: ");
                c2.make = Console.ReadLine();

                Console.WriteLine("Enter your second car's model: ");
                c2.model = Console.ReadLine();

                Console.WriteLine("Enter the speed of your second car in mph: ");
                c2.speed = Convert.ToInt32(Console.ReadLine());


            amountOver = c2.speed - speedLimit;
            numDemerits= amountOver / 5;

            if (c2.speed <= speedLimit)
            {
                Console.WriteLine(c2.make + " " + c2.model + " " + c2.speed + "mph:" + " OK");
            }
            else if (numDemerits >= 10)
            {
                Console.WriteLine(c2.make + " " + c2.model + " " + c2.speed + "mph:" + " <LICENSE SUSPENDED>");
            }
            else
            {
                Console.WriteLine(c2.make + " " + c2.model + " " + c2.speed + "mph: " + numDemerits + " demerits");
            }


            Car c3 = new Car();
                Console.WriteLine("Enter your third car's make: ");
                c3.make = Console.ReadLine();

                Console.WriteLine("Enter your third car's model: ");
                c3.model = Console.ReadLine();

                Console.WriteLine("Enter the speed of your third car in mph: ");
                c3.speed = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(c3.make + " " + c3.model + " " + c3.speed);

            amountOver = c3.speed - speedLimit;
            numDemerits = amountOver / 5;

            if (c3.speed <= speedLimit)
            {
                Console.WriteLine(c3.make + " " + c3.model + " " + c3.speed + "mph:" + " OK");
            }
            else if (numDemerits >= 10)
            {
                Console.WriteLine(c3.make + " " + c3.model + " " + c3.speed + "mph:" + " <LICENSE SUSPENDED>");
            }
            else
            {
                Console.WriteLine(c3.make + " " + c3.model + " " + c3.speed + "mph :" + numDemerits + " demerits");
            }
        }
    }

    public class Car
    {

        public string make;

        public string model;

        public int speed;

    }
}
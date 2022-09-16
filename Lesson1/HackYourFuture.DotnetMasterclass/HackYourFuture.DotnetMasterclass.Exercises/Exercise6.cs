namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise6
    {
        // Write a method that takes the radius of a circle as input and calculate the perimeter and area of the circle
        // https://www.w3resource.com/w3r_images/charp-area-of-a-circle-exercise-1.png
        // Circumference => 2πr
        // Area => πr²
        public static void CaclulateThePerimeterOfACircleBasedOnTheRadius()
        {
            Console.WriteLine("Enter the radius of a circle in cm: ");
            var radiusText = Console.ReadLine();
            double radius;
            while (!double.TryParse(radiusText, out radius))
            {
                Console.Write("Enter a valid radius of a circle: ");
                radiusText = Console.ReadLine();
            }

            Console.WriteLine($"The perimeter of the circle is: {2 * Math.PI * radius} cm");
            Console.WriteLine($"The area of the circle is: {Math.PI * Math.Pow(radius, 2)} cm²");

            Console.ReadLine();
        }
    }
}
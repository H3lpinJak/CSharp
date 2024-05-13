using AreaOfCircle;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Please enter the radius of your circle.");

double radius;
do {
Console.WriteLine("Radius: ");
string input = Console.ReadLine();
if (input == "" || !double.TryParse(input, out double value))
{
    Console.WriteLine("Exiting program...");
    Environment.Exit(0);
}
radius = double.Parse(input);
if(radius < 0)
{
    Console.WriteLine("Radius can't be negative, try again.");
} 

} while (radius < 0);


Console.WriteLine("A circle with a radius of {radius}mi has an area of {Circle.Area(radius)} square mi,");
Console.WriteLine("a circumference of {Circle.Circumference(radius)} mi,");
Console.WriteLine("and a diameter of {Circle.Diameter(radius)}mi.");
Console.WriteLine("What is your car's mpg?");

string? mpgStr = Console.ReadLine();
double mpg = double.Parse(mpgStr);

double gallonsToCircumnavitage = Circle.Circumference(radius) / mpg;

Console.WriteLine("Your car will need {gallonsToCircumnavigate} gallons of gas ti get around the circle.");

// Console.WriteLine("The Circumference is " + Circumference);
// Console.WriteLine("The Diameter is " + Diameter);
 
// Console.WriteLine("What is the MPG of your car? ");
// double mpg = double.Parse(Console.ReadLine());

// double gallons = Calculations.AreaOfCircle(Circumference) / mpg;

// double Number = Circumference / mpg;
// Console.WriteLine("The car's MPG is" + Number);


namespace AreaOfCircle;

public class Circle
 {
    public static double Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
    public static double Diameter(double radius)
    {
        return radius * 2;
    }
//     public double Radius {get;set;}
//     private double Diameter
//     public double Area
//     {
//         get {return Area; }
//         set { Area = Math.PI * Math.Pow(Radius, 2); }
//         // double Radius = double.Parse(Console.ReadLine());
//         // double Area = 3.14 * Radius * Radius;

//         // double Circumference = 2 * 3.14 * Radius;
//         // double Diameter = 2 * Radius;
//     }
}

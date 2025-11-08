/* Practical 2
 * Information: Methods Demo (CircleAreaMethod)
 * Version 1
 * Author: Darren Smyth
 * Date: October 8th 2025
 */

using System;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Please enter the radius of the circle you wish to calculate the area of: ");
        double radius = CircleArea(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine($"The area of the circle is: {radius}.");
    }

    private static double CircleArea(double radius)
    {
        radius = Math.PI * Math.Pow(radius, 2);
        return radius;
    }
}
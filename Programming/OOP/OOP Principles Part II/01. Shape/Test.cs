/*Task 01. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
 Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
 (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor 
 so that at initialization height must be kept equal to width and implement the CalculateSurface() method. 
 Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
 (Circle, Rectangle, Triangle) stored in an array.
*/

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Circle(2),
            new Rectangle(5.5, 17),
            new Triangle(2.5, 7.1),
            new Circle(14),
            new Triangle(5.4, 11),
            new Rectangle(4.2, 8.1) 
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}

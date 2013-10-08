/*Tasks 01-04:
01. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
Implement the ToString() to enable printing a 3D point.
02. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
Add a static property to return the point O.
03. Write a static class with a static method to calculate the distance between two points in the 3D space.
04. Create a class Path to hold a sequence of points in the 3D space. 
Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
*/

using System;

public static class Test
{
    private static void Main()
    {
        var coordinate = new Point(2, 8, 4);

        Console.WriteLine(coordinate);
        Console.WriteLine(Point.Start);
        Console.WriteLine(Distance.CalculateDistance(coordinate, Point.Start));

        Path path = new Path(new Point(3, 1, 8), new Point(15, 5.2, 6), new Point(8, 6.3, 4));
        Console.WriteLine(path.ToString());

        PathStorage.Save(path, "../../save.txt"); 
        
        Path path2 = new Path();
        path2 = PathStorage.Load("../../load.txt");
        PathStorage.Save(path2, "../../save.txt");      
    }
}
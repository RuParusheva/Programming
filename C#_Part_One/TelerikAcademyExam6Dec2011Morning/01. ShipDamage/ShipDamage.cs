using System;

class ShipDamage
{
    static void Main()
    {
        int shipX1 = int.Parse(Console.ReadLine());
        int shipY1 = int.Parse(Console.ReadLine());
        int shipX2 = int.Parse(Console.ReadLine());
        int shipY2 = int.Parse(Console.ReadLine());

        int horizon = int.Parse(Console.ReadLine());

        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());
    
        //collision coordinates, modified based on horizon value
        cy1 = 2 * horizon - cy1;
        cy2 = 2 * horizon - cy2;
        cy3 = 2 * horizon - cy3;

        int damage = 0;

        //this way, when checking we make two checks instead of four, cause we pull only one value of intrest
        int maxX = Math.Max(shipX1, shipX2);
        int minX = Math.Min(shipX1, shipX2);
        int maxY = Math.Max(shipY1, shipY2);
        int minY = Math.Min(shipY1, shipY2);

        if ((cx1 == maxX || cx1 == minX) && (cy1 == minY || cy1 == maxY))
        {
            damage += 25;
        }
        if ((cx2 == maxX || cx2 == minX) && (cy2 == minY || cy2 == maxY))
        {
            damage += 25;
        }
        if ((cx3 == maxX || cx3 == minX) && (cy3 == minY || cy3 == maxY))
        {
            damage += 25;
        }
        if (((cx1 == minX || cx1 == maxX) && (cy1 < maxY && cy1 > minY)) ||
            (cy1 == minY || cy1 == maxY) && (cx1 < maxX && cx1 > minX))
        {
            damage += 50;
        }
        if (((cx2 == minX || cx2 == maxX) && (cy2 < maxY && cy2 > minY)) ||
            (cy2 == minY || cy2 == maxY) && (cx2 < maxX && cx2 > minX))
        {
            damage += 50;
        }
        if (((cx3 == minX || cx3 == maxX) && (cy3 < maxY && cy3 > minY)) ||
            (cy3 == minY || cy3 == maxY) && (cx3 < maxX && cx3 > minX))
        {
            damage += 50;
        }
        if (cx1 > minX && cx1 < maxX && cy1 > minY && cy1 < maxY)
        {
            damage += 100;
        }
        if (cx2 > minX && cx2 < maxX && cy2 > minY && cy2 < maxY)
        {
            damage += 100;
        }
        if (cx3 > minX && cx3 < maxX && cy3 > minY && cy3 < maxY)
        {
            damage += 100;
        }
        Console.WriteLine("{0}%", damage);
    }
}

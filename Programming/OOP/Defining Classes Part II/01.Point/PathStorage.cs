using System.IO;

public class PathStorage
{
    public static void Save(Path path, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine(path);
        }
    }

    public static Path Load(string filePath)
    {
        Path sequence = new Path();

        using (var reader = new StreamReader(filePath))
        {
            var line = reader.ReadLine();

            while (line!= null)
            {
                var splitted = line.Split(',');

                double x = double.Parse(splitted[0]);
                double y = double.Parse(splitted[1]);
                double z = double.Parse(splitted[2]);

                Point point = new Point(x, y, z);

                sequence.AddPoint(point);
                line = reader.ReadLine();
            }

            return sequence;
        }
    }
}
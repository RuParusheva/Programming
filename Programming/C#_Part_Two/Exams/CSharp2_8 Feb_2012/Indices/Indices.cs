    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;

    class Indices
    {
        static void Main()
        {
    #if DEBUG
            Console.SetIn(new StreamReader("../../input.txt"));
    #endif
            Console.ReadLine();
            var arrayString = Console.ReadLine();
            var array = Array.ConvertAll(arrayString.Split(), int.Parse);

            var result = new List<string>();
            bool[] visited = new bool[array.Length];

            for (int i = 0; ; )
            {
                int current = array[i];

                if (current >= array.Length || current < 0)
                {
                    result.Add(i.ToString());
                    break;
                } 
               
                if (visited[i])
                {
                    int position = result.IndexOf(i.ToString()) - 1;
                    if (position > 0)
                    {
                        result[position] = "(";
                    }
                    else
                    {
                        result.Insert(0, "(");
                    }
                    result.RemoveAt(result.Count - 1);
                    result.Add(")");
                    break;
                }

                visited[i] = true;

                result.Add(i.ToString());
                result.Add(" ");

                i = current;
            }

            Console.WriteLine(string.Concat(result));
        }
    }

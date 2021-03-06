using System;

namespace ADTs
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Graph();
            map.AddVertex(1);
            map.AddVertex(2);
            map.AddVertex(3);
            map.AddVertex(4);
            map.AddVertex(5);
            map.AddVertex(6);
            map.AddVertex(7);
            map.AddEdge(1, 2);
            map.AddEdge(1, 3);
            map.AddEdge(2, 4);
            map.AddEdge(3, 4);
            map.AddEdge(4, 5);
            map.AddEdge(4, 6);
            map.AddEdge(5, 6);
            map.AddEdge(6, 7);
            map.AddEdge(4, 7);
            map.RemoveVertex(6);

            Console.WriteLine("1:" + string.Join(',', map.Neighbors(1)));
            Console.WriteLine("2:" + string.Join(',', map.Neighbors(2)));
            Console.WriteLine("3:" + string.Join(',', map.Neighbors(3)));
            Console.WriteLine("4:" + string.Join(',', map.Neighbors(4)));
            Console.WriteLine("5:" + string.Join(',', map.Neighbors(5)));
            Console.WriteLine("6:" + string.Join(',', map.Neighbors(6)));
            Console.WriteLine("7:" + string.Join(',', map.Neighbors(7)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;



namespace ConsoleApp14
{

    class Program
    {
        static Dictionary<int, int> rooms = new Dictionary<int, int>();
        static Stack<int> whiteTiles = new Stack<int>();
        static Queue<int> grayTiles = new Queue<int>();
        static int newFormed;

        static void PrintWhiteLeft()
        {
            string whiteTilesLeft = "White tiles left: ";
            while (whiteTiles.Count != 0)
            {
                if (grayTiles.Count != 1)
                    whiteTilesLeft += (int)whiteTiles.Pop() + ", ";
                else
                    whiteTilesLeft += (int)whiteTiles.Pop();
            }
            Console.WriteLine(whiteTilesLeft);
            Console.WriteLine("Grey tiles left: none");

        }


        static void PrintGrayLeft()
        {
            Console.WriteLine("White tiles left: none");

            string grayTilesLeft = "Grey tiles left: ";
            while (grayTiles.Count != 0)
            {
                if (grayTiles.Count != 1)
                    grayTilesLeft += (int)grayTiles.Dequeue() + ", ";
                else
                    grayTilesLeft += (int)grayTiles.Dequeue();

            }
            Console.WriteLine(grayTilesLeft);
        }

        public static bool CheckEquality(int whiteTile, int grayTile)
        {
            if (whiteTile == grayTile)
                return true;
            return false;
        }
        public static bool CheckRooms(int largerTile)
        {
            if (rooms.ContainsKey(largerTile))
            {
                rooms[largerTile]++;
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintDefault()
        {
            Console.WriteLine("White tiles left: none");
            Console.WriteLine("Grey tiles left: none");
        }

        static void PrintRooms()
        {
            Dictionary<string, int> printRooms = new Dictionary<string, int>();
            printRooms.Add("Countertop", 0);
            printRooms.Add("Oven", 0);
            printRooms.Add("Sink", 0);
            printRooms.Add("Wall", 0);
            printRooms.Add("Floor", 0);

            printRooms["Sink"] = rooms[40];
            printRooms["Oven"] = rooms[50];
            printRooms["Countertop"] = rooms[60];
            printRooms["Wall"] = rooms[70];
            printRooms["Floor"] = newFormed;

            Dictionary<string, int> finalPrint = printRooms.Where(s => s.Value != 0).OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var f in finalPrint)
            {
                Console.WriteLine($"{f.Key}: {f.Value}");
            }
        }

        static void Main(string[] args)
        {
            rooms.Add(40, 0);
            rooms.Add(50, 0);
            rooms.Add(60, 0);
            rooms.Add(70, 0);

            List<int> whiteTileser = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> grayTileser = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            foreach (var w in whiteTileser)
            {
                whiteTiles.Push(w);
            }
            foreach (var g in grayTileser)
            {
                grayTiles.Enqueue(g);
            }

            while (true)
            {
                if (whiteTiles.Count == 0 && grayTiles.Count != 0)
                {
                    PrintGrayLeft();
                    break;
                }
                if (grayTiles.Count == 0 && whiteTiles.Count != 0)
                {
                    PrintWhiteLeft();
                    break;
                }
                if (whiteTiles.Count == 0 && grayTiles.Count == 0)
                {
                    PrintDefault();
                    break;
                }
                bool checker = CheckEquality((int)whiteTiles.Peek(), (int)grayTiles.Peek());

                if (checker)
                {
                    int largerTile = (int)whiteTiles.Pop() + (int)grayTiles.Dequeue();
                    bool roomChecker = CheckRooms(largerTile);
                    if (!roomChecker)
                        newFormed++;
                }
                else
                {
                    int changedWhite = (int)whiteTiles.Pop() / 2;
                    int changedGray = (int)grayTiles.Dequeue();
                    whiteTiles.Push(changedWhite);
                    grayTiles.Enqueue(changedGray);
                }
            }
            PrintRooms();
        }
    }
}
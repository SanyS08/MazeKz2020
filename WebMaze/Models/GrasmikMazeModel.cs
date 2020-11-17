using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.Models
{
    public enum TypesCells
    {
        Groud = 1,
        Wall = 2,
        Coin = 3
    }

    public class GrasmikMazeModel
    {
        public MazeGenerator mazeGenerator = new MazeGenerator();
        public Maze MainMaze;
    }

    public class MazeGenerator
    {

        Random rand = new Random();

        public Maze GenerateRandomMaze(int x, int y)
        {
            var maze = new Maze();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var r = rand.Next(1, 4);
                    var cell = new Cell();
                    cell.X = i;
                    cell.Y = j;
                    cell.CellType = r;
                    maze.Height++;
                }
                maze.Width++;
            }
            return maze;
        }
    }

    public class Maze
    {
        public int Height;
        public int Width;
        public List<Cell> Cells = new List<Cell>();
    }

    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int CellType { get; set; }
    }

}


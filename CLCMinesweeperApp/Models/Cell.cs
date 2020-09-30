using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLCMinesweeperApp.Models
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public int Neighbors { get; set; }

        public Cell(int row, int column, bool visited, bool live, int neighbors)
        {
            Row = row;
            Column = column;
            Visited = visited;
            Live = live;
            Neighbors = neighbors;

        }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Visited = false;
            Live = false;
            Neighbors = 0;

        }

    }
}
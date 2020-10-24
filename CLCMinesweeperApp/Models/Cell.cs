using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CLCMinesweeperApp.Models
{
    [DataContract]
    public class Cell
    {
        [DataMember]
        public int Row { get; set; }
        [DataMember]
        public int Column { get; set; }
        [DataMember]
        public bool Visited { get; set; }
        [DataMember]
        public bool Live { get; set; }
        [DataMember]
        public int Neighbors { get; set; }
        [DataMember]
        public bool Flag { get; set; }


        public Cell(int row, int column, bool visited, bool live, int neighbors, bool flag)
        {
            Row = row;
            Column = column;
            Visited = visited;
            Live = live;
            Neighbors = neighbors;
            Flag = flag;


        }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Visited = false;
            Live = false;
            Neighbors = 0;
            Flag = false;


        }

    }
}
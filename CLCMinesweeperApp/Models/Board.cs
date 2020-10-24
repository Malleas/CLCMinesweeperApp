using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CLCMinesweeperApp.Models
{
    [DataContract]
    public class Board
    {
        [DataMember]
        public int Size { get; set; }
        [DataMember]
        public Cell[,] Grid { get; set; }
        [DataMember]
        static public int Difficulty { get; set; }
        [DataMember]
        static public bool GameOver { get; set; }

        public Board(int size, int difficulty)
        {
            Size = size;
            Difficulty = difficulty;

        }

        


    }
}
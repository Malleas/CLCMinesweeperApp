﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLCMinesweeperApp.Models
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }
        static public int Difficulty { get; set; }

        public Board(int size, int difficulty)
        {
            Size = size;
            Difficulty = difficulty;

        }

        


    }
}
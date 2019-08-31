using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.Constants
{
    public static class GameConstant
    {
        public static class Snake
        {
            public static readonly string Symbol = "\u25CF";
            public static readonly int DefaultLength = 6;
            public static readonly int DefaultX = 8;
            public static readonly int DefaultY = 7;
        }

        public static class Food
        {
            public static readonly string AsteriksSymbol = "*";
            public static readonly int AsteriksPoints = 1;
            public static readonly string DollarSymbol = "$";
            public static readonly int DollarPoints = 1;
            public static readonly string HashSymbol = "#";
            public static readonly int HashPoints = 1;
        }

        public static class Board
        {
            public static readonly int DefaultBoardWidth = 120;
            public static readonly int DefaultBoardHeight = 40;
            public static readonly string DefaultBoardSymbol = "\u2588";
        }

        public static class Player
        {
            public static readonly int PlayerScoreOffsetX = 10;
            public static readonly int PlayerScoreOffsetY = 10;
            public static readonly string PlayerScore = "Score: {0}";
        }

        public static class Config
        {
            public static readonly int EndMessageX = 45;
            public static readonly int EndMessageY = 15;
        }
    }
}

using SimpleSnake.Constants;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.Core
{
    public class DrawManager
    {
        private List<Coordinate> snakeBodyElements;

        public DrawManager()
        {
            this.snakeBodyElements = new List<Coordinate>();
        }

        public void Draw(string symbol, IEnumerable<Coordinate> coordinates)
        {
            foreach (var coordinate in coordinates)
            {
                if (symbol == GameConstant.Snake.Symbol)
                {
                    snakeBodyElements.Add(coordinate);
                }

                Console.SetCursorPosition(coordinate.CoordinateX, coordinate.CoordinateY);
                Console.Write(symbol);
            }
        }

        public void UndoDraw()
        {
            Coordinate lastElement = this.snakeBodyElements.First();

            Console.SetCursorPosition(lastElement.CoordinateX, lastElement.CoordinateY);
            Console.Write(" ");
            this.snakeBodyElements.Clear();
        }
    }
}

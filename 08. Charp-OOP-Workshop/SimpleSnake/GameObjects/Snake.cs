using SimpleSnake.Constants;
using SimpleSnake.Enums;
using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private List<Coordinate> snakeBody;

        public Coordinate Head => this.snakeBody.Last();
        public Direction Direction { get; set; }



        public Snake()
        {
            this.snakeBody = new List<Coordinate>();
            this.Direction = Direction.Right;
            this.InitializeBody();
        }

        public IReadOnlyCollection<Coordinate> Body => this.snakeBody.AsReadOnly();

        public void Move()
        {
            Coordinate newHead = this.GetNewHeadCoordinate();

            this.snakeBody.Add(newHead);
            this.snakeBody.RemoveAt(0);
        }

        private Coordinate GetNewHeadCoordinate()
        {
            Coordinate newHeadCoordinate = new Coordinate(this.Head.CoordinateX, this.Head.CoordinateY);

            switch (this.Direction)
            {
                case Direction.Right:
                    newHeadCoordinate.CoordinateX++;
                    break;
                case Direction.Left:
                    newHeadCoordinate.CoordinateX--;
                    break;
                case Direction.Down:
                    newHeadCoordinate.CoordinateY++;
                    break;
                case Direction.Up:
                    newHeadCoordinate.CoordinateY--;
                    break;
            }

            return newHeadCoordinate;
        }

        private void InitializeBody()
        {
            int x = GameConstant.Snake.DefaultX;
            int y = GameConstant.Snake.DefaultY;

            for (int i = 0; i <= GameConstant.Snake.DefaultLength; i++)
            {
                this.snakeBody.Add(new Coordinate(x, y));
                x++;
            }
        }

        public void Eat(Food food)
        {
            for (int i = 0; i < food.Points; i++)
            {
                Coordinate newHeadCoordinate = this.GetNewHeadCoordinate();
                this.snakeBody.Add(newHeadCoordinate);
            }
        }
    }
}

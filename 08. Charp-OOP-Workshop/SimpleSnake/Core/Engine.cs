using SimpleSnake.Constants;
using SimpleSnake.Enums;
using SimpleSnake.Factories;
using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private DrawManager drawmanager;
        private Snake snake;
        private Food food;
        private Coordinate boardCoordinate;
        private int gameScore;

        public Engine(DrawManager drawmanager, Snake snake, Coordinate boardCoordinate)
        {
            this.drawmanager = drawmanager;
            this.snake = snake;
            this.boardCoordinate = boardCoordinate;
            this.InitializeFood();
            this.InitializeBorders();
        }

        public void Run()
        {
            while (true)
            {
                this.PlayerInfo();

                if (Console.KeyAvailable)
                {
                    this.SetCorrectDirection(Console.ReadKey());
                }

                this.drawmanager.Draw(food.Symbol, new List<Coordinate>() { food.Coordinate });

                this.drawmanager.Draw(GameConstant.Snake.Symbol, this.snake.Body);

                this.snake.Move();

                this.drawmanager.UndoDraw();

                if (HasFoodCollision())
                {
                    this.snake.Eat(this.food);
                    this.gameScore += this.food.Points;

                    this.InitializeFood();
                }

                if (HasBorderCoollision())
                {
                    this.AskPlayerForRestart();
                }

                if (this.snake.Direction == Direction.Up || this.snake.Direction == Direction.Down)
                {
                    Thread.Sleep(200);
                }
                else
                {
                    Thread.Sleep(150);
                }
            }
        }

        private void PlayerInfo()
        {
            int x = GameConstant.Board.DefaultBoardWidth + GameConstant.Player.PlayerScoreOffsetX;
            int y = GameConstant.Player.PlayerScoreOffsetY;

            Console.SetCursorPosition(x, y);
            Console.Write(string.Format(GameConstant.Player.PlayerScore, gameScore));

        }

        private void AskPlayerForRestart()
        {
            Console.SetCursorPosition(GameConstant.Config.EndMessageX, GameConstant.Config.EndMessageY);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Would you like to continue? ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Y/N");

            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                Console.Clear();
                System.Environment.Exit(1);
            }
        }

        private bool HasBorderCoollision()
        {
            int snakeHeadCoordinateX = this.snake.Head.CoordinateX;
            int snakeHeadCoordinateY = this.snake.Head.CoordinateY;

            int boardCoordinateX = this.boardCoordinate.CoordinateX;
            int boardCoordinateY = this.boardCoordinate.CoordinateY;

            return snakeHeadCoordinateX == boardCoordinateX - 1
                || snakeHeadCoordinateX == 0
                || snakeHeadCoordinateY == boardCoordinateY
                || snakeHeadCoordinateY == 0;
        }

        private void InitializeFood()
        {
            this.food = FoodFactory.GetRandomFood(this.boardCoordinate.CoordinateX, this.boardCoordinate.CoordinateY);
        }

        private bool HasFoodCollision()
        {
            int snakeHeadCoordinateX = this.snake.Head.CoordinateX;
            int snakeHeadCoordinateY = this.snake.Head.CoordinateY;

            int foodCoordinateX = this.food.Coordinate.CoordinateX;
            int foodCoordinateY = this.food.Coordinate.CoordinateY;

            return (snakeHeadCoordinateX == foodCoordinateX && snakeHeadCoordinateY == foodCoordinateY);
        }

        private void SetCorrectDirection(ConsoleKeyInfo input)
        {
            Direction currentSnakeDirection = this.snake.Direction;

            switch (input.Key)
            {
                case ConsoleKey.DownArrow:
                    if (currentSnakeDirection != Direction.Up)
                    {
                        currentSnakeDirection = Direction.Down;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentSnakeDirection != Direction.Right)
                    {
                        currentSnakeDirection = Direction.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (currentSnakeDirection != Direction.Left)
                    {
                        currentSnakeDirection = Direction.Right;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (currentSnakeDirection != Direction.Down)
                    {
                        currentSnakeDirection = Direction.Up;
                    }
                    break;
            }

            this.snake.Direction = currentSnakeDirection;
        }


        private void InitializeBorders()
        {
            List<Coordinate> allCoordinates = new List<Coordinate>();

            this.IninitalizeHorizontalBorderCoordinates(0, allCoordinates);
            this.IninitalizeHorizontalBorderCoordinates(this.boardCoordinate.CoordinateY, allCoordinates);
            this.IninitalizeVerticalBorderCoordinates(0, allCoordinates);
            this.IninitalizeVerticalBorderCoordinates(1, allCoordinates);

            this.IninitalizeVerticalBorderCoordinates(this.boardCoordinate.CoordinateX, allCoordinates);
            this.IninitalizeVerticalBorderCoordinates(this.boardCoordinate.CoordinateX -1, allCoordinates);

            this.drawmanager.Draw(GameConstant.Board.DefaultBoardSymbol, allCoordinates);
        }

        private void IninitalizeVerticalBorderCoordinates(int coordinateX, List<Coordinate> allCoordinates)
        {
            for (int coordinateY = 0; coordinateY < this.boardCoordinate.CoordinateY; coordinateY++)
            {
                allCoordinates.Add(new Coordinate(coordinateX, coordinateY));
            };
        }

        private void IninitalizeHorizontalBorderCoordinates(int coordinateY, List<Coordinate> allCoordinates)
        {
            for (int coordinateX = 0; coordinateX <= this.boardCoordinate.CoordinateX; coordinateX++)
            {
                allCoordinates.Add(new Coordinate(coordinateX, coordinateY));
            }
        }
    }
}
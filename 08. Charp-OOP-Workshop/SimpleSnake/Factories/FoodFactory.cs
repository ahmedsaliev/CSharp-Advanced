﻿using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SimpleSnake.Factories
{
    public static class FoodFactory
    {
        private static Random random;

        static FoodFactory()
        {
            random = new Random();
        }

        public static Food GetRandomFood(int boardWidht, int boardHeight)
        {
            List<Type> foodType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.BaseType == typeof(Food))
                .ToList();

            Type currentFoodType = foodType[random.Next(0, foodType.Count)];

            int coordinateX = random.Next(1, boardWidht - 1);
            int coordinateY = random.Next(1, boardHeight - 1);

            Coordinate foodCoordinate = new Coordinate(coordinateX, coordinateY);


            return Activator.CreateInstance(currentFoodType, new object[] { foodCoordinate }) as Food;
        }
    }
}

using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class HashFood : Food
    {
        public HashFood(Coordinate coordinate)
            : base(GameConstant.Food.HashSymbol, GameConstant.Food.HashPoints, coordinate)
        {
        }
    }
}
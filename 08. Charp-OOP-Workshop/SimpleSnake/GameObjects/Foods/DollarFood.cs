using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class DoolarFood : Food
    {
        public DoolarFood(Coordinate coordinate)
            : base(GameConstant.Food.DollarSymbol, GameConstant.Food.DollarPoints, coordinate)
        {
        }
    }
}
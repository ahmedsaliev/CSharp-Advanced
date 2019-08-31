using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class AsteriksFood : Food
    {
        public AsteriksFood(Coordinate coordinate)
            : base(GameConstant.Food.AsteriksSymbol, GameConstant.Food.AsteriksPoints, coordinate)
        {
        }
    }
}
namespace SolidRobotto.Game.Orientations
{
    public class North : IOrientation
    {
        public IOrientation GetOrientationByTurningRight()
        {
            return new East();
        }

        public IOrientation GetOrientationByTurningLeft()
        {

            return new West();
        }
    }
}
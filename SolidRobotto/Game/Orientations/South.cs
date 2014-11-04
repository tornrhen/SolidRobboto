namespace SolidRobotto.Game.Orientations
{
    public class South : IOrientation
    {
        public IOrientation GetOrientationByTurningRight()
        {
            return new West();
        }

        public IOrientation GetOrientationByTurningLeft()
        {
            return new East();
        }
    }
}
namespace SolidRobotto.Game.Orientations
{
    public class East : IOrientation
    {
        public IOrientation GetOrientationByTurningRight()
        {
            return new South();
        }

        public IOrientation GetOrientationByTurningLeft()
        {
            return new North();
        }
    }
}
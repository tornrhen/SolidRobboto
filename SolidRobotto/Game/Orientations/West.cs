namespace SolidRobotto.Game.Orientations
{
    public class West : IOrientation
    {
        public IOrientation GetOrientationByTurningRight()
        {
            return new North();
        }

        public IOrientation GetOrientationByTurningLeft()
        {
            return new South();
        }
    }
}
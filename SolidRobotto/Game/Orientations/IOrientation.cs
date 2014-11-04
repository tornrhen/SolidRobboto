namespace SolidRobotto.Game.Orientations
{
    public interface IOrientation
    {
        IOrientation GetOrientationByTurningRight();
        IOrientation GetOrientationByTurningLeft();
    }
}

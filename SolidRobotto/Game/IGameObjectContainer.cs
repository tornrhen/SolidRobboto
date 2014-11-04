namespace SolidRobotto.Game
{
    public interface IGameObjectContainer
    {
        bool GiveContainedObjectToContainer(IGameObjectContainer gameObjectContainer);
        bool ReceiveContainedObject(IGameObject receivedObject);
    }
}
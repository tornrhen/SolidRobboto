using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SolidRobotto.Game
{
    class Panel : IGameObjectContainer
    {
        private IGameObject _containedGameObject;
        public Position Location { get; set; }
        
        public bool GiveContainedObjectToContainer(IGameObjectContainer gameObjectContainer)
        {
            var success = gameObjectContainer.ReceiveContainedObject(_containedGameObject);
            if (success)
                _containedGameObject = null;
            return success;
        }
        
        public bool ReceiveContainedObject(IGameObject receivedObject)
        {
            if(_containedGameObject!=null)
                return false;
            _containedGameObject = receivedObject;
            return true;
        }

    }
}

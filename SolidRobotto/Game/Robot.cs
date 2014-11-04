using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidRobotto.Game.Orientations;

namespace SolidRobotto.Game
{
    public class Robot : IGameObject
    {
        public Robot(IOrientation orientation)
        {
            _orientation = orientation;
        }

        public void RotateRight()
        {
            _orientation = _orientation.GetOrientationByTurningRight();
        }

        public void RotateLeft()
        {
            _orientation = _orientation.GetOrientationByTurningLeft();
        }

        private IOrientation _orientation;
    }
}

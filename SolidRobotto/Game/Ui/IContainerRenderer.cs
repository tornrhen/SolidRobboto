using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolidRobotto.Game.Ui
{
    public interface IContainerRenderer
    {
        void Render(IGameObjectContainer inputGameObject);
    }
}

using System;

namespace SolidRobotto.Game.Ui.Console
{
    class PanelRender : IContainerRenderer
    {
        public void Render(IGameObjectContainer inputGameObject)
        {
            var panelToRender = (Panel) inputGameObject;
        }
    }
}
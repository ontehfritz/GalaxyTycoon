using System;
using Nez;

namespace GalaxyTycoon.Components
{
    public class MouseEntity : Component, IUpdatable
    {
        public void update()
        {
            entity.setPosition(Input.scaledMousePosition);
        }
    }
}

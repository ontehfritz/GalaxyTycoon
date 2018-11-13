using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace GalaxyTycoon.Components
{
    public class MouseEntity : Component, IUpdatable
    {
        private const int _cameraMoveSpeed = 10;
        private int _move; 

        public void update()
        {
            entity.setPosition(Input.scaledMousePosition);

            if(Input.middleMouseButtonDown)
            {
                if(Input.mousePositionDelta.X < 0){
                    _move = _cameraMoveSpeed * -1;
                }

                if (Input.mousePositionDelta.X > 0)
                {
                    _move = _cameraMoveSpeed;
                }
            }
            else if(Input.isKeyDown(Keys.Right)){
                _move = _cameraMoveSpeed * -1; ;
            }
            else if(Input.isKeyDown(Keys.Left)){
                _move = _cameraMoveSpeed;
            }

            entity.scene.camera.position +=
                    new Vector2(_move, 0);
            _move = 0;
        }
    }
}

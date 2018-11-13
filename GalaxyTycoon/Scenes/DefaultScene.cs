using System;
using GalaxyTycoon.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Console;
using Nez.Pipeline;
using Nez.Sprites;

namespace GalaxyTycoon.Scenes
{
    public class DefaultScene : BaseScene
    {

        public DefaultScene()
        {

        }
        public override void initialize()
        {
            base.initialize();
            //setDesignResolution(137 * 9, 89 * 9,
            //                   Scene.SceneResolutionPolicy.ShowAllPixelPerfect);
            //Screen.setSize(137 * 9, 89 * 9);

            var texture = this.content.Load<Texture2D>("Bee");
            var beeEntity = createEntity("bee");
            beeEntity.addComponent(new Sprite(texture));
            beeEntity.position = new Vector2(650, 400);
            var mouseFollowEntity = createEntity("mouse");
            mouseFollowEntity.addComponent(new MouseEntity()); 
        }
    }
}

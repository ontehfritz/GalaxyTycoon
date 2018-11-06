using System;
using GalaxyTycoon.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
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
            setDesignResolution(137 * 9, 89 * 9,
                               Scene.SceneResolutionPolicy.ShowAllPixelPerfect);
            Screen.setSize(137 * 9, 89 * 9);

            var texture = this.content.Load<Texture2D>("Bee");
            var mouseFollowEntity = createEntity("mouse-follow");
            mouseFollowEntity.addComponent(new MouseEntity());
            mouseFollowEntity.addComponent(new CameraBounds(
                new Vector2(16, 16), new Vector2(100, 100)));
            camera.entity.addComponent(new FollowCamera(mouseFollowEntity));
            mouseFollowEntity.addComponent(new Sprite(texture));

        }
    }
}

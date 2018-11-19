using GalaxyTycoon.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.Tiled;

namespace GalaxyTycoon.Scenes
{
    public class DefaultScene : BaseScene
    {

        public DefaultScene() : base()
        {

        }

        public override void initialize()
        {
            base.initialize();
            setDesignResolution(640, 480, Scene.SceneResolutionPolicy.ExactFit);
            Screen.setSize(1920, 1080);

            var tiledMap = content.Load<TiledMap>("Maps/test");
            var tiledEntity = createEntity("tiled-map-entity");
            var tiledMapComponent = tiledEntity.addComponent(new TiledMapComponent(tiledMap));
            tiledEntity.addComponent(new CameraBounds(
                new Vector2(tiledMap.tileWidth, 
                            tiledMap.tileWidth), 
                new Vector2(tiledMap.tileWidth * (tiledMap.width - 1), 
                            tiledMap.tileWidth * (tiledMap.height - 1))));
            //var texture = this.content.Load<Texture2D>("Bee");
            //var beeEntity = createEntity("bee");
            //beeEntity.addComponent(new Sprite(texture));
            //beeEntity.position = new Vector2(650, 400);
            var mouseFollowEntity = createEntity("mouse");
            mouseFollowEntity.addComponent(new MouseEntity());

            var texture = this.content.Load<Texture2D>("sprites/landscraper");
            
            var scraperEntity = createEntity("scraper");
            scraperEntity.addComponent(new Sprite(texture));

            scraperEntity.position = new Vector2(100, 100);



            //camera.entity.addComponent(new FollowCamera(mouseFollowEntity));
        }
    }
}

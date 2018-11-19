using Microsoft.Xna.Framework;
using Nez;
using Nez.UI;

namespace GalaxyTycoon.Scenes
{
    public abstract class BaseScene : Scene
    {
        private UICanvas _canvas;
        private Table _table;
        protected const int ScreenSpaceRenderLayer = 999;
        protected TextButton _scraperButton;

        public BaseScene()
        {
            _canvas = new UICanvas();
            //_canvas.isFullScreen = true;
           
            addRenderer(new ScreenSpaceRenderer(10, ScreenSpaceRenderLayer));
            addRenderer(new RenderLayerExcludeRenderer(0, ScreenSpaceRenderLayer));

            var uiCanvas = createEntity("ui-canvas").addComponent(_canvas);
            _table = new Table();

            _table.setDebug(true);
            _table.setColor(Color.Gray);
            _table.setFillParent(true).top().padTop(425);
            _table.row();

            buildUi();

            uiCanvas.stage.addElement(_table);
            uiCanvas.renderLayer = ScreenSpaceRenderLayer;
        }

        private void buildUi()
        {
            _scraperButton = new TextButton("Scraper",
                                               Skin.createDefaultSkin());
            _table.add(_scraperButton)
                    .setMinHeight(50)
                    .setMinWidth(50)
                    .getElement<TextButton>();

            _table.add(new TextButton("create",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
            _table.add(new TextButton("delete",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
            _table.add(new TextButton("collect",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
            _table.add(new TextButton("click",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
            _table.add(new TextButton("click",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
            _table.add(new TextButton("click",
                                       Skin.createDefaultSkin()))
                                           .setMinHeight(50)
                                           .setMinWidth(50)
                                           .getElement<TextButton>();
        }
    }
}

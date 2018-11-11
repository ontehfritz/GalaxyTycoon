using System;
using System.Collections.Generic;
using GalaxyTycoon.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.UI;

namespace GalaxyTycoon.Scenes
{
    public abstract class BaseScene : Scene
    {
        private UICanvas _canvas;
        private Table _table;
        protected const int ScreenSpaceRenderLayer = 999;

        public BaseScene()
        {
            _canvas = new UICanvas();
            _canvas.isFullScreen = false;
           
            addRenderer(new ScreenSpaceRenderer(100, ScreenSpaceRenderLayer));
            addRenderer(new RenderLayerExcludeRenderer(0, ScreenSpaceRenderLayer));

            var uiCanvas = createEntity("ui-canvas").addComponent(_canvas);
            _table = new Table();
            _table.setSize(5000, 195);
            _table.setDebug(true);
            _table.setColor(Color.Gray);
            _table.setFillParent(true).top().padTop(700);
            _table.row().setPadTop(10);

            for (int i = 0; i < 10; i++)
            {
                var playButton = _table.add(
                    new TextButton("click",
                                   Skin.createDefaultSkin()))
                                       .setMinHeight(50)
                                       .setMinWidth(50)
                                       .getElement<TextButton>();
            }

            uiCanvas.stage.addElement(_table);
            uiCanvas.renderLayer = ScreenSpaceRenderLayer;
        }
    }
}

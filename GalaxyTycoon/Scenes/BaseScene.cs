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
        private Dictionary<string, ImageButton> _buttons;
        protected const int ScreenSpaceRenderLayer = 999;


        public BaseScene()
        {
            _canvas = new UICanvas();
            _canvas.isFullScreen = true;
           
            addRenderer(new ScreenSpaceRenderer(100, ScreenSpaceRenderLayer));
            addRenderer(new RenderLayerExcludeRenderer(0, ScreenSpaceRenderLayer));

            var uiCanvas = createEntity("ui-canvas").addComponent(_canvas);
            _table = new Table();
            _table.setWidth(1280);
            _table.setDebug(true);
            _table.setColor(Color.Gray);
            _table.setFillParent(true).top().padTop(700);
            _table.row().setPadTop(10);

            buildUi();

            uiCanvas.stage.addElement(_table);
            uiCanvas.renderLayer = ScreenSpaceRenderLayer;
        }

        private void buildUi()
        {
            _table.add(new TextButton("clear",
                                       Skin.createDefaultSkin()))
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

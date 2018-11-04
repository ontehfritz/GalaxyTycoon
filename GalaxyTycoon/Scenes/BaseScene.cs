using System;
using System.Collections.Generic;
using GalaxyTycoon.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.UI;

namespace GalaxyTycoon.Scenes
{
    public abstract class BaseScene : Scene, IFinalRenderDelegate
    {
        public const int SCREEN_SPACE_RENDER_LAYER = 999;
        public UICanvas canvas;

        private Table _table;
        private List<Button> _sceneButtons = new List<Button>();
        private ScreenSpaceRenderer _screenSpaceRenderer;

        public BaseScene()
        {
            // setup one renderer in screen space for the UI and then (optionally) another renderer to render everything else

            addRenderer(new ScreenSpaceRenderer(100, SCREEN_SPACE_RENDER_LAYER));
            addRenderer(new RenderLayerExcludeRenderer(0, SCREEN_SPACE_RENDER_LAYER));

            // create our canvas and put it on the screen space render layer
            canvas = createEntity("ui").addComponent(new UICanvas());
            canvas.isFullScreen = true;
            canvas.renderLayer = SCREEN_SPACE_RENDER_LAYER;
        }

        public Scene scene { get; set; }
        public void handleFinalRender(Color letterboxColor, 
                                      RenderTarget2D source, 
                                      Rectangle finalRenderDestinationRect, 
                                      SamplerState samplerState)
        {
            Core.graphicsDevice.SetRenderTarget(null);
            Core.graphicsDevice.Clear(letterboxColor);
            Graphics.instance.batcher.begin(BlendState.Opaque, samplerState, DepthStencilState.None, RasterizerState.CullNone, null);
            Graphics.instance.batcher.draw(source, finalRenderDestinationRect, Color.White);
            Graphics.instance.batcher.end();

           // _screenSpaceRenderer.render(scene);
        }

        public void onAddedToScene(){ }

        public void onSceneBackBufferSizeChanged(int newWidth, int newHeight)
        {
           // _screenSpaceRenderer.onSceneBackBufferSizeChanged(newWidth, newHeight);
        }
    }
}

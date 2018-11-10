﻿using GalaxyTycoon.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace GalaxyTycoon.Desktop
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Main : Nez.Core
    {
        public Main() : base(width: 1280, height: 768, isFullScreen: false, 
                              enableEntitySystems: false)
        { }


        protected override void Initialize()
        {

            base.Initialize();
            Window.AllowUserResizing = true;

           
            
            //var myScene = Scene.createWithDefaultRenderer(Color.BurlyWood);
            var myScene = new DefaultScene
            {
                clearColor = Color.BurlyWood
            };

            // set the scene so Nez can take over
            scene = myScene;
        }
    }
}

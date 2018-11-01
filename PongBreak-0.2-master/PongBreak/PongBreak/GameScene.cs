using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework.Graphics;
//game scene is where the game scene is set up using CCScene. 
namespace PongBreak
{
    public class GameScene : CCScene
    {

        public GameScene(CCWindow window) : base(window)
        {
            // sets up backgroundLayer as a new CCLayer
            var backgroundLayer = new CCLayer();
           
        }
        /*CreateBackGround is no longer used here as the backgrounds are 
         * defined in each level's code
         * this method was used when developing the prototype level
         */
      //  private void CreateBackground(CCWindow window, CCLayer backgroundLayer)
      //  {
       //     var texture = new CCTexture2D("redSoilTile.png");
       //     texture.SamplerState = SamplerState.LinearWrap;
       //     var background = new CCSprite(texture);
        //    background.ContentSize = new CCSize(window.WindowSizeInPixels.Width, window.WindowSizeInPixels.Height);
        //    background.TextureRectInPixels = new CCRect(0, 0, window.WindowSizeInPixels.Width, window.WindowSizeInPixels.Height);
        //    background.PositionX = window.WindowSizeInPixels.Width / 2;
         //   background.PositionY = window.WindowSizeInPixels.Height / 2;
         //   backgroundLayer.AddChild(background);
       // }
    }
}


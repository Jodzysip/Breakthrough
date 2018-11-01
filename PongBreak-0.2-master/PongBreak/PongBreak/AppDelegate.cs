using System.Reflection;
using Microsoft.Xna.Framework;
using CocosSharp;
using CocosDenshion;

namespace PongBreak
{
    public class AppDelegate : CCApplicationDelegate
    {

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.PreferMultiSampling = false;
            application.ContentRootDirectory = "Content";
           
            var windowSize = mainWindow.WindowSizeInPixels;
            //desired width and height changed from the original to suit modern resolution Android phones
            var desiredWidth = 1440.0f; 
            var desiredHeight = 2560.0f;

            // This will set the world bounds to be (0,0, w, h)
            // CCSceneResolutionPolicy.ShowAll will ensure that the aspect ratio is preserved
            CCScene.SetDefaultDesignResolution(desiredWidth, desiredHeight, CCSceneResolutionPolicy.ShowAll);

            // Determine whether to use the high or low def versions of our images
            // Make sure the default texel to content size ratio is set correctly
            // Of course you're free to have a finer set of image resolutions e.g (ld, hd, super-hd)
            if (desiredWidth < windowSize.Width)
            {
                application.ContentSearchPaths.Add("hd");
                CCSprite.DefaultTexelToContentSizeRatio = 2.0f;
            }
            else
            {
                application.ContentSearchPaths.Add("ld");
                CCSprite.DefaultTexelToContentSizeRatio = 1.0f;
            }
           
            //sets up the gameScene in the main window
            var scene = new GameScene(mainWindow);
           //adds the titleLayer to the gameScene, meaning the title layer is the first screen the player sees
            var title = new TitleLayer();
            scene.AddChild(title);

            mainWindow.RunWithScene(scene);
        }

        public override void ApplicationDidEnterBackground(CCApplication application)
        {
            application.Paused = true;
            //since there is no audio, no audio pausing
        }

        public override void ApplicationWillEnterForeground(CCApplication application)
        {
            application.Paused = false;
            //since there is no audio, no audio resuming
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPG.Scenes;

namespace TRPG
{
    public static class Game
    {
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];
        }

        public static void End()
        {

        }

        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.SelectChoice();
                curScene.Input();
                curScene.Result();
                curScene.Wait();
                curScene.Next();
            }
        }
    }
}

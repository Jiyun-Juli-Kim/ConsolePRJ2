using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRPG.Players;
using TestRPG.Scenes;

namespace 콘솔프로젝트2
{
    public class Game
    {
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;
        public Scene CurScene { get { return curScene; } }

        private Player player;
        public Player Player { get { return player; } set { player = value; } }

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

        private void Start()
        {
            isRunning = true;

            //    public enum SceneType { Title, Map, Enter, Market, TradingPost, Port, MyRoom, RoomDeco, GameOver}
            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Map] = new VoyageScene(this);
            scenes[(int)SceneType.Enter] = new EnterScene(this);
            scenes[(int)SceneType.Market] = new MarketScene(this);
            scenes[(int)SceneType.TradingPost] = new TPScene(this);
            scenes[(int)SceneType.Port] = new PortScene(this);
            scenes[(int)SceneType.MyRoom] = new MyRoomScene(this);
            scenes[(int)SceneType.RoomDeco] = new RoomDecoScene(this);
            scenes[(int)SceneType.GameOver] = new GameOverScene(this);


            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
        }

        private void End()
        {
            curScene.Exit();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }
    }
}
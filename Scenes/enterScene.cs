using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔프로젝트2.Scenes
{
    public class EnterScene : Scene
    {
        private string input;

        public EnterScene(Game game) : base(game)
        {
        }
   
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine($"{islandName}에 입항합니다...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine($"{islandName}이다.");
            Console.WriteLine("어디로 이동하겠습니까?");
            Console.WriteLine("1. 선착장");
            Console.WriteLine("2. 교역장");
            Console.WriteLine("3. 시장");
            Console.WriteLine("4. 마이룸");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Port);
                    break;
                case "2":
                    game.ChangeScene(SceneType.TradingPost);
                    break;
                case "3":
                    game.ChangeScene(SceneType.Market);
                case "4":
                    game.ChangeScene(SceneType.MyRoom);
                    break;
            }
        }
    }
}

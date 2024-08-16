using System;

namespace 콘솔프로젝트2.Scenes
{
    public class MyRoomScene : Scene
    {
        private string input;

        public MyRoomScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine($"마이룸에 들어왔습니다...");
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
            Console.WriteLine("무엇을 할까요?");
            Console.WriteLine("1. 마이룸 꾸미기");
            Console.WriteLine("2. 돌아가기");
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

/*

 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                                |
|    |________                        |
|    |________|                       |
|   /        /|_______________________|
|  /________//                        |
| |________|/                         |
| /                                   |
|/____________________________________|

 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                [][][][]    __  |
|    |________      ___________  <  > |
|    |________|    |___________|  ||  |
|   /        /|___/___________/|__||__|
|  /________//   |___________|/   ||  |
| |________|/  (              )       |
| /           (______________)        |
|/____________________________________|









 */
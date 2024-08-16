using System;

namespace 콘솔프로젝트2.Scenes
{
    public class EnterScene : Scene
    {
        private string input;

        public roomDecoScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            Console.WriteLine("이제 무엇을 할까. . .")
            Console.WriteLine("1. 더 업그레이드 하기")
            Console.WriteLine("2. 돌아가기")

            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
           public void Upgrade()

        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.RoomDeco);
                    break;
                case "2":
                    game.ChangeScene(SceneType.myRoom);
                    break;
            }
        }
    }
}


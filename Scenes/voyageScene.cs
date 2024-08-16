using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using 콘솔프로젝트2.Scenes;

namespace 콘솔프로젝트2
{
    public class voyageScene
    {
        public class voyageScene : Scene
        {
            private Boat boat;

            public voyageScene(Game game) : base(game)
            {
            }

            public override void Enter()
            {
                boat = new Boat();
                boat.boatId = 


                Console.Clear();
                Console.WriteLine($"{boat.name}이/가 항해를 시작합니다.");
                Thread.Sleep(2000);
            }

            public override void Exit()
            {

            }

            public override void Input()
            {

            }

            public override void Render()
            {
                Console.Clear();
                game.Player.ShowInfo();
                Console.WriteLine("어느 섬으로 이동하겠습니까?");
                Console.WriteLine("1. 온대섬");
                Console.WriteLine("2. 열대섬");
                Console.WriteLine("3. 얼음섬");
                Console.Write("선택 : ");
            }

            public override void Update()
            {
                switch
            }
        }



    }
}

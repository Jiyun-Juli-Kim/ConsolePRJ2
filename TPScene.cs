using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔프로젝트2.Scene
{
    public class TpScene : Scene
    {
        private Island CurIsland
        private Random random;
        /*private string goods;
        private string otherGoods;
        private double goodsPrice;
        private double otherGoodsPrice; 

        public TpScene(Game game, string goods, string otherGoods) : base(game)
        {
            this.goods = goods;
            this.otherGoods = otherGoods;
            random = new Random();
            UpdatePrice();
        }
        */

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("교역장에 들어갑니다...");
            Thread.Sleep(2000);
            Console.WriteLine($"{curIsland.Goods.Name}을 수입하거나 {otherGoods}을 수출할 수 있습니다.");
            Console.WriteLine($"{curIsland.Goods}의 가격은{curIsland.goodsPrice}입니다.");
            Console.WriteLine($"{otherGoods}의 현재 수출 가격은 {otherGoodsPrice}:F2}입니다.");
            Console.WriteLine($"{otherGoods}의 현재 수출 가격은 {otherGoodsPrice}:F2}입니다.");
            // 나머지 2개 섬의 물품 가격 어떻게 표현할건지?


        }

        public override void Render()
        {
            Console.WriteLine("1. 물품 수입");
            Console.WriteLine("2. 물품 수출");
            Console.WriteLine("3. 나가기");
        }

        public override void Input()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ImportItem();
                    break;
                case "2":
                    ExportItem();
                    break;
                case "3":
                    Exit();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        public override void Update()
        {
            UpdatePrice();
        }

        public override void Exit()
        {
            Console.WriteLine("교역장에서 나갑니다...");
            Thread.Sleep(1000);
        }

        private void ImportItem()
        {
            Console.WriteLine($"{curIsland.Goods}을 수입합니다..."); 
        }

        private void ExportItem()
        {
            Console.WriteLine($"{otherGoods}을 수출합니다. 판매 가격은 {OtherGoodsPrice}:F2}입니다.");
        }

        private void UpdatePrice()
        {
            double randomPrice = random.NextDouble() * (2.0 - 1.5) + 1.5;  // 1.5~2 or 1.3~1.7
            if (random.Next(0, 10) < 2)
            {
                randomPrice = random.NextDouble() * (5.0 - 2.0) + 2.0;
            }
            goodsPrice = randomPrice * basePrice;
        }
    }
}

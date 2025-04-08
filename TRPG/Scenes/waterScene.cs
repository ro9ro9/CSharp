using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Scenes
{
    class waterScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("구덩이를 팝니다.");
            Console.WriteLine("바다로 갑니다.");
            Console.WriteLine("귀환합니다.");
            Console.WriteLine();
        }

        public override void Next()
        {
            Console.WriteLine("물을 얻었습니다.");
            Console.WriteLine("Enter키를 눌러 거점으로 돌아갑니다.");
            switch (input)
            {
                case ConsoleKey.Enter:
                    Game.LoadScene("town");
                    break;
            }
            
        }

        public override void Render()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine();
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("구덩이를 팝니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("바다로 갑니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("귀환합니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요.");
            Console.ReadKey();
        }
    }
}

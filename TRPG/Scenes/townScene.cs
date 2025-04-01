namespace TRPG.Scenes
{
    public class townScene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("폭풍에 휩쓸려 조난당했다.");
            Console.WriteLine("이곳은 무인도다.");
            Console.WriteLine("구조가 올 때까지 살아 남아야 한다.");
            Console.WriteLine("무엇을 해야할까?");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 식수를 구한다.");
            Console.WriteLine("2. 식량을 구한다.");
            Console.WriteLine("3. 땔감을 구한다.");
            Console.WriteLine("4. 운에 맡긴다.");
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요.");
            Console.ReadKey();
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("식수를 구하러 갑니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("식량을 구하러 갑니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("땔감을 구하러 갑니다.");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("어슬렁거립니다.");
                    break;
                default:
                    Console.WriteLine("아무것도 하지 않았습니다");
                    break;
            }
        }
        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}

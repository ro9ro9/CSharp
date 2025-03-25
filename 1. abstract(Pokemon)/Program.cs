namespace _1.Pokemon
{
    internal class Program
    {
        class trainer
        {

        }
        public abstract class pokemon
        {
            public string name;
            public string skillname;

            public abstract void Attack();
        }

        public class Pikachu : pokemon
        {
            public Pikachu()
            {
                name = "피카츄";
                skillname = "백만볼트";
            }
            public override void Attack()
            {
                Console.WriteLine("{0}!, {1}!!", name, skillname);
            }
        }
        public class Charmander : pokemon
        {
            public Charmander()
            {
                name = "파이리";
                skillname = "불꽃세례";
            }
            public override void Attack()
            {
                Console.WriteLine("{0}!, {1}!!", name, skillname);
            }
        }
        public class Squirtle : pokemon
        {
            public Squirtle()
            {
                name = "꼬부기";
                skillname = "거품";
            }
            public override void Attack()
            {
                Console.WriteLine("{0}!, {1}!!", name, skillname);
            }
        }

        public class Piplup : pokemon
        {
            public Piplup()
            {
                name = "펭도리";
                skillname = "막치기";
            }
            public override void Attack()
            {
                Console.WriteLine("{0}!, {1}!!", name, skillname);
            }
        }
        public class Chimchar : pokemon
        {
            public Chimchar()
            {
                name = "불꽃숭이";
                skillname = "할퀴기";
            }
            public override void Attack()
            {
                Console.WriteLine("{0}!, {1}!!", name, skillname);
            }
        }
        static void Main(string[] args)
        {
            string[] MonsterBall = new string[5];

            MonsterBall[0] = "Pikachu";
            MonsterBall[1] = "Charmander";
            MonsterBall[2] = "Squirtle";
            MonsterBall[3] = "Piplup";
            MonsterBall[4] = "Chimchar";

            foreach (string monster in MonsterBall)
            {
                Console.WriteLine(monster);

            }
            Pikachu pikachu = new Pikachu();
            pikachu.Attack();
            Charmander charmander = new Charmander();
            charmander.Attack();
            Squirtle squirtle = new Squirtle();
            squirtle.Attack();
            Piplup piplup = new Piplup();
            piplup.Attack();
            Chimchar chimchar = new Chimchar();
            chimchar.Attack();
        }
    }
}

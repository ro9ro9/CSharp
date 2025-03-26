namespace _2.inter;

internal class Program
{
    public interface IInteraction
    {
        public void Interac();
    }
    public interface Ishop
    {
        public void Shop();
    }
    public interface IOpenable
    {
        public void Open();
    }
    public class NPC : IInteraction, Ishop
    {
        public void Interac()
        {
            Console.WriteLine("대화를 진행합니다.");
        }
        public void Shop()
        {
            Console.WriteLine("아이템을 거래합니다.");
        }
    }

    public class Chest : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("상자를 엽니다.");
        }
    }
    public class Door : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("문을 엽니다.");
        }
    }
    public class Player
    {
        public void Interac(IInteraction interaction)
        {
            interaction.Interac();
        }
        public void Shop(Ishop ishop)
        {
            ishop.Shop();
        }
        public void Open(IOpenable openable)
        {
            openable.Open();
        }
    }
    static void Main(string[] args)
    {
        NPC npc = new NPC();
        Player player = new Player();
        Door door = new Door();
        Chest chest = new Chest();

        player.Interac(npc);
        Console.WriteLine();
        player.Shop(npc);
        Console.WriteLine();
        player.Open(door);
        Console.WriteLine();
        player.Open(chest);
    }
}
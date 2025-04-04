namespace _3.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalBuilder cowBuilder = new AnimalBuilder();
            cowBuilder.SetName("소")
                .SetProducts("소고기")
                .SetAnimalSound("음머")
                .SetAnimalFood("곡식");

            AnimalBuilder sheepBuilder = new AnimalBuilder();
            sheepBuilder.SetName("양")
                .SetProducts("양고기")
                .SetAnimalSound("메에")
                .SetAnimalFood("잡초");

            AnimalBuilder chickenBuilder = new AnimalBuilder();
            chickenBuilder.SetName("닭")
                .SetProducts("닭고기")
                .SetAnimalSound("꼬끼오")
                .SetAnimalFood("사료");

            Animal cow = cowBuilder.Build();
            Console.WriteLine("이름 : {0}, 생산품 : {1}, 울음소리 : {2}, 먹이 : {3}", cow.name, cow.products, cow.animalSounds, cow.animalFood);

            Animal sheep = sheepBuilder.Build();
            Console.WriteLine("이름 : {0}, 생산품 : {1}, 울음소리 : {2}, 먹이 : {3}", sheep.name, sheep.products, sheep.animalSounds, sheep.animalFood);

            Animal chicken = chickenBuilder.Build();
            Console.WriteLine("이름 : {0}, 생산품 : {1}, 울음소리 : {2}, 먹이 : {3}", chicken.name, chicken.products, chicken.animalSounds, chicken.animalFood);
        }
    }

    public class AnimalBuilder
    {
        public string name;
        public string products;
        public string animalSound;
        public string animalFood;

        public AnimalBuilder()
        {
            name = "이름"; 
            products = "생산품"; 
            animalSound = "울음소리"; 
            animalFood = "먹이";
        }

        public Animal Build()
        {
            Animal animal = new Animal();
            animal.name = name;
            animal.products = products;
            animal.animalSounds = animalSound;
            animal.animalFood = animalFood;

            return animal;

        }

        public AnimalBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public AnimalBuilder SetProducts(string products)
        {
            this.products = products;
            return this;
        }

        public AnimalBuilder SetAnimalSound(string animalSound)
        {
            this.animalSound = animalSound;
            return this;
        }

        public AnimalBuilder SetAnimalFood(string animalFood)
        {
            this.animalFood = animalFood;
            return this;
        }

    }
    public class Animal
    {
        public string name;
        public string products;
        public string animalSounds;
        public string animalFood;
    }
}

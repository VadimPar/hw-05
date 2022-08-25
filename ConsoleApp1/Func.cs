using ConsoleApp1;
namespace func
{
    class check
    {
        public static int checkInput(string a)
        {
            if (int.TryParse(a, out int result)) { return result; }
            else { return 100; };
        }
    }

    class Menu
    {
        public static string name = new string("Введите название: ");
        public static string age = new string("Введите возраст: ");
        public static string size = new string("Введите размер: ");
    }

    class Array
    {
        public static void InsertInArrFish(ref Fish[] arr, Fish a)
        {
            Fish[] newArr = new Fish[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = a;

            arr = newArr;
        }

        public static void InsertInArrInsect(ref Insects[] arr, Insects a)
        {
            Insects[] newArr = new Insects[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = a;

            arr = newArr;
        }

        public static void InsertInArrAnimal(ref Animal[] arr, Animal a)
        {
            Animal[] newArr = new Animal[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = a;

            arr = newArr;
        }

        public static void showAll(ref Fish[] arrfish, ref Insects[] arrInsects, ref Animal[] arrAnimal)
        {
            Console.WriteLine("1.Рыбы: ");
            for (int i = 0; i < arrfish.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Fish.Show(arrfish[i].name, arrfish[i].age, arrfish[i].size);
            }
            Console.WriteLine("2.Насекомые: ");
            for (int i = 0; i < arrInsects.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Insects.Show(arrInsects[i].name, arrInsects[i].age, arrInsects[i].size);
            }
            Console.WriteLine("3.Прочие: ");
            for (int i = 0; i < arrAnimal.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Animal.Show(arrAnimal[i].name, arrAnimal[i].age, arrAnimal[i].size);
            }
        }
    }
}
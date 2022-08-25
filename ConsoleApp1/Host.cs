using ConsoleApp1;
using func;
using System.Xml.Serialization;

Animal[] arrAnimal = new Animal[0]; 

Fish []arrfish = new Fish[0];

Insects[] arrInsects = new Insects[0];

Dried[] driedsPlants = new Dried[4];
driedsPlants[0] = new Dried("Сено", 2);
driedsPlants[1] = new Dried("Солома", 3);
driedsPlants[2] = new Dried("Сухой корм для животных", 5);
driedsPlants[3] = new Dried("Сухой корм для рыб", 1);


string[] freshPlant = new string[] { "Трава", "Мяско", "Овощи", "Насекомые" };
int[] freshPlantSize = new int[] { 2, 5, 3, 1 };
Fresh[] freshPlants = new Fresh[freshPlant.Length];
for (int i = 0; i < freshPlants.Length; i++)
{
    freshPlants[i] = new Fresh(freshPlant[i], freshPlantSize[i]);
}

int menuChoice;
string name;
int age;
float size;

do
{
    Console.WriteLine("Выберите действие: ?\n 1. Добавить животное. 2. Посмотреть всех. 3.Покормить животное. 4.Выход.");
    string selectMenu = Console.ReadLine();
    menuChoice = check.checkInput(selectMenu);
    if (menuChoice == 1)
    {
        do
        {
            Console.WriteLine("Какое животное вы хотите добавить?\n 1. Рыбу. 2. Насекомое. 3. Не знаю к чему отнести/нет в списке. 4. Выход в предыдущее меню.");
            selectMenu = Console.ReadLine();
            int menuChoiceAdd = check.checkInput(selectMenu);

            if (menuChoiceAdd == 4) break;
            else if (menuChoiceAdd == 1)
            {
                Console.WriteLine(Menu.name);
                name = Console.ReadLine();
                Console.WriteLine(Menu.age);
                int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine(Menu.size);
                float.TryParse(Console.ReadLine(), out size);
                func.Array.InsertInArrFish(ref arrfish, new Fish(name, age, size));
            }
            else if (menuChoiceAdd == 2)
            {
                Console.WriteLine(Menu.name);
                name = Console.ReadLine();
                Console.WriteLine(Menu.age);
                int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine(Menu.size);
                float.TryParse(Console.ReadLine(), out size);
                func.Array.InsertInArrInsect(ref arrInsects, new Insects(name, age, size));
            }
            else if (menuChoiceAdd == 3)
            {
                Console.WriteLine(Menu.name);
                name = Console.ReadLine();
                Console.WriteLine(Menu.age);
                int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine(Menu.size);
                float.TryParse(Console.ReadLine(), out size);
                func.Array.InsertInArrAnimal(ref arrAnimal, new Animal(name, age, size));
            };
        }
        while (menuChoice != 4);
    }

    if(menuChoice == 2)
    {
        func.Array.showAll(ref arrfish, ref arrInsects, ref arrAnimal);
    }

    if (menuChoice == 3)
    {
        do
        {
            func.Array.showAll(ref arrfish, ref arrInsects, ref arrAnimal);
            Console.WriteLine("Кого вы хотите покормить? 1. Рыбы. 2. Насекомые. 3. Прочие. 4. Выход в предыдущее меню.");
            selectMenu = Console.ReadLine();
            int menuChoicEat = check.checkInput(selectMenu);
            if (menuChoicEat == 4) break;

            if (menuChoicEat == 1)
            {
                Console.WriteLine("1.Рыбы: ");
                for (int i = 0; i < arrfish.Length; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Fish.Show(arrfish[i].name, arrfish[i].age, arrfish[i].size);
                }
                Console.WriteLine("Какую рыбу вы хотите покормить?");
                selectMenu = Console.ReadLine();
                int menuChoiceFish = check.checkInput(selectMenu);
                if (menuChoiceFish <= arrfish.Length)
                {
                    Console.WriteLine("Чем вы хотите покормить? 1. Сухим кормом. 2. Свежим кормом.");
                    selectMenu = Console.ReadLine();
                    int menuChoiceFishFood = check.checkInput(selectMenu);
                    if (menuChoiceFishFood == 1)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < driedsPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {driedsPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceFoodFood2 = check.checkInput(selectMenu);
                        Animal.GetEat(arrfish[menuChoiceFish - 1].name, driedsPlants[menuChoiceFoodFood2 - 1].name);
                        Animal.GetGrow(ref arrfish[menuChoiceFish - 1].size, driedsPlants[menuChoiceFoodFood2 - 1].size);
                    }
                    if (menuChoiceFishFood == 2)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < freshPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {freshPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceFoodFood2 = check.checkInput(selectMenu);
                        Animal.GetEat(arrfish[menuChoiceFish - 1].name, freshPlants[menuChoiceFoodFood2 - 1].name);
                        Animal.GetGrow(ref arrfish[menuChoiceFish - 1].size, freshPlants[menuChoiceFoodFood2 - 1].size);
                    }
                }
            }

            if (menuChoicEat == 2)
            {
                Console.WriteLine("1.Насекомые: ");
                for (int i = 0; i < arrInsects.Length; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Insects.Show(arrInsects[i].name, arrInsects[i].age, arrInsects[i].size);
                }
                Console.WriteLine("Какое насекомое вы хотите покормить?");
                selectMenu = Console.ReadLine();
                int menuChoiceInsect = check.checkInput(selectMenu);
                if (menuChoiceInsect <= arrInsects.Length)
                {
                    Console.WriteLine("Чем вы хотите покормить? 1. Сухим кормом. 2. Свежим кормом.");
                    selectMenu = Console.ReadLine();
                    int menuChoiceInsectFood = check.checkInput(selectMenu);
                    if (menuChoiceInsectFood == 1)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < driedsPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {driedsPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceInsectFood2 = check.checkInput(selectMenu);
                        Animal.GetEat(arrfish[menuChoiceInsect - 1].name, driedsPlants[menuChoiceInsectFood2 - 1].name);
                        Animal.GetGrow(ref arrfish[menuChoiceInsect - 1].size, driedsPlants[menuChoiceInsectFood2 - 1].size);
                    }
                    if (menuChoiceInsectFood == 2)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < freshPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {freshPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceFoodFood2 = check.checkInput(selectMenu);
                        Animal.GetEat(arrInsects[menuChoiceInsect - 1].name, freshPlants[menuChoiceFoodFood2 - 1].name);
                        Animal.GetGrow(ref arrInsects[menuChoiceInsect - 1].size, freshPlants[menuChoiceFoodFood2 - 1].size);
                    }
                }
            }

            if (menuChoicEat == 3)
            {
                Console.WriteLine("1.Прочие: ");
                for (int i = 0; i < arrAnimal.Length; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Insects.Show(arrAnimal[i].name, arrAnimal[i].age, arrAnimal[i].size);
                }
                Console.WriteLine("Какое животное вы хотите покормить?");
                selectMenu = Console.ReadLine();
                int menuChoiceAnimal = check.checkInput(selectMenu);
                if (menuChoiceAnimal <= arrAnimal.Length)
                {
                    Console.WriteLine("Чем вы хотите покормить? 1. Сухим кормом. 2. Свежим кормом.");
                    selectMenu = Console.ReadLine();
                    int menuChoiceAnimalFood = check.checkInput(selectMenu);
                    if (menuChoiceAnimalFood == 1)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < driedsPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {driedsPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceAnimalFood2 = check.checkInput(selectMenu);
                        Animal.GetEat(arrAnimal[menuChoiceAnimalFood - 1].name, driedsPlants[menuChoiceAnimalFood2 - 1].name);
                        Animal.GetGrow(ref arrAnimal[menuChoiceAnimalFood - 1].size, driedsPlants[menuChoiceAnimalFood2 - 1].size);
                    }
                    if (menuChoiceAnimalFood == 2)
                    {
                        Console.WriteLine("Выберите корм: ");
                        for (int i = 0; i < freshPlants.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {freshPlants[i].name}.");
                        }
                        selectMenu = Console.ReadLine();
                        int menuChoiceAnimalFood3 = check.checkInput(selectMenu);
                        Animal.GetEat(arrAnimal[menuChoiceAnimalFood - 1].name, freshPlants[menuChoiceAnimalFood3 - 1].name);
                        Animal.GetGrow(ref arrAnimal[menuChoiceAnimalFood - 1].size, freshPlants[menuChoiceAnimalFood3 - 1].size);
                    }
                }
            }

            else
            {
                Console.WriteLine("Невырный выбор!");
            }
        }
        while(menuChoice != 4);
    }
}
while(menuChoice != 4);


List<Fish> listFish = arrfish.ToList();
string pathToXmlFish = @"D:\baseFish.xml";
XmlSerializer serializerFish=new XmlSerializer(typeof(List<Fish>));
using (StreamWriter sw = new StreamWriter(pathToXmlFish))
    serializerFish.Serialize(sw, listFish);

List<Insects> listInsects = arrInsects.ToList();
string pathToXmlInsects = @"D:\baseInsects.xml";
XmlSerializer serializerInsects = new XmlSerializer(typeof(List<Insects>));
using (StreamWriter sw = new StreamWriter(pathToXmlInsects))
    serializerInsects.Serialize(sw, listInsects);

List<Animal> listAnimals = arrAnimal.ToList();
string pathToXmlAnimals = @"D:\baseAnimals.xml";
XmlSerializer serializerAnimals = new XmlSerializer(typeof(List<Animal>));
using (StreamWriter sw = new StreamWriter(pathToXmlAnimals))
    serializerAnimals.Serialize(sw, listAnimals);
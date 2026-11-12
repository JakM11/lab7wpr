
bool succesfullyParsed = false;
int task = 0;
do
{
    Console.Write("Wybierz zadanie: ");
    succesfullyParsed = int.TryParse(Console.ReadLine()!, out task);
    if(succesfullyParsed == false)
    {
        Console.WriteLine("Musi być liczba");
    }
}
while(succesfullyParsed == false || task < 1 || task > 9);

switch(task)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    case 3:
        Task3();
        break;
    case 4:
        Task4();
        break;
    case 5:
        Task6();
        break;
    case 6:
        Task7();
        break;
    // case 8:
    //     Task8();
    //     break;
    // case 9:
    //     Task9();
    //     break;
}

static void Task1()
{
    Player player = new Player("Jan", 100, 20, 1, 0);

    player.GetExperience(50);

    Console.WriteLine($"Poziom: {player.Level}, Exp: {player.Experience}");

    player.GetExperience(30);

    Console.WriteLine($"Poziom: {player.Level}, Exp: {player.Experience}");

    player.GetExperience(80);

    Console.WriteLine($"Poziom: {player.Level}, Exp: {player.Experience}");
}

static void Task2()
{
    Player player = new Player("Jan", 100, 20, 1, 0);

    player.TakeDamage(50);
    Console.WriteLine($"Hp: {player.Health}");

    player.Heal(40);
    Console.WriteLine($"Hp: {player.Health}");

    player.Heal(200);
    Console.WriteLine($"Hp: {player.Health}");
}


static void Task3()
{
    Player player1 = new Player("Maciuś", 100, 25, 1, 0);
    Player player2 = new Player("Jan", 100, 25, 1, 0);
    Enemy goblin = new Enemy("Goblin", 30, 8, 0, 0, 0);
    Enemy ork = new Enemy("Ork", 60, 20, 0, 0, 0);

    Console.WriteLine($"{player1.Name} spotyka {goblin.Name}.");

    goblin.TakeDamage(12);
    Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

    if (goblin.IsAlive())
    {
        player1.TakeDamage(goblin.Damage);
        Console.WriteLine($"{player1.Name} ma {player1.Health} HP.");
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
    }

    Console.WriteLine($"{player2.Name} spotyka {ork.Name}.");

    goblin.TakeDamage(12);
    Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

    if (goblin.IsAlive())
    {
        player1.TakeDamage(goblin.Damage);
        Console.WriteLine($"{player1.Name} ma {player1.Health} HP.");
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
    }
}

static void Task4()
{
    List<Enemy> enemies = new List<Enemy>
    {
        new Enemy("Goblin", 30, 8, 0, 0, 0),
        new Enemy("Nietoperz", 20, 5, 0, 0, 0),
        new Enemy("Ork", 70, 15, 0, 0, 0),
        new Enemy("Troll", 90, 25, 0, 0, 0),
        new Enemy("Smok", 100, 40, 0, 0, 0),
    };

    foreach (Enemy enemy in enemies)
    {
        Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
    }

    int suma = 0;
    foreach (Enemy enemy in enemies)
    {
        suma = suma + enemy.Health;
    }
    Console.WriteLine($"Suma hp: {suma}");

    string najwiecejHp = enemies[0].Name;
    int najwiecejHpInt = 0;
    foreach (Enemy enemy in enemies)
    {
        if(najwiecejHpInt < enemy.Health)
        {
            najwiecejHp = enemy.Name;
            najwiecejHpInt = enemy.Health;
        }
    }
    Console.WriteLine($"Najwiecej hp ma: {najwiecejHp}");

}

static void Task5()
{
    Player player1 = new Player("Maciuś", 100, 25, 1, 0);

    List<Enemy> enemies = new List<Enemy>
    {
        new Enemy("Goblin", 30, 8, 0, 0, 0),
        new Enemy("Nietoperz", 20, 5, 0, 0, 0),
        new Enemy("Ork", 70, 15, 0, 0, 0)
    };

    int count = 1;
    foreach (Enemy enemy in enemies)
    {
        Console.WriteLine($"{count} - {enemy.Name}: {enemy.Health} HP");
        count++;
    }

    bool succesfullyParsed = false;
    int wybor = 0;
    do
    {
        Console.Write("Wybierz przeciwnika: ");
        succesfullyParsed = int.TryParse(Console.ReadLine()!, out wybor);
        if(succesfullyParsed == false)
        {
            Console.WriteLine("Musi być liczba");
        }

        if(wybor < 0 || wybor > 3)
        {
            Console.WriteLine("Niepoprawny wybór");
        }
    }
    while(succesfullyParsed == false || wybor < 0 || wybor > 3);

    wybor = wybor - 1;

    if(!enemies[wybor].IsAlive())
    {
        Console.WriteLine("Przeciwnik nie zyje");
        return;
    }

    Console.WriteLine($"Wybrałeś przeciwnika {enemies[wybor].Name}");
    
    bool atak = false;
    do
    {
        Console.Write("Czy chcesz zaatakowac przeciwnika?: ");
        succesfullyParsed = bool.TryParse(Console.ReadLine()!, out atak);
        if(succesfullyParsed == false)
        {
            Console.WriteLine("Musi być true/false");
        }
    }
    while(succesfullyParsed == false);

    if(atak)
    {
        enemies[wybor].TakeDamage(10);
        Console.WriteLine($"Zadajesz 10 punktów obrazeń, przeciwnik posiada; {enemies[wybor].Health} HP");
    }

}

static void Task6()
{
    Player player1 = new Player("Maciuś", 100, 25, 1, 0);

    List<Enemy> enemies = new List<Enemy>
    {
        new Enemy("Goblin", 30, 8, 0, 0, 0),
        new Enemy("Nietoperz", 20, 5, 0, 0, 0),
        new Enemy("Ork", 70, 15, 0, 0, 0)
    };

    int count = 1;
    foreach (Enemy enemy in enemies)
    {
        Console.WriteLine($"{count} - {enemy.Name}: {enemy.Health} HP");
        count++;
    }

    bool succesfullyParsed = false;
    int wybor = 0;
    do
    {
        Console.Write("Wybierz przeciwnika: ");
        succesfullyParsed = int.TryParse(Console.ReadLine()!, out wybor);
        if(succesfullyParsed == false)
        {
            Console.WriteLine("Musi być liczba");
        }

        if(wybor < 0 || wybor > 3)
        {
            Console.WriteLine("Niepoprawny wybór");
        }
    }
    while(succesfullyParsed == false || wybor < 0 || wybor > 3);

    wybor = wybor - 1;

    if(!enemies[wybor].IsAlive())
    {
        Console.WriteLine("Przeciwnik nie zyje");
        return;
    }

    Console.WriteLine($"Wybrałeś przeciwnika {enemies[wybor].Name}");
    
    

    bool graDziala = true;
    int tura = 1;
    while(graDziala)
    {
        bool atak = false;
        do
        {
            Console.Write("Czy chcesz zaatakowac przeciwnika?: ");
            succesfullyParsed = bool.TryParse(Console.ReadLine()!, out atak);
            if(succesfullyParsed == false)
            {
                Console.WriteLine("Musi być true/false");
            }
        }
        while(succesfullyParsed == false);

        if(atak)
        {
            enemies[wybor].TakeDamage(10);
            Console.WriteLine($"Tura: {tura} Zadajesz 10 punktów obrazeń, przeciwnik posiada: {enemies[wybor].Health} HP");
            if(player1.IsAlive() && enemies[wybor].IsAlive())
            {
                player1.TakeDamage(enemies[wybor].Damage);
                Console.WriteLine($"Otrzymujesz {enemies[wybor].Damage} obrażeń posiadasz teraz: {player1.Health} HP");
            }
            
        }
        else
        {
            if(player1.IsAlive())
            {
                player1.TakeDamage(enemies[wybor].Damage);
                Console.WriteLine($"Otrzymujesz {enemies[wybor].Damage} obrażeń posiadasz teraz: {player1.Health} HP");
            }
        }

        if(!player1.IsAlive())
        {
            graDziala = false;
            Console.WriteLine("Umierasz!");
        }

        if(!enemies[wybor].IsAlive())
        {
            graDziala = false;
            Console.WriteLine($"Pokonujesz przeciwnika w {tura} turze.");
        }

        tura++;
    }
}

static void Task7()
{
    Player player1 = new Player("Maciuś", 100, 25, 1, 0);

    List<HealthItem> plecak = new List<HealthItem>
    {
        new HealthItem("Potion", 10, 1, 40)
    };

    bool graDziala = true;
    while(graDziala)
    {
        bool succesfullyParsed = false;
        int wybor = 0;
        do
        {
            Console.Write("Wybierz akcje:\n1 - Dodaj potion leczacy\n2 - Wyświetl plecak\n3 - Użyj wybranego przedmiotu z plecaka\n4 - Wyrzuć przedmiot z plecaka\n5 - Wyjdź\n Twój wybór: ");
            succesfullyParsed = int.TryParse(Console.ReadLine()!, out wybor);
            if(succesfullyParsed == false)
            {
                Console.WriteLine("Musi być liczba");
            }

            if(wybor < 1 || wybor > 5)
            {
                Console.WriteLine("Niepoprawny wybór");
            }
        }
        while(succesfullyParsed == false || wybor < 1 || wybor > 5);

        if(wybor == 1)
        {
            plecak[0].AddOne();
            Console.WriteLine($"Dodajesz 1 potion do plecaka, posiadasz teraz {plecak[0].Amount} potionów");
        }

        if(wybor == 2)
        {
            foreach(HealthItem item in plecak)
            {
                Console.WriteLine($"{item.Name}, w ilosci {item.Amount}, leczy {item.HealAmount}");
            }
        }

        if(wybor == 3)
        {
            if(plecak[0].Amount > 0)
            {
                player1.Heal(plecak[0].UseOne());
                Console.WriteLine($"Uzywasz jednego potiona do leczenia, posiadasz teraz {player1.Health} HP.");
            }
            else
            {
                Console.WriteLine("Nie posiadasz żadnych potionów.");
            }
        }

        if(wybor == 4)
        {
            plecak[0].RemoveOne();
            Console.WriteLine($"wyrzucasz jeden potion, masz teraz {plecak[0].Amount} potionów.");
        }

        if(wybor == 5)
        {
            graDziala = false;
        }
    }
}

// static void Task8()
// {
//     Random rand = new Random();
//     List<Enemy> enemies = new List<Enemy>
//     {
//         new Enemy("Goblin", 30, 8, 0, 0, 0),
//         new Enemy("Nietoperz", 20, 5, 0, 0, 0),
//         new Enemy("Ork", 70, 15, 0, 0, 0),
//         new Enemy("Troll", 90, 25, 0, 0, 0),
//         new Enemy("Smok", 100, 40, 0, 0, 0),
//     };
//     Player player = new Player("Jan", 100, 40, 1, 0);

//     int count = 1;
//     foreach (Enemy enemy in enemies)
//     {
//         Console.WriteLine($"{count} - {enemy.Name}: {enemy.Health} HP");
//         count++;
//     }

//     bool succesfullyParsed = false;
//     int wybor = 0;
//     do
//     {
//         Console.Write("Wybierz przeciwnika: ");
//         succesfullyParsed = int.TryParse(Console.ReadLine()!, out wybor);
//         if(succesfullyParsed == false)
//         {
//             Console.WriteLine("Musi być liczba");
//         }

//         if(wybor < 1 || wybor > 5)
//         {
//             Console.WriteLine("Niepoprawny wybór");
//         }
//     }
//     while(succesfullyParsed == false || wybor < 1 || wybor > 5);

//     wybor = wybor - 1;

//     if(!enemies[wybor].IsAlive())
//     {
//         Console.WriteLine("Przeciwnik nie zyje");
//         return;
//     }

//     Console.WriteLine($"Wybrałeś przeciwnika {enemies[wybor].Name}");
    
    

//     bool graDziala = true;
//     int tura = 1;
//     while(graDziala)
//     {
//         int akcja = 0;
//         do
//         {
//             Console.Write("Co chcesz zrobić?\n1 - Zaatakować przeciwnika\n2- Uciec\n"); // Tutaj koniec pracy narazie, dokończyć
//             succesfullyParsed = bool.TryParse(Console.ReadLine()!, out atak);
//             if(succesfullyParsed == false)
//             {
//                 Console.WriteLine("Musi być true/false");
//             }
//         }
//         while(succesfullyParsed == false);

//         if(atak)
//         {
//             enemies[wybor].TakeDamage(10);
//             Console.WriteLine($"Tura: {tura} Zadajesz 10 punktów obrazeń, przeciwnik posiada: {enemies[wybor].Health} HP");
//             if(player1.IsAlive() && enemies[wybor].IsAlive())
//             {
//                 player1.TakeDamage(enemies[wybor].Damage);
//                 Console.WriteLine($"Otrzymujesz {enemies[wybor].Damage} obrażeń posiadasz teraz: {player1.Health} HP");
//             }
            
//         }
//         else
//         {
//             if(player1.IsAlive())
//             {
//                 player1.TakeDamage(enemies[wybor].Damage);
//                 Console.WriteLine($"Otrzymujesz {enemies[wybor].Damage} obrażeń posiadasz teraz: {player1.Health} HP");
//             }
//         }

//         if(!player1.IsAlive())
//         {
//             graDziala = false;
//             Console.WriteLine("Umierasz!");
//         }

//         if(!enemies[wybor].IsAlive())
//         {
//             graDziala = false;
//             Console.WriteLine($"Pokonujesz przeciwnika w {tura} turze.");
//         }

//         tura++;
//     }
// }
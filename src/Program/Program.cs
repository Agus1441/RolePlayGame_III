using System;

public class Program
{
    static void Main()
    {
        Enano enano1 = new Enano("Gimli", 120, 18, 12, 8, 0);
        Mago mago1 = new Mago("Gandalf", 80, 10, 8, 20, 0);
        Elfo elfo1 = new Elfo("Legolas", 100, 20, 10, 15, 0);

        Enemigo enemigo1 = new Enemigo("Orco1","Orco", 80, 15, 8, 14, 5);
        Enemigo enemigo2 = new Enemigo("Goblin1","Goblin", 100, 12, 6, 21, 3);

        List<IPersonaje> heroes = new List<IPersonaje> { enano1, mago1, elfo1 };
        List<Enemigo> enemies = new List<Enemigo> { enemigo1, enemigo2 };

        Encuentro encounter = new Encuentro(heroes, enemies);

        encounter.Pelear();
    }
}

    


using NUnit.Framework;
using System.Collections.Generic;

namespace LibraryTests;

public class Tests
{
    [Test]
    public void PruebaDeAtaque()
    {
        IPersonaje mago1 = new Mago("Solomon", 80, 10, 40, 70, 0);
        IPersonaje enano1 = new Enano("Baltazar", 50, 120, 50, 10, 0);
        string resultado = enano1.Atacar(mago1);
        Assert.That(resultado, Is.EqualTo("Muerto"));
    }
    [Test]
    public void PruebaDeVeneno()
    {
        Mago mago2 = new Mago("Andreus", 80, 20, 35, 75, 0);
        Elfo elfo2 = new Elfo("Clarence", 90, 60, 70, 50, 0);
        mago2.AtaqueVeneno(elfo2);
        Assert.IsTrue(elfo2.Vida < 90);
    }
    [Test]
    public void PruebaDeFuego()
    {
        Mago mago3 = new Mago("Colusus", 70, 5, 30, 85, 0);
        Elfo elfo3 = new Elfo("Efestus", 100, 65, 85, 50, 0);
        mago3.AtaqueFuego(elfo3);
        Assert.IsTrue(elfo3.Vida < 77);
    }
    [Test]
    public void PruebaDeCuracion()
    {
        Enano enano4 = new Enano("Samanta", 50, 80, 50, 10, 0);
        string resultado2 = enano4.RecibirCura(20);
        Assert.That(resultado2, Is.Not.EqualTo("Muerto"));
        Assert.IsTrue(enano4.Vida > 50);
    }
    [Test]
    public void PruebaDePelea()
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

        Assert.That(heroes.Count, Is.Not.EqualTo(0));
        Assert.That(enemies.Count, Is.EqualTo(0));
    }
}
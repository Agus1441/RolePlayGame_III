using System.Security;
using System;
using System.Collections.Generic;
public class Encuentro
{
    List<IPersonaje> heroesToRemove = new List<IPersonaje>();
    List<Enemigo> enemiesToRemove = new List<Enemigo>();
    public int Contador = 0;
    public List<IPersonaje> Heroes { get; set; }
    public List<Enemigo> Enemigos { get; set; }
    public Encuentro(List<IPersonaje> heroes, List<Enemigo> enemigos)
    {
        Heroes = heroes;
        Enemigos = enemigos;
    }
    
    public void Pelear()
    {
        while(Heroes.Count > 0 && Enemigos.Count > 0)
        {
            foreach(var enemies in Enemigos)
            {
                Heroes[Contador].RecibirAtaque(enemies.Ataque);
                if (Heroes[Contador].Vida <= 0)
                {
                    Console.WriteLine(Heroes[Contador].Nombre+" murio");
                    heroesToRemove.Add(Heroes[Contador]);
                }
                if(Contador >= Heroes.Count)
                Contador += 1;
                {
                    Contador=0;
                }
            }
            foreach(var heroe in Heroes)
            {
                foreach(var enemies in Enemigos)
                {
                    enemies.RecibirAtaque(heroe.Ataque);
                    if (enemies.Vida <= 0)
                    {
                        heroe.PuntosVictoria += enemies.PuntosVictoria;
                        Console.WriteLine(enemies.Nombre+" murio");
                        enemiesToRemove.Add(enemies);
                    }
                }
            }
            foreach(var heroe in Heroes)
            {
                if(heroe.PuntosVictoria==5)
                {
                    heroe.RecibirCura(100);
                    heroe.PuntosVictoria=heroe.PuntosVictoria-5;
                }
            }
            foreach (var heroToRemove in heroesToRemove)
            {
                Heroes.Remove(heroToRemove);
            }
            foreach (var enemyToRemove in enemiesToRemove)
            {
                Enemigos.Remove(enemyToRemove);
            }
        }
    }
}
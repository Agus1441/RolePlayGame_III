using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public string Raza { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    public int Magia { get; set; }
    public List<CrearElemento> Elementos { get; set; }
    public int PuntosVictoria { get; set; }

    public Mago(string nombre, int vida, int ataque, int defensa, int magia, int puntosVictoria)
    {
        this.Nombre = nombre;
        this.Raza = "Mago";
        this.Vida = vida;
        this.Ataque = ataque;
        this.Defensa = defensa;
        this.Magia = magia;
        this.Elementos = new List<CrearElemento>();
        this.PuntosVictoria = puntosVictoria;
        
    }
    public int AtaqueFisico()
    {
        foreach(var item in Elementos){
            Ataque += item.ValordeAtaqueFisico();
        }
        return Ataque;

    }
    public int  ValorDefensa()
    {
        foreach(var item in Elementos){
            Defensa += item.ValordeDefensa();
        }
        return  Defensa;

    }
    public int AtaqueMagico()
    {
        foreach(var item in Elementos){
            Magia += item.ValordeAtaqueMagico();
        }
        return  Magia;

    }
    public string RecibirAtaque(int RecibirAtaque)
    {
      Vida -= RecibirAtaque;
      if (Vida <= 0)
      {
        return "Muerto";
      }else{
        return Convert.ToString(Vida);
      }
    }
    public string RecibirCura(int RecibirCura)
    {
      if (Vida <= 0)
      {
        return "Está Muerto";
      }
      else
      {
      Vida += RecibirCura;
      return Convert.ToString(Vida);
      }
    }
    public string Atacar(IPersonaje PersonajeAtacado)
    {
        
        int dañoataque = Ataque-PersonajeAtacado.Defensa; 
        return PersonajeAtacado.RecibirAtaque(dañoataque);
    }
    public string AtacarConMagia(IPersonaje PersonajeAtacado)
    {
        
        int dañoataque = Magia; 
        return PersonajeAtacado.RecibirAtaque(dañoataque);
    }
    
    public void AtaqueVeneno(IPersonaje PersonajeAtacado)
    {
        int dañoataque = LibroDeHechizos.Veneno(); 
        PersonajeAtacado.RecibirAtaque(dañoataque);
        PersonajeAtacado.RecibirAtaque(dañoataque);
        PersonajeAtacado.RecibirAtaque(dañoataque);
    }
    public void AtaqueFuego(IPersonaje PersonajeAtacado)
    {
        int dañoataque = LibroDeHechizos.Fuego(); 
        PersonajeAtacado.RecibirAtaque(dañoataque);
        PersonajeAtacado.RecibirAtaque(dañoataque);
        
    }
    public void Curación(IPersonaje PersonajeAtacado)
    {
        int valorCura = LibroDeHechizos.Curación(); 
        PersonajeAtacado.RecibirCura(valorCura);
    }
}



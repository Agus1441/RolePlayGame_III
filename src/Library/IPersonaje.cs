public interface IPersonaje
{
    string Nombre { get; set; }
    int Vida { get; set; }
    int Ataque { get; set; }
    int Defensa { get; set; }
    int Magia { get; set; }
    List<CrearElemento> Elementos { get; set; }
    int PuntosVictoria { get; set; }

    int AtaqueFisico();
    int ValorDefensa();
    int AtaqueMagico();
    string RecibirAtaque(int RecibirAtaque);
    string RecibirCura(int RecibirCura);
    public string Atacar(IPersonaje PersonajeAtacado);
}

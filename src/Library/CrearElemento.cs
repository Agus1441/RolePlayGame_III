public class CrearElemento
{
    public string ElementoNombre { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorMagia { get; set; }

    public CrearElemento(string elementoNombre, int valorAtaque, int valorDefensa, int valorMagia)
    {
        this.ElementoNombre = elementoNombre;
        this.ValorAtaque = valorAtaque;
        this.ValorDefensa = valorDefensa;
        this.ValorMagia = valorMagia;
    }
    public int ValordeAtaqueFisico()
    {
        return ValorAtaque;
    }
    public int ValordeAtaqueMagico()
    {
        return ValorMagia;
    }
    public int ValordeDefensa()
    {
        return ValorDefensa;
    }
}
public class GestorElemento
{
    public static void AñadirElementos(IPersonaje crearPersonaje, CrearElemento crearElemento)
    {
        
        crearPersonaje.Elementos.Add(crearElemento);

    }
    
}


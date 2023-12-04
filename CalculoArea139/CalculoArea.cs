namespace Area;

public class CalculoArea
{
    public static double areaCubo(int aresta)
    {
        double area = 6 * Math.Pow(aresta, 2);
        return area;
    }

    public static void Main()
    {
       Console.WriteLine($"A área do cubo com aresta de comprimento {aresta} é: {areaCubo}");  
    }

 
}
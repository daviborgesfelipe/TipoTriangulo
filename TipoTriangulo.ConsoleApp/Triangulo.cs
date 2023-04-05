namespace TipoTriangulo.ConsoleApp
{
    internal class Triangulo
    {
        internal int ladoUm;
        internal int ladoDois;
        internal int ladoTres;
        internal void DescobrirTipoTriangulo()
        {
            if (ladoUm <= 0 || ladoDois <= 0 || ladoTres <= 0)
            {
                Console.WriteLine("\nO triangulo possui um ou mais lado com o valor igual ou menor que zero (0)");
                Console.ReadLine();
            }
            else if (ladoUm > ladoDois + ladoTres || ladoDois > ladoUm + ladoTres || ladoTres > ladoUm + ladoDois)
            {
                Console.WriteLine("\nO triangulo pussui um lado com o valor maior que a soma dos outros dois valores");
                Console.ReadLine();
            }
            else if (ladoUm == ladoDois && ladoDois == ladoTres)
            {
                Console.WriteLine("\nO triangulo é Equilatero possui todos os lados com os mesmos valores");
                Console.ReadLine();
            }
            else if (ladoUm == ladoDois || ladoDois == ladoTres || ladoTres == ladoUm)
            {
                Console.WriteLine("\nO triangulo é Isósceles possui dois lados com os valores iguais");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nO triangulo é Escaleno possui todos os lados de valores diferentes");
                Console.ReadLine();
            }
        }
    }
}
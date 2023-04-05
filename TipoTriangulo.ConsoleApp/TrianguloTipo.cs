using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoTriangulo.ConsoleApp
{
    internal class TrianguloTipo
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro lado e aperte enter");
                triangulo.ladoUm = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo lado e aperte enter");
                triangulo.ladoDois = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o terceiro lado e aperte enter");
                triangulo.ladoTres = int.Parse(Console.ReadLine());
                triangulo.DescobrirTipoTriangulo();
            }
        }
    }
}

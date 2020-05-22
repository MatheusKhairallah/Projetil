using System;

namespace Projeti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Um projétil é lançado em um ângulo θ° (teta graus) a uma velocidade inicial v0 m/s. Calcule, em metros, o alcance máximo xmax e a altura máxima atingida hmax.");
            Console.WriteLine("Entre com a velocidade, em m/s: 30");
            Console.WriteLine("Entre com o ângulo, em graus: 30");

            double V0=30;
            double G=10;
            double Sen30=0.5;
            double resultado=V0 * Sen30;
            double resultado2=Math.Pow(resultado, 2);
            double Resultado=2 * G;
            double resultado3=resultado2 / Resultado;

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Altura máxima= {resultado3}m");

            double resul=Math.Pow(V0, 2);
            double resul2=resul / 2;
            double resul3=resul2 / 10;
            double resul4=resul3 * 1.73;
            double resul5=Math.Round(resul4);

            Console.WriteLine($"Alcance= {resul5}m");
            


        
        }
    }
}

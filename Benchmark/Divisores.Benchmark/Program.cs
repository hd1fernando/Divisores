using Divisores.Dominio;
using System;
using System.Diagnostics;

namespace Divisores.Benchmark
{
    class Program
    {
        const ulong REPETICOES = 1_000_000;

        static void Main(string[] args)
        {

            var stopWatch = new Stopwatch();
            var gcAntesGen2 = GC.CollectionCount(2);
            var gcAntesGen1 = GC.CollectionCount(1);
            var gcAntesGen0 = GC.CollectionCount(0);

            stopWatch.Start();

            CalcularPrimo();

            stopWatch.Stop();

            Console.WriteLine($"{nameof(Numero)}:");
            Console.WriteLine($"Quantidade de Números {REPETICOES}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGen2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGen1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGen0}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }

        static void CalcularPrimo()
        {
            for (ulong i = 1; i <= REPETICOES; i++)
            {
                Numero numero = new((long)i);
                var resultado = numero.EhPrimo();
                Console.WriteLine($"{numero} - {resultado}");
            }
        }

        static void EncontrarDivisores()
        {
            for (ulong i = 1; i <= REPETICOES; i++)
            {
                Numero numero = new((long)i);
                numero.Divisores();
            }
        }
    }
}

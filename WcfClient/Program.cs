using System;
using WcfClient.CidadesService;

namespace WcfClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool finish = false;

            do
            {
                ObtemCidadePorEstadoClient proxy = new ObtemCidadePorEstadoClient();
                Console.WriteLine("Informe o estado! ex: SP, RJ, PR");

                foreach (string cidade in proxy.Obter(Console.ReadLine()))
                {
                    Console.WriteLine(cidade);
                }

                Console.ReadKey();
                Console.WriteLine("=========================  Deseja sair? (SIM => fecha o programa) ou (NÂO => Continua)");

                finish = (Console.ReadLine().Trim().ToLower() == "sim");

            } while (!finish);
        
        }
    }
}

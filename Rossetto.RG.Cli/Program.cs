using Rossetto.RG.Dal.DAL;
using Rossetto.RG.Dal.Service;

namespace Rossetto.RG.Cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRossettoDbContext context = new RossettoDbContext();
            var service = new RossettoService(context);

            
            if (args.Length > 1 && args[0].ToLower() == "-import")
            {
                var url = args[1];
                service.ImportEspionsFromFichier(url);
            }
            else
            {
                Console.WriteLine("URL fichier texte : ");
                var url1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(url1))
                {
                    service.ImportEspionsFromFichier(url1);
                }
                
            }
        }
    }
}

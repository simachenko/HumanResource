using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBD;
using HumanResource;
using UserFeaturs;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleContext db = new SampleContext("ntnUser");
            User inter = new User();
            Dossier person1 = new Dossier("Andrew1", "Simachenko", "AB-123456", true, 4, "The good Programer");
            Dossier person2 = new Dossier("Andrew2", "Simachenko", "AB-123456", true, 4, "The good Programer");
            Dossier person3 = new Dossier("Andrew3", "Simachenko", "AB-123456", true, 4, "The good Programer");

            Dossier person = new Dossier("Andrew4", "Simachenko", "AB-123456", true, 4, "The good Programer");
            inter.Clear();
            inter.AddDossier(person);
            inter.AddDossier(person1);
            inter.AddDossier(person2);

            List<Dossier> extract = inter.GetWorkers();
            foreach(Dossier ex in extract)
            {
                Console.WriteLine(ex.GetName);
            }
            inter.EditWorkers(person.DossierId,person3);
            List<Dossier> extract2 = inter.GetWorkers();
            foreach (Dossier ex in extract2)
            {
                Console.WriteLine(ex.GetName);
            }
            /*dB.EditWorker(person.DossierId, person1);
            IQueryable<Dossier> extract2 = dB.GetWorkers();
            foreach (Dossier ex in extract)
            {
                Console.WriteLine(ex.GetName);
            }
            */

            Console.ReadKey();
        }
    }
}

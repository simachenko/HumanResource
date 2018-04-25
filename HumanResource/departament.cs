using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource
{
    public class Departament
    {
        public int DepartamentId { set; get; }

        string name;
        List<Dossier> workers;

        public Departament()
        {
            workers = new List<Dossier>();
        }
        public void AddWorker(Dossier pers)
        {
            if (pers != null)
                workers.Add(pers);
            else
                throw new NullReferenceException(name + " please insert valid dossier");
        }

        public void DellWorker(Dossier pers)
        {
            workers.Remove(pers);
        }
        public void Edit(Dossier old, Dossier add)
        {
            DellWorker(old);
            AddWorker(add);
        }
        public List<Dossier> Workers
        {
            set
            {
                this.workers = value;
            }
            get
            {
                return this.workers;
                
            }
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                if (name != null)
                    return this.name;
                else
                    throw new NullReferenceException(" This departament has no name ");
            }
        }



    }
}

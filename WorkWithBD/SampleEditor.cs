using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HumanResource;
namespace WorkWithBD
{
    public class SampleEditor
    {
        SampleContext Db;

        public SampleEditor()
        {
           
        }

        public SampleEditor(string filename)
        {
            Db = new SampleContext(filename);
            
        }

        public IQueryable<Dossier> GetWorkers()
        {

            return Db.Workers.AsQueryable<Dossier>();

        }

        public IQueryable<Departament> GetDepartaments()
        {

            return Db.DepList.AsQueryable<Departament>();

        }

        public void Insert(Dossier person)
        {
            Db.Entry<Dossier>(person).State = EntityState.Added;
            Db.SaveChanges();

        }
        public void Insert(Departament person)
        {
            Db.Entry<Departament>(person).State = EntityState.Added;
            Db.SaveChanges();

        }
        public void Delete(Dossier person)
        {
            Db.Entry<Dossier>(person).State = EntityState.Deleted;
            Db.SaveChanges();

        }
        public void Delete(Departament person)
        {
            Db.Entry<Departament>(person).State = EntityState.Deleted;
            Db.SaveChanges();

        }

        public void EditWorker(int? WorkerId, Dossier person)
        {
            Dossier old = Db.Workers.Where(ex => ex.DossierId == WorkerId).FirstOrDefault();

            if (old != null)
            {
                
                Editor(old, person);
                Db.Entry<Dossier>(old).State = EntityState.Modified;
                Db.SaveChanges();

            }
        }

        public void EditDepartament(int? DepartId, Departament person)
        {

            Departament old = Db.DepList.Where(ex => ex.DepartamentId == DepartId).FirstOrDefault();

            if (old != null)
            {
                Editor(old, person);
                Db.Entry<Departament>(old).State = EntityState.Modified;
                Db.SaveChanges();

            }
        }
        public void ClearDB()
        {
            IQueryable<Dossier> test = GetWorkers();
            foreach (Dossier ex in test)
            {
                Db.Entry<Dossier>(ex).State = EntityState.Deleted;
            }
            Db.SaveChanges();

        }

        void Editor(Dossier old, Dossier silv)
        {
            old.Army = silv.Army;
            old.Character = silv.Character;
            old.Expirience = silv.Expirience;
            old.GetName = silv.GetName;
            old.GetSurname = silv.GetSurname;
            old.Reprimands = silv.Reprimands;
            old.Photo = silv.Photo;

        }
        void Editor(Departament old, Departament add)
        {
            old.Name = add.Name;
            old.Workers = add.Workers;
        }
    }
}

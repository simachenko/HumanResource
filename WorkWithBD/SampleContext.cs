using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HumanResource;

namespace WorkWithBD
{
    public class SampleContext  : DbContext
    {
        public SampleContext(string DbName) : base(DbName)
        {

            CreateDatabaseIfNotExists<SampleContext> create = new CreateDatabaseIfNotExists<SampleContext>();
            create.InitializeDatabase(this);
            
            
            
        }
        public DbSet<Dossier> Workers { set; get; }
        public DbSet<Departament> DepList { set; get; }





        //public IQueryable<Dossier> GetWorkers()
        //{
            
        //    return Workers.AsQueryable<Dossier>();
            
        //}

        //public void InsertWorkers(Dossier person)
        //{
        //    Entry<Dossier>(person).State = EntityState.Added;
        //    SaveChanges();
            
        //}

        //public void DeleteWorkers(Dossier person)
        //{
        //    Entry<Dossier>(person).State = EntityState.Deleted;
        //    SaveChanges();
            
        //}

       
        //public void EditWorker(int? WorkerId, Dossier person)
        //{
        //    Dossier old = Workers.Where(ex => ex.DossierId == WorkerId).FirstOrDefault();

        //    if (old != null) 
        //    {
        //        Editor(old, person);
        //        Entry<Dossier>(old).State = EntityState.Modified;
        //        SaveChanges();
                
        //    }
        //}
        //public void ClearDB()
        //{
        //    IQueryable<Dossier> test = GetWorkers();
        //    foreach(Dossier ex in test)
        //    {
        //        Entry<Dossier>(ex).State = EntityState.Deleted;
        //    }
        //    SaveChanges();
            
        //}

        //void Editor(Dossier old , Dossier silv)
        //{
        //    old.Army = silv.Army;
        //    old.Character = silv.Character;
        //    old.Expirience = silv.Expirience;
        //    old.GetName = silv.GetName;
        //    old.GetSurname = silv.GetSurname;
        //    old.Reprimands = silv.Reprimands;
        //    old.Photo = silv.Photo;

        //}
    }

    
}

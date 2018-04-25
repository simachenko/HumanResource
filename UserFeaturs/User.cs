using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBD;
using HumanResource;
using System.Drawing;
using System.Data.Entity;
namespace UserFeaturs
{
    public class User
    {
        SampleEditor DB = new SampleEditor("NewConnetion");
        IQueryable<Dossier> ListDossier;
        IQueryable<Departament> Dep;

        public User()
        {
            
            ListDossier = DB.GetWorkers();
            Dep = DB.GetDepartaments();
        }

        public void AddDossier(Dossier pers)
        {
            DB.Insert(pers);
            Departament change = pers.departament;
            change.AddWorker(pers);
            DB.EditDepartament(pers.departament.DepartamentId, change);
            Dep = DB.GetDepartaments();
            ListDossier = DB.GetWorkers();
        }

        public void AddDepartament(Departament add)
        {
            DB.Insert(add);
            
        }
        public List<Dossier> GetWorkers()
        {
            if (ListDossier != null)
                return ListDossier.ToList();
            else
                throw new NullReferenceException();
        }
        public List<Departament> GetDepartaments()
        {
            if (Dep != null)
                return Dep.ToList();
            else
                throw  new NullReferenceException();
        }

        public void CreateDossier(string FirstName, string Surname, string Passport, bool Army, int Expirience, string Characteristic, string Photo)
        {
            Dossier pers = new Dossier(FirstName, Surname, Passport, Army, Expirience, Characteristic, Photo);
            if (ListDossier.Where(c => c == pers).Take(1) == null)
            {
                DB.Insert(pers);
                Departament change = pers.departament;
                change.AddWorker(pers);
                DB.EditDepartament(pers.departament.DepartamentId, change);
                Dep = DB.GetDepartaments();
                ListDossier = DB.GetWorkers();
            }
            else
                throw new Exception("This Dossier is already exist");
        }

        public void DeleteDossier(Dossier Pers)
        {

            DB.Delete(Pers);
            ListDossier = DB.GetWorkers();
        }
        public void DeleteDepartament(Departament delete)
        {

            DB.Delete(delete);
            Dep = DB.GetDepartaments();
        }

        public IQueryable<Dossier> GetDossier()
        {
            if (ListDossier != null) 
            return ListDossier;
            else
            {
                throw new NullReferenceException("DataBase is empty");
            }
        }

        public void Clear()
        {
            DB.ClearDB();
            ListDossier = DB.GetWorkers();
        }
        public void EditWorkers(int? id, Dossier pers)
        {
            DB.EditWorker(id,pers);
            ListDossier = DB.GetWorkers();

        }

    }
}

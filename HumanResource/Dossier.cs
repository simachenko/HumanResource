using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
namespace HumanResource
{
    public class Dossier
    {
        public int DossierId { set; get; }

       
        string firstName;
        string surname;
        string passportCode;
        bool army;
        int experience;
        string characteristic;
        string biography;
        string post;
        List<Reprimand> reprimands;
        Departament dep;
        public string Photo { get; set; }

        public string Code
        {

             set
            {
                string pattern = @"[A-Z]{2}-[0-9]{6}";
                if (Regex.IsMatch(value, pattern))
                {
                    this.passportCode = value;
                }
                else
                    throw new RegexMatchTimeoutException();

            }
             get
            {
                return passportCode;
            }
        }

        public Dossier()
        {
            
        }
        public Dossier(string FirstName, string Surname, string Passport, bool Army, int Expirience, string Characteristic, string post)
        {
            this.firstName = FirstName;
            this.surname = Surname;
            this.army = Army;
            this.experience = Expirience;
            this.characteristic = Characteristic;
            this.Code = Passport;
            this.post = post;
           
        }
        public Dossier(string FirstName, string Surname, string Passport, bool Army, int Expirience, string Characteristic, string Photo, string post)
        {
            this.firstName = FirstName;
            this.surname = Surname;
            this.army = Army;
            this.experience = Expirience;
            this.characteristic = Characteristic;
            this.Code = Passport;
            this.Photo = Photo;
            this.post = post;
            
        }
        public Departament departament
        {
            set
            {
                this.dep = value;
            }
            get
            {
                return this.dep;
            }
        }

        public string Post
        {
            set
            {
                this.post = value;
            }
            get
            {
                return this.post;
            }
        }

        public string GetName
        {
            set
            {
                this.firstName = value;
            }
            get
            {
                return this.firstName;
            }
        }

        public string GetSurname
        {
            set
            {
                this.surname = value;
            }
            get
            {
                return this.surname;
            }

        }

        public string GetBiography
        {
            set
            {
                this.biography = value;
            }
            get
            {
                return this.biography;
            }

        }

        public int Expirience
        {
            set
            {
                this.experience = value;
            }
            get
            {
                return this.experience;
            }
        }

        public string PassportCode()
        {
            
                return this.passportCode;
            
        }
        public bool Army
        {
            set
            {
                
                    army = value;
                
            }
            get
            {
                return this.army;
            }
        }

        public string Character
        {
            set
            {
               
                    characteristic = value;
                
            }
            get
            {
                return this.characteristic;
            }
        }

        public List<Reprimand> Reprimands
        {
            set
            {
                
                    reprimands = value;
                
            }
            get
            {
                if (reprimands != null)
                    return this.reprimands;
                else
                    return null;
            }
        }

        public void AddReprimand(Reprimand another)
        {
            if (reprimands != null)
            {
                reprimands = new List<Reprimand>();
                this.reprimands.Add(another);
            }
            else
                this.reprimands.Add(another);
        }


        public void SetPhoto(string path)
        {
            if (path != null)
                Photo = path;
            else
                throw new NullReferenceException("Insert a path to image");
        }


        public string GetInfo()
        {
            //string ppz = string.Format($"name:{this.firstName,-15}surname:{this.surname,-15}");
            //return ppz + ppz.Length;
            //return  String.Format($"Name:{this.firstName,-15}\tSurname:{this.surname,-15}\tExpirience:{this.experience,-15}\tPost:{this.post,-15}");
            return "Name: " + this.firstName + "\tSurname: " + this.surname+"\tPost: " + this.post; 
        }
    }
}

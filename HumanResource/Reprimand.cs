using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace HumanResource
{
    public class Reprimand

    {
        public int ReprimandId { set; get;}

        string reason;
        DateTime DateTime;
        Dossier person;
        public Reprimand()
        { }
        public Reprimand(string Reason, DateTime Date, Dossier pers)
        {
            this.reason = Reason;
            this.DateTime = Date;
            this.person = pers;
        }
        public string GetReason()
        {
            return this.reason;
        }
        public DateTime GetDateTime()
        {
            return this.DateTime;
        }
        public Dossier GetDossier()
        {
            return this.person;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HumanResource;
using WorkWithBD;
using System.Data.Entity;
using System.Web.ModelBinding;
using System.IO;
using System.Data.SqlClient;
namespace DataBase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
            
            if (Page.IsPostBack)
            {
                    
                    Dossier person = new Dossier();
                    IValueProvider provider = new FormValueProvider(ModelBindingExecutionContext);

                if (TryUpdateModel<Dossier>(person, provider))
                {
                    
                    // Загрузить фото профиля с помощью средств .NET
                    HttpPostedFile photo = Request.Files["photo"];
                    if (photo != null)
                    {
                        using (BinaryReader b = new BinaryReader(photo.InputStream))
                            person.Photo = b.ReadBytes((int)photo.InputStream.Length);
                    }



                    using (SampleContext context = new SampleContext())
                    {
                        context.Workers.Add(person);
                        context.SaveChanges();
                    }
                    
                }
            }
                
               
            
        }
    }
}
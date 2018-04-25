using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource;
namespace UserInterface
{
    public partial class ShowDossier : Form
    {
        Dossier pers;
        Dossier old;
        bool edited;
        bool deleted;
        List<Departament> dep;
        public ShowDossier(Dossier pers, List<Departament> dep)
        {
            if(pers!=null)
            {
                this.pers = pers;
                this.old = pers;
            }
            if(dep!=null)
            {
                this.dep = dep;

            }
            edited = false;
            deleted = false;
            InitializeComponent();
        }
        public bool IsEdited()
        {
            
            return edited;
        }
        public bool IsDeleted()
        {
            return deleted;
        }
        public Dossier GetPerson()
        {
            if (edited)
                return pers;
            else
                return old;

        }
        private void nameLabel1_Click(object sender, EventArgs e)
        {

        }
        private void EnableLB()
        {
            
            nameLabel1.Text = "Name: " + pers.GetName;
            surnameLabel1.Text = "Surname: " + pers.GetSurname;
            charLabel1.Text = "Characteristic: " + pers.Character;
            codeLabel1.Text = "PassportCode: " + pers.PassportCode();
            biographyBox1.Text = pers.GetBiography;
            armyLabel2.Text = "Army: " + pers.Army.ToString();
            expLabel2.Text = "Expirience: " + pers.Expirience;
            postLabel2.Text = "Post: " + pers.Post;
            depLabel2.Text = "Departament: " + pers.departament.Name;
            pictureBox1.Image = Image.FromFile(pers.Photo);
            biographyBox1.ReadOnly = true;
        }

        private void ShowDossier_Load(object sender, EventArgs e)
        {
            EnableLB();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleted = true;
            edited = false;
            Close();
            
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            EditDossier edit = new EditDossier(pers,dep);
            edit.ShowDialog();
            if(edit.IsEdited())
            {
                pers = edit.GetPers();
                edited = true;
                EnableLB();
            }
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

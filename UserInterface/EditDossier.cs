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
using System.IO;
using System.Text.RegularExpressions;
namespace UserInterface
{
    public partial class EditDossier : Form
    {
        Dossier pers ;
        string photo;
        bool created;
        List<Departament> dep;

        public EditDossier(Dossier pers, List<Departament> Deps)
        {
            this.pers = pers;
            created = false;
            this.dep = Deps;
            InitializeComponent();
            codeBox1.Mask = @"LL-000000";
        }
        public EditDossier(List<Departament> Deps)
        {
            this.dep = Deps;
            created = false;
            InitializeComponent();
            codeBox1.Mask = @"LL-000000";
            EnableDepart();
        }
        public void EnableDepart()
        {
            depComboBox1.Items.Clear();
            foreach (Departament ex in dep)
                depComboBox1.Items.Add(ex.Name);

        }
        public Dossier GetPers()
        {
            return pers;
        }
        private void createButton1_Click(object sender, EventArgs e)
        {
            try
            {
                InputCheck();
                if (pers == null)
                    pers = new Dossier();

                if (armyButton1.Checked)
                    pers.Army = true;
                if (noArmyButton1.Checked)
                    pers.Army = false;
                pers.GetName = nameBox1.Text;
                pers.GetSurname = surnameBox1.Text;
                pers.Code = codeBox1.Text;
                pers.Character = charBox1.Text;
                pers.Post = postBox1.Text;
                foreach (Departament ex in dep)
                {
                    if(ex.Name== depComboBox1.Text)
                    pers.departament = ex;
                }
                if (int.TryParse(expBox1.Text, out int x))
                    pers.Expirience = x;
                else
                    throw new FormatException("please insert number");
                pers.GetBiography = biographyBox1.Text;
                if (this.photo != null)
                    pers.Photo = this.photo;
                created = true;
                Close();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetPict()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "pict (*.jpg)|*.jpg| pict (*.png)|*.png| pict (*.jpeg)|*.jpeg";
            open.ShowDialog();
            pictureBox1.Image = Image.FromFile(open.FileName);

            this.photo =  open.FileName;

        }
        private void EnableLB()
        {
            
            if (pers.Army)
                armyButton1.Checked = true;
            else
                noArmyButton1.Checked = false;
            nameBox1.Text = pers.GetName;
            surnameBox1.Text = pers.GetSurname;
            charBox1.Text = pers.Character;
            codeBox1.Text =pers.PassportCode();
            expBox1.Text += pers.Expirience;
            postBox1.Text = pers.Post;
            EnableDepart();
            codeBox1.ReadOnly = true;
            biographyBox1.Text = pers.GetBiography;
            pictureBox1.Image = Image.FromFile(pers.Photo);
        }

        private void InputCheck()
        {
            
            if(nameBox1.Text==null|| IsNumberContains(nameBox1.Text))
            {
                throw new FormatException("Insert a name only");
            }
            if (surnameBox1.Text == null || IsNumberContains(surnameBox1.Text))
            {
                throw new FormatException("Insert a surname only");
            }
            if (expBox1.Text == null || IsCharContains(expBox1.Text))
            {
                throw new FormatException("Insert a number only");
            }
            if (charBox1.Text == null || IsNumberContains(charBox1.Text))
            {
                throw new FormatException("Insert a characteristic only");
            }
            string pattern = @"[A-Z]{2}-[0-9]{6}";
            if (codeBox1.Text == null || !Regex.IsMatch(codeBox1.Text,pattern))
            {
                throw new FormatException("Insert a [A-Z]{2}-[0-9]{6} only");
            }
            if(this.photo ==null)
            {
                throw new Exception("Please choose photo");
            }
            if(dep==null||dep.Count==0)
            {
                throw new Exception("Please Create a departament ");
            }
            
        }
        private bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }
        private bool IsCharContains(string input)
        {
            foreach (char c in input)
                if (Char.IsLetter(c))
                    return true;
            return false;
        }
        private void EditDossier_Load(object sender, EventArgs e)
        {
            if(pers!=null)
                EnableLB();

        }

        private void photoButton1_Click(object sender, EventArgs e)
        {
            GetPict();
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            created = false;
            Close();
        }
        public bool IsEdited()
        {
            return created;
        }

        private void codeBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

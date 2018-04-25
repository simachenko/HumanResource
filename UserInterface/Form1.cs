using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserFeaturs;
using HumanResource;
using System.Data.Entity;
using System.Text.RegularExpressions;
namespace UserInterface
{
    public partial class Form1 : Form
    {
        User usage;
        List<Dossier> pers;
        List<Departament> depart; 
        public Form1()
        {
            usage = new User();
            pers = new List<Dossier>();
            depart = new List<Departament>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pers = usage.GetWorkers();
            depart = usage.GetDepartaments();
            maskedTextBox1.Mask = @"LL-000000";
            ReDep();
            ReList();
            
        }

        private void ReList()
        {
            foreach (TabPage ex in DepartControl1.TabPages)
            {
                ListBox example = (ListBox)ex.Controls[0];
                example.Items.Clear();
                foreach (Dossier cv in pers)
                {
                    if(ex.Text == cv.departament.Name ||ex.Text=="AllWorkers")
                    example.Items.Add(cv.GetInfo());
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InputCheck();
                NameSearch();
                ExpSearch();
                ArmySearch();
                CodeSearch();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void InputCheck()
        {
            
            if (SearchTextBox1.Text == null || IsNumberContains(SearchTextBox1.Text))
            {
                throw new FormatException("Insert a name only");
            }
            if (expBox1.Text == null || IsCharContains(expBox1.Text))
            {
                throw new FormatException("Insert a number only");
            }
        }



        private void NameSearch()
        {
           
            if (SearchTextBox1.Text != null)
            {

                List<Dossier> tmp = new List<Dossier>();
                foreach (Dossier ex in pers)
                {
                    if (ex.GetName.Contains(SearchTextBox1.Text) || ex.GetSurname.Contains(SearchTextBox1.Text) || ex.PassportCode() == SearchTextBox1.Text)
                    {
                        tmp.Add(ex);
                    }
                }
                pers = tmp;
                ReList();
            }
            

        }
        private void CodeSearch()
        {
            string pattern = @"[A-Z]{2}-[0-9]{6}";
            if (maskedTextBox1.Text != null & Regex.IsMatch(maskedTextBox1.Text, pattern))
            {
                
                
                List<Dossier> tmp = new List<Dossier>();
                foreach (Dossier ex in pers)
                {
                    if (ex.PassportCode() == maskedTextBox1.Text)
                    {
                        tmp.Add(ex);
                    }
                }
                pers = tmp;
                ReList();
            }
            
        }
        private void ArmySearch()
        {
            if (armyButton1.Checked)
            {
                List<Dossier> tmp = new List<Dossier>();
                foreach (Dossier ex in pers)
                {
                    if (ex.Army)
                    {
                        tmp.Add(ex);
                    }

                }
                pers = tmp;
                ReList();
            }
            if (NoArmyButton1.Checked)
            {
                List<Dossier> tmp = new List<Dossier>();
                foreach (Dossier ex in pers)
                {
                    if (ex.Army==false)
                    {
                        tmp.Add(ex);
                    }

                }
                pers = tmp;
                ReList();
            }
            
        }
        private void ExpSearch()
        {
            if (expBox1.Text != null && int.TryParse(expBox1.Text, out int exp))
            {
                List<Dossier> tmp = new List<Dossier>();
                foreach (Dossier ex in pers)
                {
                    if (ex.Expirience == exp)
                    {
                        tmp.Add(ex);
                    }
                }
                pers = tmp;
                ReList();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pers = usage.GetWorkers();
            ReList();
        }

        private void Delete(Dossier pers)
        {
            usage.DeleteDossier(pers);
            this.pers = usage.GetWorkers();
            ReList();
        }

        private void Edit(int? id, Dossier pers)
        {
            usage.EditWorkers(id, pers);
            this.pers = usage.GetWorkers();
            ReList();
        }

        private void ShowButton2_Click(object sender, EventArgs e)
        {
            ListBox gg = (ListBox)DepartControl1.TabPages[DepartControl1.SelectedIndex].Controls[0];
            if (gg.SelectedItem != null)
            {
                Dossier wrk = pers[gg.SelectedIndex];
                ShowDossier show = new ShowDossier(wrk, depart);
                show.ShowDialog();
                if (show.IsEdited())
                {
                    Edit(wrk.DossierId, show.GetPerson());
                }
                if (show.IsDeleted())
                {
                    Delete(wrk);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                EditDossier edit = new EditDossier(depart);
                edit.ShowDialog();
                if (edit.IsEdited())
                {
                    usage.AddDossier(edit.GetPers());
                    this.pers = usage.GetWorkers();
                    ReList();
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ListBox gg = (ListBox)DepartControl1.TabPages[DepartControl1.SelectedIndex].Controls[0];
            if (gg.SelectedItem!=null)
            {
                Dossier wrk = pers[gg.SelectedIndex];
                Delete(wrk);
            }
            else
            {
                MessageBox.Show("LOOSER");
            }

        }
        private void AddDepartament(string name)
        {
            Departament NextDep = new Departament();
            NextDep.Name = name;
            usage.AddDepartament(NextDep);
            depart = usage.GetDepartaments();
            ReDep();
            
            
        }
        private void ReDep()
        {
            for (int i = 1; i < DepartControl1.TabPages.Count; i++)
                DepartControl1.TabPages.RemoveAt(i);
            
            foreach(Departament ex in depart)
            {
                
                TabPage NextPage = new TabPage(ex.Name);
                ListBox NextList = new ListBox();
                NextList.Site = DepartControl1.TabPages[0].Controls[0].Site;
                NextList.Size = DepartControl1.TabPages[0].Controls[0].Size;
                NextList.Items.Clear();
                NextPage.Controls.Add(NextList);
                DepartControl1.TabPages.Add(NextPage);
            }
            ReList();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //if (DepBox1.Visible == true && DepBox1.Text == null)
            //{
            //    DepBox1.Visible = false;
            //}
            //else
            //{

                if (DepBox1.Visible == false)
                {
                    DepBox1.Visible = true;
                }
                else
                {
                    if(DepBox1.Text!=null)
                    AddDepartament(DepBox1.Text);
                    else
                    DepBox1.Visible = false;

                }
            //}
        }


        private void DeleteDepButton5_Click(object sender, EventArgs e)
        {
            if (DepartControl1.SelectedIndex != 0)
            {
                
                
                foreach(Departament ex in depart)
                {
                    if(ex.Name==DepartControl1.SelectedTab.Text)
                    {
                        usage.DeleteDepartament(ex);
                    }
                }
                depart = usage.GetDepartaments();
                DepartControl1.TabPages.RemoveAt(DepartControl1.SelectedIndex);
            }
        }

    }
}

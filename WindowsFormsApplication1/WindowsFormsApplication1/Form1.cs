using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct Osoba
{
    public string name;
    public string surname;
    public string parents;
    public DateTime date;
    public string gender;
    public string pesel;
}



//List<Osoba> list1 = new List<Osoba>();

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        //public List<Osoba> list1 = new List<Osoba>();
        public Osoba[] dowod = new Osoba[10];
        public int number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Osoba tmp = new Osoba();
        
            dowod[number].name = editName.Text;
            dowod[number].surname = editSurname.Text;
            dowod[number].parents = editParent.Text;
            dowod[number].gender = comboGender.Text;
            dowod[number].pesel = editPesel.Text;
            dowod[number].date = dateTimePicker.Value;
            //list1.Add(tmp);
            listBox.Items.Add(dowod[number].surname + " " + dowod[number].name);
            number++;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editName.Text = dowod[listBox.SelectedIndex].name;
            editSurname.Text = dowod[listBox.SelectedIndex].surname;
            editParent.Text = dowod[listBox.SelectedIndex].parents;
            comboGender.Text= dowod[listBox.SelectedIndex].gender;
            editPesel.Text = dowod[listBox.SelectedIndex].pesel;
            dateTimePicker.Value = dowod[listBox.SelectedIndex].date;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int p = 0;
            string str = editPesel.Text;
            if (str.Length == 11)
            {
                if (IsDigitsOnly(str))
                {
                    int x1 = (str[2] - '0') * 10 + (str[3] - '0');
                    if ((x1 >= 1) && (x1 <= 12))
                    {
                        int x2 = (str[2] - '0') * 10 + (str[3] - '0');
                        if ((x2 >= 1) && (x2 <= 31)) p = 1;
                    }
                }
            }
            if (p == 1) labelOk.Text = "OK";
            else labelOk.Text = "NO OK";
        }
    }
}

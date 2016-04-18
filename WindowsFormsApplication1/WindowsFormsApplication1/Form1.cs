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

        public static List<Osoba> list1 = new List<Osoba>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Osoba tmp = new Osoba();
            tmp.name = editName.Text;
            tmp.surname = editSurname.Text;
            tmp.parents = editParent.Text;
            tmp.gender = comboGender.Text;
            tmp.pesel = editPesel.Text;
            tmp.date = dateTimePicker.Value;
            list1.Add(tmp);
            listBox.Items.Add(tmp.surname + " " + tmp.name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editName.Text = list1[listBox.SelectedIndex].name;
            editSurname.Text = list1[listBox.SelectedIndex].surname;
            editParent.Text = list1[listBox.SelectedIndex].parents;
            comboGender.Text= list1[listBox.SelectedIndex].gender;
            editPesel.Text = list1[listBox.SelectedIndex].pesel;
            dateTimePicker.Value = list1[listBox.SelectedIndex].date;
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

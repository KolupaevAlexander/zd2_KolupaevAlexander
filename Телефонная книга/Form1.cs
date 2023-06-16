using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Телефонная_книга
{
    public partial class MainForm :Form
    {
        PhoneBook phoneBook = new PhoneBook();
        Regex reg = new Regex(@"^\(9\d\d\)\d\d\d-\d\d-\d\d$");
        public MainForm ()
        {
            InitializeComponent();
            string path = "Numbers.txt";
            PhoneBookLoader.Load(phoneBook, path);
            
            ShowPhonenumbers();
        }
        public void ShowPhonenumbers()
        {
            numbersList.Items.Clear();
            foreach (var contact in phoneBook.Numbers)
                numbersList.Items.Add(contact.Value + ":" + contact.Key);
        }
        private void addNumber_Click (object sender, EventArgs e)
        {
            if (name.Text != "" && phone.Text != "")
            {
                if (reg.IsMatch(phone.Text))
                    phoneBook.AddNumber(name.Text, phone.Text);
                else
                    MessageBox.Show("Формат телефона такой: (9**)***-**-**");
            } 
            else
                MessageBox.Show("Поля пусты");

            ShowPhonenumbers();
        }
        private void deleteNumber_Click (object sender, EventArgs e)
        {
            if (name.Text != "" && phone.Text != "")
                phoneBook.DeleteNumber(name.Text, phone.Text);
            else
                MessageBox.Show("Поля пусты");

            ShowPhonenumbers();
        }
        private void numbersList_SelectedIndexChanged (object sender, EventArgs e)
        {
            name.Text = numbersList.SelectedItem.ToString().Split(':')[0];
            phone.Text = numbersList.SelectedItem.ToString().Split(':')[1];
        }
        private void searchByName_Click (object sender, EventArgs e)
        {
            if (name.Text != "")
                searchedNumbers.Text = phoneBook.SearchNumber(name.Text);
        }
        private void saveNumbers_Click (object sender, EventArgs e)
        {
            string path = "Numbers.txt";
            PhoneBookLoader.Save(phoneBook, path);
        }
        private void sortnumbers_Click (object sender, EventArgs e)
        {
            phoneBook.Numbers = phoneBook.Numbers.OrderBy(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            ShowPhonenumbers();
        }
        private void exit_Click (object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

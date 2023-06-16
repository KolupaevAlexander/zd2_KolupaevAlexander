using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонная_книга
{
    class PhoneBookLoader
    {
        public static void Load (PhoneBook phoneBook, string fileName) 
        {
            if (File.Exists(fileName))
            {
                StreamReader database = new StreamReader(fileName);
                while (!database.EndOfStream)
                {
                    var line = database.ReadLine();
                    phoneBook.AddNumber(line.Split(';')[0], line.Split(';')[1]);
                }
                database.Close();
            } 
            else
                MessageBox.Show("Файл не найден");
        }
        public static void Save (PhoneBook phoneBook, string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamWriter save = new StreamWriter(fileName);
                foreach (var phone in phoneBook.Numbers)
                    save.WriteLine(phone.Value + ";" + phone.Key);
                save.Close();
            } else
                MessageBox.Show("Файл не найден");

        }
    }
}

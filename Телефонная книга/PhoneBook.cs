using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Телефонная_книга
{
    class PhoneBook
    {
        private Dictionary<string, string> numbers = new Dictionary<string, string>(); // телефон : человек
        public Dictionary<string, string> Numbers { get { return numbers; } set { numbers = value; } }

        public void AddNumber (string person, string telephone)
        {
            if (!numbers.ContainsKey(telephone))
                numbers.Add(telephone, person);
            else
                MessageBox.Show("Данный телефонный номер уже есть в базе");
        }
        public void AddNumber (Contact person)
        {
            if (!numbers.ContainsKey(person.Phone))
                numbers.Add(person.Phone, person.Name);
            else
                MessageBox.Show("Данный телефонный номер уже есть в базе");
        }
        public void DeleteNumber (string person, string telephone)
        {
            if (numbers.ContainsKey(telephone))
                numbers.Remove(telephone);
            else
                MessageBox.Show("Данного телефона нет в базе");
        }
        public void DeleteNumber (Contact person)
        {
            if (numbers.ContainsKey(person.Phone))
                numbers.Remove(person.Phone);
            else
                MessageBox.Show("Данного телефона нет в базе");
        }

        public string SearchNumber (string person)
        {
            if (numbers.ContainsValue(person))
            {
                string answer = "";
                foreach (var number in numbers.Where(numbers => numbers.Value == person))
                    answer += number.Key + "\n";
                return answer;
            }
            else
                return "Контакта с\nданным именем\nнет в базе";
        }

    }
}

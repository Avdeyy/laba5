using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLogic
{
    public class Logic
    {
        Person pp0 = new Person() { Name = "Чесноков Виталий Александрович", Id = 0 };
        Person pp1 = new Person() { Name = "Паравохов Аркадий Петрович", Id = 0 };
        Person pp2 = new Person() { Name = "Шишкин Владлен Игнатьевич", Id = 0 };
        Person pp3 = new Person() { Name = "Шинелев Акакий Акакиевич", Id = 0 };
        Person pp4 = new Person() { Name = "Турков Михаил Олегович", Id = 0 };
        Person pp5 = new Person() { Name = "Пучков Егор Семёнович", Id = 0 };
        Person pp6 = new Person() { Name = "Тохбатулин Евгений Олегович", Id = 0 };
        Person pp7 = new Person() { Name = "Рюмкин Алексей Иванович", Id = 0 };
        Person pp8 = new Person() { Name = "Соломина Елизавета Сергеевна", Id = 0 };
        Person pp9 = new Person() { Name = "Пешкова Инга Васильевна", Id = 0 };
        public List<Person> PeopleZ { get; set; } = new List<Person>();
        public List<Person> PeopleF { get; set; } = new List<Person>();
        public List<Person> PeopleT { get; set; } = new List<Person>();

        public void Addpeople()
        {
            PeopleZ.Add(pp0);
            PeopleZ.Add(pp1);
            PeopleZ.Add(pp2);
            PeopleZ.Add(pp3);
            PeopleZ.Add(pp4);
            PeopleZ.Add(pp5);
            PeopleZ.Add(pp6);
            PeopleZ.Add(pp7);
            PeopleZ.Add(pp8);
            PeopleZ.Add(pp9);
        }

        public string GetAllP()
        {
            string listOfp = "";

            foreach (Person pp in PeopleZ)
            {
                listOfp += $"[{pp.Id}]" + " " + pp.Name + "\r\n";
            }
            foreach (Person pp in PeopleF)
            {
                listOfp += $"[{pp.Id}]" + " " + pp.Name + "\r\n";
            }
            return listOfp;
        }
        public void GrowUp()
        {
            Random rnd = new Random();
            foreach (Person pp in PeopleZ)
            {
                if (PeopleZ.Count > 0)
                {
                    if (rnd.Next(2) == 0) //Проверка на прохождение
                    {
                        pp.Id++;
                    }
                }
            }
            foreach (Person pp in PeopleF)
            {
                if (PeopleF.Count > 0)
                {
                    if (rnd.Next(2) == 0) //Проверка на прохождение
                    {
                        pp.Id++;
                    }
                }
            }
        }

        public void GrowUpZ()
        {
            Random rnd = new Random();
            foreach (Person pp in PeopleZ)
            {
                if (PeopleZ.Count > 0)
                {
                    if (rnd.Next(2) == 0) //Проверка на прохождение
                    {
                        pp.Id++;
                    }
                }
            }
        }

        public void GrowUpF()
        {
            Random rnd = new Random();
            foreach (Person pp in PeopleF)
            {
                if (PeopleF.Count > 0)
                {
                    if (rnd.Next(2) == 0) //Проверка на прохождение
                    {
                        pp.Id++;
                    }
                }
            }
        }

        public string StayZ()
        {
            string listOfz = "";
            foreach (Person pp in PeopleZ)
            {
                if (pp.Id == 0)
                {
                    listOfz += $"[{pp.Id}]" + " " + pp.Name + "\r\n";
                }
            }
            return listOfz;
        }

        public string StayF()
        {
            string listOfz = "";
            foreach (Person pp in PeopleF)
            {
                if (pp.Id == 1)
                {
                    listOfz += $"[{pp.Id}]" + " " + pp.Name + "\r\n";
                }
            }
            return listOfz;
        }

        public void FirstV()
        {
            foreach (Person pp in PeopleZ)
            {
                if (pp.Id == 1)
                {
                    PeopleF.Add(pp);
                }
            }
            foreach (Person pp in PeopleF)
            {
                PeopleZ.Remove(pp);
            }
        }

        public string SecondV()
        {
            string listOft = "";
            foreach (Person pp in PeopleF)
            {
                if (pp.Id == 2)
                {
                    PeopleT.Add(pp);
                }
            }
            foreach (Person pp in PeopleT)
            {
                PeopleF.Remove(pp);
                listOft += $"[{pp.Id}]" + " " + pp.Name + "\r\n";
            }
            return listOft;
        }
    }
}

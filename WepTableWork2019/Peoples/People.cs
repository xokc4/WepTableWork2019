using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepTableWork2019.Peoples
{
    public class People
    {
        public People()
        {
        }

        public People(int iD, string surname, string name, string lastname, string phone, string adress, string description)
        {
            ID = iD;
            Surname = surname;
            Name = name;
            Lastname = lastname;
            Phone = phone;
            Adress = adress;
            Description = description;
        }

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
    }
}

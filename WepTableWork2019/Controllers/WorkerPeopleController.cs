using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.contextFolder;
using WepTableWork2019.Peoples;

namespace WepTableWork2019.Controllers
{
    public class WorkerPeopleController : Controller, InterfaceBD
    {
        public static DataContext data = new DataContext();
        public static List<People> PeopleFull = data.people.ToList();
        public static People peopleOnly = new People();
        public IActionResult People(string IDPeople)
        {
            peopleOnly = PeopleMethod(IDPeople);
            return View(peopleOnly);
        }
        /// <summary>
        /// метод для выбора пользователя
        /// </summary>
        /// <param name="IDPeople"></param>
        /// <returns></returns>
        public People PeopleMethod(string IDPeople)
        {
            People people = new People();
            foreach(var item in PeopleFull)
            {
                if(item.ID == Convert.ToInt32(IDPeople))
                {
                    people = item;
                }
            }
            return people;
        }
        /// <summary>
        /// метод для изменения пользователя 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="phone"></param>
        /// <param name="adress"></param>
        /// <param name="description"></param>
        public void Update(int Id, string surname, string name, string lastname, string phone, string adress, string description)
        {
            People PeopleUpdate = new People(peopleOnly.ID, surname, name, lastname, phone, adress, description);
            data.people.Remove(data.people.Find(peopleOnly.ID));
            data.SaveChanges();
            data.people.Add(PeopleUpdate);
            data.SaveChanges();
        }
        /// <summary>
        /// метод для удаления пользователя 
        /// </summary>
        /// <param name="Id"></param>
        
        public void Delete(string Id)
        {
            data.people.Remove(data.people.Find(peopleOnly.ID));
            data.SaveChanges();
            View("Views/WorkerFull/Index");
        }
    }
}

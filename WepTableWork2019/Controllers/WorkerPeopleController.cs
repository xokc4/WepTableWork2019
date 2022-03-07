using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.Peoples;

namespace WepTableWork2019.Controllers
{
    public class WorkerPeopleController : Controller
    {
        public static List<People> PeopleFull = WorkerFullController.PeoplesBD;
        public IActionResult People(string IDPeople)
        {
            People pep = PeopleMethod(IDPeople);
            return View(pep);
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
    }
}

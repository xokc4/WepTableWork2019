using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.Peoples;

namespace WepTableWork2019.Controllers
{
    public class WorkerFullController : Controller
    {
        private string path = @"PeoplesBD.Json";// путь файла
        public static List<People> PeoplesBD;// коллекция с информацией 
        public IActionResult Index()
        {
            PeoplesBD = PeopleConclusion.peoplesConclus(path);
            //условие для создания информаци 
            if (PeoplesBD == null)
            {
                PeopleConclusion.CreatBD(path);
                PeoplesBD = PeopleConclusion.peoplesConclus(path);
            }
            return View(PeoplesBD);
        }
    }
}

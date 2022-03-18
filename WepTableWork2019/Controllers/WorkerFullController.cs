using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.contextFolder;
using WepTableWork2019.Peoples;

namespace WepTableWork2019.Controllers
{
    public class WorkerFullController : Controller
    {
        private string path = @"PeoplesBD.Json";// путь файла
        public static List<People> PeoplesBD;// коллекция с информацией 
        public static DataContext data = new DataContext();
        public IActionResult Index()
        {

            return View(СhoiceBD(path));
        }
        /// <summary>
        /// Метод для добавления пользователей
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="phone"></param>
        /// <param name="adress"></param>
        /// <param name="description"></param>
        
        public void AddPeople(string surname, string name, string lastname, string phone, string adress, string description)
        {
            People PeopleLast = new People();
            People people1 =  data.people.ToList().Last();
            People people = new People(people1.ID+1, surname, name, lastname, phone, adress, description);
            data.people.Add(people);
            data.SaveChanges();
        }
        public List<People> PeopleBD()
        {
            List<People> peopleBD = data.people.ToList();
            List<People> peoples = new List<People>();
            foreach (var item in peopleBD)
            {
                peoples.Add(item);
            }
            
            return peoples;
        }
        public void CreatBDSQL()
        {
            
            foreach(People item in PeoplesBD)
            {
                People PeopleOne = new People(item.ID,item.Surname,item.Name,item.Lastname,item.Phone,item.Adress,item.Description);
                data.people.Add(PeopleOne);
                data.SaveChanges();
            }
            
        }
        /// <summary>
        /// выбор базы данных
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<People> СhoiceBD(string path)
        {
            PeoplesBD = PeopleConclusion.peoplesConclus(path);
            //условие для создания информаци 
            try
            {
                if(data.people.Count()== 0)
                {
                    CreatBDSQL();
                    return PeopleBD();
                }
                else
                {
                    return PeopleBD();
                }
            }
            catch(SqlException e)
            {
                return PeoplesBD; 
            }
        }
    }
}

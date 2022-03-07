using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.Peoples;

namespace WepTableWork2019
{
    public class PeopleConclusion
    {
        /// <summary>
        /// создание информации в json файл
        /// </summary>
        /// <param name="path"></param>
        public static void CreatBD(string path)
        {
            List<People> people = new List<People>();
            Random random = new Random();
            int RandomPhone = random.Next(79000000, 79999999);
            for (int i = 0; i < 15; i++)
            {
                people.Add(new People(i, $"Surname_{i}", $"Name_{i}", $"Lastname_{i}",
                    $"+{RandomPhone}", $"adress_{i}", $"description of people {i}"));
            }
            JsonBD.SerializeJson(path, people);
        }
        /// <summary>
        /// вывод информации в коллекцию
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<People> peoplesConclus(string path)
        {
            List<People> peoples = JsonBD.DeserializeJson(path);
            return peoples;
        }
    }
}

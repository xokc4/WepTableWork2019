using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WepTableWork2019.Peoples;

namespace WepTableWork2019
{
    public class JsonBD
    {
        /// <summary>
        /// сериализация Json файла
        /// </summary>
        /// <param name="path"></param>
        /// <param name="people"></param>
        public static void SerializeJson(string path, List<Peoples.People> people)
        {
            string json = JsonConvert.SerializeObject(people);// создания сериализации
            File.WriteAllText(path, json);// запись
        }
        /// <summary>
        /// десериализация json файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<People> DeserializeJson(string path)
        {
            List<People> сompanies = new List<People>();
            string json = File.ReadAllText(path);// открытие папки
            сompanies = JsonConvert.DeserializeObject<List<People>>(json);//десериализация
            return сompanies;// вывод листа
        }
    }
}

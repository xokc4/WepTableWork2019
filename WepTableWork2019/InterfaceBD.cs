using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepTableWork2019
{
    interface InterfaceBD
    {
        public void Delete(string Id);
        public void Update(int Id,string surname, string name, string lastname, string phone, string adress, string description);
    }
}

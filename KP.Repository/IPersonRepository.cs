using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Repository
{
    interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        void Add(Person person);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            Person person = new Person();
            person.PersonId = id;
            return person;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Service.PersonService
{
    public interface IPersonService
    {
        public Person GetPersonById(int id);
        public Person AddPerson(PersonDto value);
      /*  IEnumerable<Person> GetAllPersons(PersonDto value);*/
    }
}

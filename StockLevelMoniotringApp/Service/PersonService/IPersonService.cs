using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Dto;

namespace WindowsFormsApp1.Service.PersonService
{
    public interface IPersonService
    {
        public Person GetPersonById(int id);
        public Person AddPerson(PersonDto value);
      /*  IEnumerable<Person> GetAllPersons(PersonDto value);*/
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Repository;


namespace WindowsFormsApp1.Service.PersonService
{
    /// <summary>
    /// Service Person odpowiada za logikę biznesową wszystkic działań związanych z Person
    /// Services odpowiadaj za logikę biznesowa jego metoedy np. dostaja w parametrze jakieś dane które są interpretowane w ciele metody
    /// np. dostajemy paramiet 2 i 5 nasza metoda odpowaida za dodawanie  więc logika bedzie wykoanie działania 2+ 5 i zwracmey wtedy 7
    /// </summary>
    public class PersonService : IPersonService
    {
        private readonly IGenericRepository<Person> _genericRepository;

        public PersonService(IGenericRepository<Person> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Person AddPerson(PersonDto value)
        {
            var newPerson = new Person() { Name = value.Name };
            _genericRepository.AddEntity(newPerson);
            //Trzeba pobrać nowo dodany item do bayz aby zwracalo z ID 
            return newPerson;
        }

     /*   public IEnumerable<Person> GetAllPersons(PersonDto value)
        {

        }*/

        public Person GetPersonById(int id)
        {
            return _genericRepository.GetEntityById(id);
        }
    }
}

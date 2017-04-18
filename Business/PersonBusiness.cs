using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Infraestructure.Repositories;
using Domain;
using Domain.Entities;

namespace Business
{
    public class PersonBusiness
    {

        PersonRepository pr = new PersonRepository();

        public List<Domain.Entities.PersonDTO> getAllPerson()
        {

            return pr.GetAll();
        }

        public void addPerson(Domain.Entities.Person person)
        {

            pr.Add(person);

        }

        public void modifyPerson(Domain.Entities.Person person)
        {

            pr.Modify(person);

        }

        public void removePerson(Domain.Entities.Person person)
        {

            pr.Remove(person);
        }

        public Domain.Entities.Person getPersonId(int id)
        {

            return pr.Get(id);
        }




    }
}

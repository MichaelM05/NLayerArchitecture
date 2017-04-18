using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Domain.Entities;
using Domain.ContractRepositories;

namespace Infraestructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        public void Add(Domain.Entities.Person person)
        {
            try
            {
                using (var context = new Tarea02JMEntities())
                {                    
                    person.age = this.Age(person.birthDate);
                    context.Person.Add(person);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }
        }

        public void Remove(Domain.Entities.Person person)
        {
            using (var context = new Tarea02JMEntities())
            {
                var entities = (from p in context.Person
                                where p.idPerson == person.idPerson
                                select p).Single();
                context.Person.Remove(entities);
                context.SaveChanges();
            }
        }

        public void Modify(Domain.Entities.Person person)
        {
            try
            {
                using (var context = new Tarea02JMEntities())
                {
                    person.age = this.Age(person.birthDate);
                    context.Entry(person).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }
        }

        public Domain.Entities.Person Get(int id)
        {
            using (var context = new Tarea02JMEntities())
            {
                var strSQL = from p in context.Person
                             where p.idPerson == id
                             select p;
                return strSQL.First();
            }
        }

        public List<Domain.Entities.PersonDTO> GetAll()
        {
            using (var context = new Tarea02JMEntities())
            {
                return (from p in context.Person
                        select new Domain.Entities.PersonDTO
                        {
                            idPerson = p.idPerson,
                            dni = p.dni,
                            name = p.name,
                            surnames = p.surnames,
                            birthDate = p.birthDate,
                            age = p.age
                        }).ToList();
            }
        }

        public int Age(System.DateTime date) {

            int currentYear = DateTime.Now.Year;
            return currentYear - date.Year; 

        }

    }
}

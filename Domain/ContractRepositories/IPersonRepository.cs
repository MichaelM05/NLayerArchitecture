using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.ContractRepositories
{
    public interface IPersonRepository
    {

        void Add(Person person);

        void Remove(Person person);

        void Modify(Person person);

        int Age(System.DateTime date);

        Person Get(int id);

        List<PersonDTO> GetAll();

    }
}

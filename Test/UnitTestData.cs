using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Domain.Entities;
using Infraestructure.Repositories;
using Infraestructure;
using Domain;

namespace Test
{
    [TestClass]
    public class UnitTestData
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Domain.Entities.Person p = new Domain.Entities.Person();
            //p.dni = "116620032";
            //p.name = "Joseph";
            //p.surnames = "Cordero Marin";
            //p.birthDate = DateTime.Parse("1996-10-21");
            //p.age = 20;
            PersonRepository pr = new PersonRepository();
            //pr.Add(p);

            //Domain.Entities.Person p1 = pr.Get(4);
            //p1.name = "Adolfo";
            //pr.Modify(p1);

            //pr.Remove(p1);

            List<PersonDTO> persons = pr.GetAll();

            foreach (PersonDTO person in persons)
            {
                Console.Write(person.dni + " - " + person.name + " " + person.surnames + 
                    " - " + person.birthDate + " - " + person.age);
                Console.Write("\n");
            }

        }
    }
}

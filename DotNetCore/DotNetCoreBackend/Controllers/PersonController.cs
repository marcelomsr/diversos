using Infra.NH.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;

namespace DotNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        public ISession Session { get; }

        public PersonController(ISession session)
        {
            Session = session;
        }

        //http://localhost:5000/api/person
        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            // SQL
            //var persons = Session.CreateSQLQuery("SELECT * FROM prvmarcelosr.person ORDER BY Name")
            //                   .AddEntity(typeof(Person))
            //                   .List<Person>();

            // HQL
            //var persons = Session.CreateQuery("select p from Person p").List<Person>();

            // Criteria
            //var persons = Session.CreateCriteria<Person>().List<Person>();

            // QueryOver
            var persons = Session.QueryOver<Person>().List();

            return persons;
        }

        //http://localhost:5000/api/person/1
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            var person = Session.Get<Person>(id);

            return person;
        }

        //http://localhost:5000/api/person
        [HttpPost]
        public Person Insert([FromBody]Person person)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                person.CreationDate = DateTime.Now;
                person.UpdatedDate = DateTime.Now;

                Session.SaveOrUpdate(person);
                tx.Commit();
            }

            return person;
        }

        //http://localhost:5000/api/person/1
        [HttpPut("{id}")]
        public Person Update(int id, [FromBody]Person person)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var personDB = Session.Get<Person>(id);

                personDB.Name = person.Name;
                personDB.UpdatedDate = DateTime.Now;

                Session.SaveOrUpdate(personDB);
                tx.Commit();
            }

            return person;
        }

        //http://localhost:5000/api/person/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var person = Session.Get<Person>(id);

                if (person == null)
                    return;

                Session.Delete(person);
                tx.Commit();
            }
        }
    }
}
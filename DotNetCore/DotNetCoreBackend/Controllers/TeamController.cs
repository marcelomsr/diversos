using Infra.NH.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;

namespace DotNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        public ISession Session { get; }

        public TeamController(ISession session)
        {
            Session = session;
        }

        //http://localhost:5000/api/person
        [HttpGet]
        public IEnumerable<Team> GetAll()
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
            var teams = Session.QueryOver<Team>().List();

            return teams;
        }

        //http://localhost:5000/api/person/1
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            var team = Session.Get<Team>(id);

            return team;
        }

        //http://localhost:5000/api/person
        [HttpPost]
        public Team Insert([FromBody]Team team)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                Session.SaveOrUpdate(team);
                tx.Commit();
            }

            return team;
        }

        //http://localhost:5000/api/person/1
        [HttpPut("{id}")]
        public Team Update(int id, [FromBody]Team team)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var personDB = Session.Get<Team>(id);

                personDB.Name = team.Name;

                Session.SaveOrUpdate(personDB);
                tx.Commit();
            }

            return team;
        }

        //http://localhost:5000/api/person/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var tx = Session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var team = Session.Get<Team>(id);

                if (team == null)
                    return;

                Session.Delete(team);
                tx.Commit();
            }
        }
    }
}
using Infra.NH;
using Infra.NH.Models;
using System;

namespace NHibernate.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            //NHibernateHelper.AdoDB2Test();

            var sessionFactory = NHibernateHelper.CreateSessionFactory();

            var personToSave = new Person()
            {
                Name = "Marcelo Ribeiro",
                CreationDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var person = new Person()
                {
                    Name = "Marcelo Ribeiro",
                    CreationDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                };

                session.SaveOrUpdate(personToSave);

                tx.Commit();
            }

            using (var session = sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                var personSaved = session.Get<Person>(personToSave.Id);

                tx.Commit();
            }

        }
    }
}

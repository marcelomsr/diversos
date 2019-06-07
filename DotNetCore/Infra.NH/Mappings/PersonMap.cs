using Infra.NH.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Infra.NH.Mappings
{
    public class PersonMap : ClassMapping<Person>
    {
        public PersonMap()
        {
            Table("prvmarcelosr.person");

            Id(p => p.Id, m =>
                {
                    m.Generator(Generators.Increment);
                });

            Property(p => p.Name, m =>
            {
                m.NotNullable(true);
            });

            Property(p => p.CreationDate, m =>
            {
                m.NotNullable(true);
            });

            Property(p => p.UpdatedDate, m =>
            {
                m.NotNullable(true);
            });
        }
    }
}

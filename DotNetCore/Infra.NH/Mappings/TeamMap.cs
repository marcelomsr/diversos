using Infra.NH.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Infra.NH.Mappings
{
    public class TeamMap : ClassMapping<Team>
    {
        public TeamMap()
        {
            Table("prvmarcelosr.team");

            Id(p => p.Id, m =>
            {
                m.Generator(Generators.Increment);
            });

            Property(p => p.Name, m =>
            {
                m.NotNullable(true);
            });
        }
    }
}

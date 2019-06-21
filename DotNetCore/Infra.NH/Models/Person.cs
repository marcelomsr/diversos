using System;

namespace Infra.NH.Models
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual int IdTeam { get; set; }
    }
}

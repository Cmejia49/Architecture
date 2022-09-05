using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Base
{
    public abstract class BaseEntity
    {
        [NotMapped]
        private List<BaseDomainEvent> _events;
        [NotMapped]
        public IReadOnlyList<BaseDomainEvent>  Events => _events.AsReadOnly();

        protected void AddEvent(BaseDomainEvent @event)
        {
            _events.Add(@event);
        }

        protected void RemoveEvent(BaseDomainEvent @event)
        {
            _events.Remove(@event);
        }

    }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        [Key]
        public TKey Id { get; set; }
    }
}

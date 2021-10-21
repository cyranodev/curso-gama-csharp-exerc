using System;

namespace Gama.ATM.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            var now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
            IsActive = true;
        }

        public DateTime CreatedAt { get; private set; }
        public Guid Id { get; private set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
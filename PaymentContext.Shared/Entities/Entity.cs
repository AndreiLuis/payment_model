using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}
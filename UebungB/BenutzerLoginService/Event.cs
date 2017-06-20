using System;

namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public abstract class Event
    {
        public string AggregateId { get; protected set; }

        public DateTime TimeStamp { get; private set; }

        protected Event()
        {
            this.TimeStamp = DateTime.Now;
        }
    }
}
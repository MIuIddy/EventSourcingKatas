using System.Collections.Generic;
using System.Linq;

namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public class EventSpeicher : IEventSpeicher
    {
        private readonly IList<Event> events = new List<Event>();

        public void Speichern(Event myEvent)
        {
            events.Add(myEvent);
        }

        //TODO: Die Liste readonly machen
        public IList<Event> HoleEvents(string aggregateId)
        {
            //todo: Wegen Aggregate, wird Probleme machen, Wie ist das Konzept??
            return events
                .Where(itm => itm.AggregateId == aggregateId)
                .ToList();
        }
    }
}
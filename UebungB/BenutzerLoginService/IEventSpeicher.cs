using System.Collections.Generic;

namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public interface IEventSpeicher
    {
        void Speichern(Event myEvent);
        IList<Event> HoleEvents(string aggregateId);
    }
}
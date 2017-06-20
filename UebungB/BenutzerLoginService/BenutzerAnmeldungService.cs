using System.Linq;
using System.Linq.Expressions;

namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public class BenutzerAnmeldungService : IBenutzerAnmeldungService
    {
        public IEventSpeicher SpeicherMedium { get; }

        public void BenutzerRegistrieren(string benutzername, string vorname, string nachname, string passwort)
        {
            var eventBenutzerRegistriert = new BenutzerWurdeRegistriert(benutzername, passwort, vorname, nachname);
            this.SpeicherMedium.Speichern(eventBenutzerRegistriert);
        }

        public bool DarfBenutzerAnmelden(string benutzername, string passwort)
        {
            var benutzerRelevanteEvents = SpeicherMedium.HoleEvents(benutzername);
            var benutzerWurdeRegistriertEvent = benutzerRelevanteEvents
                .OfType<BenutzerWurdeRegistriert>()
                .FirstOrDefault();

            if (benutzerWurdeRegistriertEvent != null)
            {
                return benutzerWurdeRegistriertEvent.Passwort == passwort;
            }

            return false;
        }

        public BenutzerAnmeldungService(IEventSpeicher speicherMedium)
        {
            this.SpeicherMedium = speicherMedium;
        }
    }
}
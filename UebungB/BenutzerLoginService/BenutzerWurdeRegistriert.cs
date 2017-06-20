namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public class BenutzerWurdeRegistriert : Event
    {
        public string Passwort { get; }
        public string Vorname { get; }
        public string Nachname { get; }

        public BenutzerWurdeRegistriert(string benutzername, string passwort, string vorname, string nachname)
        {
            AggregateId = benutzername;
            Passwort = passwort;
            Vorname = vorname;
            Nachname = nachname;
        }
    }
}
﻿namespace CodeKata.EventSourcing.BenutzerLoginService
{
    public interface IBenutzerAnmeldungService
    {
        void BenutzerRegistrieren(string benutzername, string vorname, string nachname, string passwort);
        bool DarfBenutzerAnmelden(string benutzername, string passwort);
    }
}
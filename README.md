# Event-Sourcing-Katas
Code Katas um das Konzept von Event Sourcing und CQRS zu verstehen, üben und vertiefen. 

## Übung A 
Implementiere bitte die folgende Schnittstelle so, dass
die Änderungen als Ereignis aufgebildet und aufgezeichnet werden.

```csharp
public interface IBenutzerAnmeldungService
{
	void BenutzerRegistrieren(string benutzername, string vorname, string nachname, string passwort);
	bool DarfBenutzerAnmelden(string benutzername, string passwort);
}
```

In welcher Form und wo diese Ereignisse gespeichert werden sollen, kannst du selber entscheiden.

Diese sind zu beachten:
	Es darf keine relationale Datenbank als Speichermedium genutzt werden.
	Die Ereignisse werden in Vergangenheit formuliert.
	Plausibilitätsprüfungen dürfen ignoriert werden.
	Ausnahmsweise dürfen die Passwörter als Plaintext gespeichert und geschickt werden.
	Unit-Tests müssen geschrieben werden. Du kannst dir selber entscheiden, ob Test-first oder Test-nach.

Ziel der Übung A: Eine andere Sichtweise beim Entwickeln einer Lösung einnehmen.

## Übung B: 
Erweitere die Schnittstelle mit einer PasswortAendern Methode.

## Übung C: 
Implementiere eine andere Komponente, die Mails an Administrator schickt wenn ein neuer Benutzer registriert wurde.

## Übung D:
NEventStore als Speichermedium für die Ereignisse einsetzen.
Zielverständnis: Der Einsatz eines Event Stores bietet den Vorteil, dass alle Änderungen am System jederzeit durch eine Wiederholung der Events deterministisch nachgestellt werden können.

## Übung E:
Entwirf deine Schnittstelle erneut, dass du die Funktionen, die Zustand ändern und die Funktionen, die nur Daten abfragen, von einander trennst.




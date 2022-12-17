using Projektarbeit322.Models;
using System.Collections.Generic;
using Projektarbeit322.ViewModels;

namespace Projektarbeit322.Database
{
    public class Database
    {
        public static List<Kunde> GetKunden()
        {
            List<Kunde> list = new List<Kunde>()
            {
                new Kunde()
                {
                    KundenNr = 0,
                    Vorname = "Peter",
                    Nachname = "Baum",
                    EMail = "Peter.Baum@gmail.com",
                    Telefon = "0791976242",
                    Priority = "Standart",
                    Service = "Kleiner Service",
                    Status = "Offen",
                    Kommentar = "nicht bezahlt",
                },

                new Kunde()
                {
                    KundenNr = 1,
                    Vorname = "Donald",
                    Nachname = "Duck",
                    EMail = "Donald.Duck@gmail.com",
                    Telefon = "0761748213",
                    Priority = "Express",
                    Service = "Heisswachsen",
                    Status = "Abgeschlossen",
                    Kommentar = "Ist sehr reich"
                },

                new Kunde()
                {
                    KundenNr = 2,
                    Vorname = "Stefan",
                    Nachname = "Strasse",
                    EMail = "Stefan.Strasse@gmail.com",
                    Telefon = "0723872342",
                    Priority = "Tief",
                    Service = "Grosser Service",
                    Status = "In-Arbeit",
                    Kommentar = "Bezahlt"
                },

                new Kunde()
                {
                    KundenNr = 3,
                    Vorname = "John",
                    Nachname = "Deer",
                    EMail = "John.Deer@gmail.com",
                    Telefon = "0755979228",
                    Priority = "Express",
                    Service = "Bindung montieren und einstellen",
                    Status = "Offen"
                },

                new Kunde()
                {
                    KundenNr = 4,
                    Vorname = "Simon",
                    Nachname = "Hauser",
                    EMail = "Simon.Hauser@gmail.com",
                    Telefon = "0721478241",
                    Priority = "Tief",
                    Service = "Rennski Service",
                    Status = "In-Arbeit"
                }
            };
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit322.Models
{
    public class Kunde
    {
        public int KundenNr { get; set; }
        public string Vorname { get; set; } = String.Empty;
        public string Nachname { get; set; } = String.Empty;
        public string EMail { get; set; } = String.Empty;
        public string Telefon { get; set; } = String.Empty;
        public string Priority { get; set; } = String.Empty;
        public string Service { get; set; } = String.Empty;
        public string Status { get; set; } = String.Empty;
        public string Kommentar { get; set; } = String.Empty;
    }
}

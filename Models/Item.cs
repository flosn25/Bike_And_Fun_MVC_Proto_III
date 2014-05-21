using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bike_And_Fun_MVC_Proto_III.Models
{
    public class Item
    {
        public string ItemId { get; set; }
        public string itemName { get; set; }
        public Type type { get; set; }
        public Category category { get; set; }

        public string owner { get; set; }           // Shop-/Mandantenkennung
        public string iwan { get; set; }            // Eindeutige Artikelnummer wie EAN
        public string article_no { get; set; }      // Artikelnummer
        public string description { get; set; }     // Artikelbeschreibung
        public decimal unitPrice { get; set; }      // Stückpreis
        public DateTime deftime { get; set; }       // Zeitstempel Artikel gelistet
        public DateTime modtime { get; set; }       // Zeitstempel Artikel zuletzt bearbeitet
        public string seasonCode { get; set; }      // Saison-Code
        public string productGroup { get; set; }    // Produktgruppen-Code
        public string colorCode { get; set; }       // Farb-Code
        public string colorDescription { get; set; }// Farbbeschreibung
        public string size { get; set; }            // Größe
        public bool articleOnline { get; set; }     // 1 = Online, 0 = Offline
 
    }
}
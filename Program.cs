using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buch b1 = new Buch("Halliday Physik", "Halliday, David; Resnick, Robert", 1635, "Physik", "Deutsch", 2017);
            b1.Ausleihen();
            b1.Ausleihen();
            b1.Zurückgeben();
            b1.Zurückgeben();
        }
    }
    /*---Zielstellung---
     * Wir wollen eine Art Datenbank für eine Bibliothek erstellen,
     * in der Bibliothekare und Studenten verschiedene Aktionen ausführen
     * können.
     * 
     * Frage 1: Welche Klasse(n) brauchen wir?
     * Der wichtigste Teil einer Bibliothek sind die Bücher. Wir brauchen 
     * also eine Klasse für Bücher.
     */

    class Buch
    {
        /*Welche Eigenschaften hat ein Buch?
         */
        private string Titel;
        private string Autor;
        private int Seitenzahl;
        private string Fachgebiet;//Mathe, Physik,...
        private string Sprache;
        private int Erscheinungsjahr;
        private string Standort;
        private bool Verfügbar;
        //Welche Eigenschaften sollen im Konstruktor von außen eingegeben
        //werden? Welche stehen ohne Eingabe fest?
        public Buch(string titel, string autor, int seitenzahl, string fachgebiet, string sprache, int jahr)
        {
            Titel = titel;
            Autor = autor;
            Seitenzahl = seitenzahl;
            Fachgebiet = fachgebiet;
            Sprache = sprache;
            Erscheinungsjahr = jahr;
            //Der Standort ist abhängig vom Fachgebiet (wir schreiben eine Methode)
            Verfügbar = true;
        }
        /*Erstellen Sie die Methoden Ausleihen() und Zurückgeben().
         * Die Methode Ausleihen() prüft, ob das Buch verfügbar ist.
         * Wenn das Buch verfügbar ist, wird es verliehen und ist 
         * nicht mehr verfügbar.
         */
        public void Ausleihen()
        {
            if(Verfügbar == true) // oder (Verfügbar)
            {
                Console.WriteLine("Sie haben das Buche " + Titel + " ausgeliehen.");
                Verfügbar = false;
            }
            else
            {
                Console.WriteLine("Das Buch " + Titel + " ist nicht Verfügbar");
            }
        }
        public void Zurückgeben()
        {
            if (!Verfügbar) // oder Verfügbar == false
            {
                Console.WriteLine("Sie haben das Buch " + Titel + " erfolgreich zurückgegeben");
                Verfügbar = true;
            }
            else
            {
                Console.WriteLine("Fehler! " + Titel + " wurde nicht verliehen und kann deshalb nicht zurückgegeben werden. ");
            }
        }
    }
    
        
    



}

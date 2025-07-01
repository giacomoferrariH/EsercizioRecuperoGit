using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGit
{
    internal class Biblioteca
    {
        string nome, indirizzo, orarioApertura, orarioChiusura;
        List<Libro> libri;
        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
            this.libri = libri;
        }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }
        public List<Libro> Libri { get; set; }

        // TODO: Integrare le operazioni della classe Libro nella classe Biblioteca

        public void AggiugniLibro(string autore, string nome, string editore, int anno, int pagine)
        {
            Libro libro = new Libro(autore, nome, editore, anno, pagine);
            libri.Add(libro);
        }
        public Libro CercaLibro(string titolo)
        {
            foreach (Libro libro in libri)
            {
                if (libro.Titolo == titolo)
                    return libro;
                else break;
            }
            return null;
        }
        public static List<Libro> CercaAutore(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach (Libro libro in libriAutore)
            {
                if (libro.Autore == autore)
                    libriAutore.Add(libro);
                else continue;
            }
            return libriAutore;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGit
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string Editore { get; set; }
        public int Anno { get; set; }
        public int Pagine { get; set; }

        public Libro(string autore, string titolo, string editore, int anno, int pagine)
        {
            this.Autore = autore;
            this.Titolo = titolo;
            this.Editore = editore;
            this.Anno = anno;
            this.Pagine = pagine;
        }

        /// <summary>
        /// Restituisce i dati dell'oggetto ricevuto
        /// </summary>
        /// <param name="oggetto"></param>
        /// <returns>Dati dell'oggetto ricevuto in input</returns>
        static string toString(string autore, string titolo, string anno, string editore, int pagine)
        {
            string datiLibro = $"Autore: {autore} \nTitolo: {titolo} \nAnno di pubblicazione: {anno} \nEditore: {editore} \nNumero di pagine: {pagine}";
            return datiLibro;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pagine"></param>
        /// <returns>Numero di ore di lettura in base al numero di pagine (ricevuto in input) del libro</returns>
        static int readingTime(int pagine)
        {
            if (pagine < 100)
                return 1;
            else if (pagine >= 100 && pagine <= 200)
                return 2;
            else if (pagine > 200)
                return pagine / 100;
            else
            {
                Console.WriteLine("Un libro non può avere pagine negative!");
                return 0;
            }
        }
    }
}

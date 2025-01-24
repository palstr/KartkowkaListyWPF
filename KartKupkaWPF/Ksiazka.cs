using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartKupkaWPF
{
    public class Ksiazka
    {
        public string tytul { get; set; }
        public string autor { get; set; }
        public int rokWydania { get; set; }
        public string kategoria { get; set; }
        public bool czyAudioDostepny { get; set; }

        public Ksiazka(string tytul, string autor, int rokWydania, string kategoria, bool czyAudioDostepny)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rokWydania = rokWydania;
            this.kategoria = kategoria;
            this.czyAudioDostepny = czyAudioDostepny;
        }
    }
}

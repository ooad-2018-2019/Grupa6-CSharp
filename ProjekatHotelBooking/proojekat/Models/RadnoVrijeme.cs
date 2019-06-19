using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public enum Dan { Ponedjeljak, Utorak, Srijeda, Četvrtak, Petak, Subota, Nedjelja };
    public class RadnoVrijeme
    {
        private List<Dan> dani;
        private List<TimeSpan> pocetak;
        private List<TimeSpan> kraj;

        public RadnoVrijeme(List<Dan> dani, List<TimeSpan> pocetak, List<TimeSpan> kraj)
        {
            if (dani.Count != pocetak.Count || dani.Count != kraj.Count)
                throw new Exception("Nije dato radno vrijeme za svaki dan!");

            this.dani = dani;
            this.pocetak = pocetak;
            this.kraj = kraj;
        }

        public String GetRadnoVrijeme()
        {
            String radnoVrijeme = "";

            for (int i = 0; i < dani.Count; i++)
                radnoVrijeme += (dani[i] + ": " + pocetak[i] + " - " + kraj[i] + "\n");

            return radnoVrijeme;
        }
    }
}

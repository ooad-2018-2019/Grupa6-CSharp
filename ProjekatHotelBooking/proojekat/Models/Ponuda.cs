using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public class Ponuda
    {
       
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
 
        public int ponudaID;
        public string naziv;
        public string hotel;
        public string liveCamera;
        public string slika;
        public string znamenitosti;

      
        public string Naziv { get => naziv; set => naziv = value; }
        public string Hotel { get => hotel; set => hotel = value; }
        public string LiveCamera { get => liveCamera; set => liveCamera = value; }
        public string Slika { get => slika; set => slika = value; }
        public string Znamenitosti { get => znamenitosti; set => znamenitosti = value; }
        public int PonudaID { get => ponudaID; set => ponudaID = value; }
        
        public Ponuda() { }

        public Ponuda(int ponudaID, string naziv, int brojDana, string hotel, string liveCamera, string slika, string znamenitosti)
        {
            this.PonudaID = ponudaID;
            this.Naziv = naziv;
            this.Hotel = hotel;
            this.LiveCamera = liveCamera;
            this.Slika = slika;
            this.Znamenitosti = znamenitosti;

        }
    }
}

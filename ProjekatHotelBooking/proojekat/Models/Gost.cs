using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public class Gost
    {
        public int GostID;
        public string ime;
        public string prezime;
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
        
  
        private DateTime datumRodjenja;
        private string email;
        private int JMBG;
        private int brojTelefona;
        private bool spol;
        private string brojPasosa;
        private bool osiguranje;
        private int brojKreditneKartice;
        private List<Rezervacija> listaRezervacija;
      
    
        public Gost()
        {
        }

        public Gost(int gostId, string ime, string prezime, DateTime datumRodjenja, string email, int jMBG, int brojTelefona, bool spol, string brojPasosa, bool osiguranje, int brojKreditneKartice, List<Rezervacija> listaRezervacija)
        {
            GostID = gostId;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.email = email;
            JMBG = jMBG;
            this.brojTelefona = brojTelefona;
            this.spol = spol;
            this.brojPasosa = brojPasosa;
            this.osiguranje = osiguranje;
            this.brojKreditneKartice = brojKreditneKartice;
            this.listaRezervacija = listaRezervacija;
        }

        

        public int GostId1 { get => GostID; set => GostID = value; }
        public string Ime { get => ime; set => ime = value; }
        public List<Rezervacija> ListaRezervacija { get => listaRezervacija; set => listaRezervacija = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Email { get => email; set => email = value; }
        public int JMBG1 { get => JMBG; set => JMBG = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public bool Spol { get => spol; set => spol = value; }
        public string BrojPasosa { get => brojPasosa; set => brojPasosa = value; }
        public bool Osiguranje { get => osiguranje; set => osiguranje = value; }
        public int BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value;
           }
    }
}

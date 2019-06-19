using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public class Hotel
    {
        private int rejting;
        RadnoVrijeme radnoVrijeme;
        string naziv;
        string adresa;
        string brojTelefona;
        List<Ponuda> ponude;
        uint kapacitet;
        int idHotel;

        public Hotel(int rejting, RadnoVrijeme radnoVrijeme, string naziv, string adresa, string brojTelefona, List<Ponuda> ponude, uint kapacitet, int idHotel)
        {
            this.rejting = rejting;
            this.radnoVrijeme = radnoVrijeme;
            this.naziv = naziv;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
            this.ponude = ponude;
            this.kapacitet = kapacitet;
            this.idHotel = idHotel;
        }

        public int Rejting { get => rejting; set => rejting = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public List<Ponuda> Ponude { get => ponude; set => ponude = value; }
        public uint Kapacitet { get => kapacitet; set => kapacitet = value; }
        public int IdHotel { get => idHotel; set => idHotel = value; }
        internal RadnoVrijeme RadnoVrijeme { get => radnoVrijeme; set => radnoVrijeme = value; }
    }
}

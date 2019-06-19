using System;

namespace proojekat.Models
{
    public class Rezervacija
    {

        public int rezervacijaID;
        public int ponudaID;
        public double cijena;
        public int brojSobe;
        public DateTime datumPrijave;
        public DateTime datumOdjave;
        public int hotelID;
        public int gostID;

        public virtual Gost Gost{ get; set; }
        public virtual Ponuda Ponuda{ get; set; }

        public Rezervacija()
        {
        }

        public Rezervacija(int rezervacijaID, int ponudaID, double cijena, int brojSobe, DateTime datumPrijave, DateTime datumOdjave, int hotelID, int gostID)
        {
            this.rezervacijaID = rezervacijaID;
            this.ponudaID = ponudaID;
            this.cijena = cijena;
            this.brojSobe = brojSobe;
            this.datumPrijave = datumPrijave;
            this.datumOdjave = datumOdjave;
            this.hotelID = hotelID;
            this.gostID = gostID;
        }

        public int RezervacijaID { get => rezervacijaID; set => rezervacijaID = value; }
        public int PonudaID { get => ponudaID; set => ponudaID = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int BrojSobe { get => brojSobe; set => brojSobe = value; }
        public DateTime DatumPrijave { get => datumPrijave; set => datumPrijave = value; }
        public DateTime DatumOdjave { get => datumOdjave; set => datumOdjave = value; }
        public int HotelID { get => hotelID; set => hotelID = value; }
        public int GostID { get => gostID; set => gostID = value; }
    }
}
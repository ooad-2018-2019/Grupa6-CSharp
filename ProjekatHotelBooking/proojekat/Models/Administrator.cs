using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public class Administrator
    {
        private int idAdmin;
        String password;

        public Administrator(int idAdmin, string password)
        {
            this.IdAdmin = idAdmin;
            this.Password = password;
        }

        public int IdAdmin { get => idAdmin; set => idAdmin = value; }
        public string Password { get => password; set => password = value; }

        void azurirajPonudu(Hotel hotel, Ponuda ponuda)
        {

            // dodati rezervaciju za ponudu
            // azurirati rezervaciju
            // zamijeniti sobu sa nekom drugom
            // obrisati sobu
            // proimijeniti termin
            // promijeniti cijenu

            // obrisati rezervaciju


        }

        void dodajPonudu(Hotel hotel, Ponuda ponuda)
        {
            hotel.Ponude.Add(ponuda);

        }

        void obrisiPonudu(Hotel hotel, Ponuda ponuda)
        {

            hotel.Ponude.Remove(ponuda);

        }
    }
}

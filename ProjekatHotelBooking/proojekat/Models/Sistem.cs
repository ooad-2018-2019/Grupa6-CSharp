using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public sealed class Sistem
    {
        private static Sistem jedinstveniSistem = null;

        private Sistem()
        {
        }

        public static Sistem getInstance()
        {

            if (jedinstveniSistem == null)
            {
                jedinstveniSistem = new Sistem();
            }

            return jedinstveniSistem;

        }


        private List<Hotel> listaHotela;
        private List<Administrator> listaAdministratora;

        public void zakljuciRezervaciju(Hotel hotel)
        {



        }

        public void validirajPodatke(Gost gost, Administrator admin)
        {



        }


        public void naplatiNaknadu(Gost gost)
        {



        }

        public void addHotel(Hotel hotel)
        {

            listaHotela.Add(hotel);


        }

        public void addAdministrator(Administrator admin)
        {

            listaAdministratora.Add(admin);


        }
    }
}

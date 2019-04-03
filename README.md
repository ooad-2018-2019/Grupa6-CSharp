# Grupa6-CSharp
## Tema: Online booking hotela

Članovi tima:
- Elma Bejtović
- Sara Makešoska-Džebo
- Jusuf Delalić

### Opis teme

- Ova aplikacija je namijenjena svima onima koji žele da na brz i jednostavan način odaberu, informišu se i izvrše rezervaciju za hotel koji odgovara njihovim željama za odmor. Svjesni smo da danas ima čitavo more ponuda za hotele te da se vrlo lako može izgubiti u tome te je osnovni cilj ove aplikacije da korisnik ima što bolji uvid u ponudu hotela te da nakon što donese odluku, da mu se omogući rezervacija željenog hotela. No, pored toga, cilj ove aplikacije je da omogući i hotelima da ponude svoje usluge gostima. Osnovna ideja je da gost prvo odabere lokaciju za svoj odmor, te nakon toga dobiva uvid u dostupne hotele. Samom odabirom hotela korisnik ima uvid u ponudu hotela, sobe, slobodne sobe u željenom terminu kao i cijenu uz eventualni popust. Pored toga, korisnik ima mogućnost uvida u komentare i ocjene prethodnih gostiju što mu može  olakšati da donese odluku. Naravno, ako korisnik odluči da izvrši rezervaciju, ima pravo davanja komentara i ocjena na uslugu za vrijeme boravka. Sam raspored hotela za odabranu lokaciju je prikazan u vidu mape, na kojoj se nalazi sama adresa hotela, za bolji uvid. Korisnik ima opciju i da izvrši online uplatu rezervacije.

### Opis funkcionalnosti

Kao što je već rečeno, glavni cilj je omogućiti brzu jednostavnu registraciju sobe. To podrazumijeva:
- **Unos podataka** - Korisnik unosi osnovne podatke o sebi
- **Pregled hotela** - Nakon što korisnik odabere lokaciju i termin, dobiva naziv hotela sa adresama, lokacijama na mapi, broju zvjezdica, prosječnom ocjenom prethodnih gostiju, te reprezentativnom slikom
- **Pregled soba** - Odabirom konkretnog hotela korisnik dobiva uvid u sve sobe, te cijenu za sobu
- **Uvid u slobodne sobe** - Nakon što korisnik izvrši pretragu svih soba hotela može izdvojiti samo one sobe koje su slobodne u tom terminu
- **Zaključivanje i obračun rezervacije** - Korisniku se prikazuju informacije o rezervaciji i ukupna cijena
- **Obračun popusta** - Ako postoji popust na datu rezervaciju to se vrši u zaključivanju i obračunu rezervacije 
- **Potvrda rezervacije** - Nakon što izvrši rezervaciju, dvije sedmice pred dolazak, korisniku se na e-mail šalje upit o potvrdi rezervacije
- **Plaćanje rezervacije** - Korisnik ima opciju online plaćanja

Sada ćemo dati opis ostalih funkcionalnosti:

- **Validacija podataka** - Tokom unosa podataka, korisnik dobiva informaciju da li su njegovi uneseni podaci validni
- **Odustajanje od rezervacije** - Korisnik može odustati od rezervacije, ali u slučaju kasnog odustajanja hotel ima pravo da izvrši i naplatu naknade.
- **Davanje komentara i ocjenjivanje** - Gost hotela ima pravo davanja komentara i ocjenjivanja usluga hotela
- **Ažuriranje ponude** - Administrator ima pravo da ažurira ponudu što može uključivati dodavanje sobe za neki hotel, dodavanje novog hotela, brisanje hotela/sobe iz ponude te ažuriranje cijene
- **Brisanje ponude** - Administrator može ukinuti datu ponudu (npr. ako su svi hoteli popunjeni za dati termin i lokaciju)
- **Dodavanje ponude** - Administrator može dodati novu ponudu

### Akteri

- **Gost** - osoba koja koristi aplikaciju, vrši rezervaciju jedne ili više soba, plaćanje usluge
- **Administrator** - osoba koja nadgleda sistem, odobrava unos podataka o hotelima; vrši dodavanje, brisanje i mijenjanje ponude.
- **Sistem** - vrši zaključivanje i obračun rezervacije, ima uvid u komentare i ocjene, te vrši eventualnu naplatu naknade

/* Tehtävä 1
Toteuta luokka Tank, jolla on seuraavat ominaisuudet: Name (string), Type (string), 
CrewCount(int), Speed(float) ja SpeedMax(float) sekä metodit AccerelateTo(float) ja 
SlowTo(float). 
Toteuta ominaisuudet niin että kaikilla ominaisuuksilla on luokan sisäinen taustamuuttuja, 
joita luokka käyttää.

Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia. Ominaisuus 
CrewCount on luettavissa ja asetettavissa. Sitä asetettaessa tarkistetaan että annettu 
ominaisuus on 
sallitulla välillä: sallittu minimi on kaksi ja maksimi kuusi.

SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena pysyvästi 
arvoon 100. Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa suoraan mutta sen 
arvon 
voi lukea. Speed-omainaisuuden arvoa voi muuttaa ainoastaan metodien AccerelateTo(float) ja 
SlowTo(float) kautta kuitenkin niin että Speed ei voi olla nollaa pienempi eikä 
Speedmax-arvoa 
suurempi. - minimi on nolla ja maksimi 100. Jos metodeille annettu arvo ei ole sallitulla 
välillä niin metodi ei muuta Speed-arvoa.

Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista. 
Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan jotenkin tietää että metodi 
ei asettanutkaan nopeutta pyydettyyn arvoon?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();

            tank.Name = "TankMcTankFace";
            tank.Type = "T90";

            tank.CrewCount = 6;

            tank.AccelerateTo(100);

            tank.SlowTo(80);
            Console.WriteLine("Speed: " + tank.Speed);
            Console.WriteLine("Crewcount: " + tank.CrewCount);
        }
    }
}

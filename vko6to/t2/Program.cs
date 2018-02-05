/*
Tehtävä 2

Seniorikoodari on määritellyt aiemmin valmiiksi rajapinnan. Se on seuraavanlainen:

	public interface ITransaction {
	// interface members 
	string ShowTransaction(); 
	float GetAmount();
	}

Toteuta pienimuotoinen Kassa-ohjelma, jolla voi suorittaa sekä Käteismaksuja että Korttimaksuja. Luo luokat PaidWithCash ja PaidWithCard. Kumpikin luokkaa toteuttaa 
ITransaction-rajapinnan vaatimat metodit, kumpikin omalla tavallaan. Interfacessa määritelty palauttaa suomenkielisen viestin miten maksu suoritettiin viesti myös 
näyttää maksun määrän Euroina. Metodi GetAmount palauttaa maksetun määrän lukuna. PaidWithCash-luokalle toteuta metodi public float ShowCash(), joka kertoo paljonko 
rahaa kassasa on, eli se tallentaa itselleen kaikki kassaan laitetut rahat.
Tee Testi-ohjelma, jossa suoritat kaksi maksua kummallakin tavalla, siis käteisellä ja kortilla. Tee Testi-ohjelmaan myös toteutus siitä että se osaa kertoa päivän 
myynnin yhteensä. Katso oheinen esimerkkiajo oheisessa kuvassa.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

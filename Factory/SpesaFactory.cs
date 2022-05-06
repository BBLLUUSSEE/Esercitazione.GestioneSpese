using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Factory
{
    public class SpesaFactory
    {
        public ISpesa GetVehicle(string descrizionerimborso)
        {
            ISpesa spesa = null;
            //controllo dell'input
            if (descrizionerimborso == null)
                return null;
            //eseguo la creazione sulla base del parametro passato
            switch (descrizionerimborso)
            {
                case 1:
                    Console.WriteLine("Non posso creare veicoli con una ruota! Non siamo acrobati!");
                    vehicle = null;
                    break;
                case 2:
                    vehicle = new Bike() { NumWheels = numWheels };
                    break;
                case 4:
                    vehicle = new Car() { NumWheels = numWheels };
                    break;
                case 6:
                    vehicle = new Bus() { NumWheels = numWheels };
                    break;
                default:
                    vehicle = null;
                    break;
            }

            return vehicle;
        }

    }
}

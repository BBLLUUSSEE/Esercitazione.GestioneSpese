using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace GestioneSpese.Entities
{
    public class Spesa
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public Spesa()
        {

        }
        public Spesa(DateTime data, string categoria, string descrizione, double importo)
        {
            Data = data;
            Categoria = categoria;
            Descrizione = descrizione;
            Importo = importo;
        }
        public string Disegna()
        {
            return $"Data = {Data}, Categoria = {Categoria}, Descrizione = {Descrizione}, Importo = {Importo}";
        }
    }
}

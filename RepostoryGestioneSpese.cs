using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpese.Entities;
using Microsoft.VisualBasic.FileIO;
using GestioneSpese.Chain;

namespace GestioneSpese
{
    public class RepostoryGestioneSpese
    {
        string path = @"C:\Users\luca.pacinotti\Desktop\GestioneSpese\GestioneSpese\Spese.txt";
        public bool Aggiungi(Spesa item)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"{item.Data};{item.Categoria};{item.Descrizione};{item.Importo}");
            }
            return true;
        }
        public static List<Spesa> Leggi()
        {
            string path = @"C:\Users\luca.pacinotti\Desktop\GestioneSpese\GestioneSpese\Spese.txt";
            List<Spesa> spese = new List<Spesa>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd();

                if (string.IsNullOrEmpty(contenutoFile))
                {
                    Console.WriteLine("Errore");
                    return spese;
                }
                else
                {
                    var righeDelFile = contenutoFile.Split("\r\n");
                    for (int i = 0; i < righeDelFile.Length; i++)
                    {
                        var campiDellaRiga = righeDelFile[i].Split(';');
                        Spesa r = new Spesa();
                        r.Data = DateTime.Parse(campiDellaRiga[0]);
                        r.Categoria = campiDellaRiga[1];
                        r.Descrizione = campiDellaRiga[2];
                        r.Importo = double.Parse(campiDellaRiga[3]);
                        spese.Add(r);
                        Console.WriteLine($"Data: {r.Data}, Categoria: {r.Categoria}, Descrizione: {r.Descrizione}, Importo: {r.Importo}");
                        IHandler manager = new ManagerHandler();
                        IHandler opmanager = new OpManagerHandler();
                        IHandler ceo = new CeoHandler();
                        IHandler error = new ErroreHandler();
                        manager.SetNext(opmanager).SetNext(ceo).SetNext(error);

                        Console.WriteLine(manager.Handle(r.Importo));
                    }
                }
                return spese;
            }
        }
    }
}

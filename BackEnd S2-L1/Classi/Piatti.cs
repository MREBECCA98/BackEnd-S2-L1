using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L1.Classi
{
    internal class Piatti
    {
        //costruttore
        public Piatti(int id, string nomepiatto, double prezzo)
        {
            Id = id;
            NomePiatto = nomepiatto;
            Prezzo = prezzo;
        }

        public int Id { get; set; }
        public string NomePiatto { get; }
        public double Prezzo { get; }


    }
}

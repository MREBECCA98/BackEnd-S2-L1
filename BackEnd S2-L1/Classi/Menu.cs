using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L1.Classi
{
    internal class Menu
    {
        //Lista per mettere all'interno i piatti
        public List<Piatti> PiattiDisponibili = new List<Piatti>();
        //Lista ordine
        public List<Piatti> ordine = new List<Piatti>();

        public Menu()
        {
            PiattiDisponibili.Add(new Piatti(1, "Coca Cola 150 ml", 2.50));
            PiattiDisponibili.Add(new Piatti(2, "Insalata di pollo", 5.20));
            PiattiDisponibili.Add(new Piatti(3, "Pizza Margherita", 10.00));
            PiattiDisponibili.Add(new Piatti(4, "Pizza 4 Formaggi", 12.50));
            PiattiDisponibili.Add(new Piatti(5, "Pz Patatine Fritte", 3.50));
            PiattiDisponibili.Add(new Piatti(6, "Insalata di riso", 8.00));
            PiattiDisponibili.Add(new Piatti(7, "Frutta di stagione", 5.00));
            PiattiDisponibili.Add(new Piatti(8, "Pizza Fritta", 5.00));
            PiattiDisponibili.Add(new Piatti(9, "Piadina Vegetariana", 6.00));
            PiattiDisponibili.Add(new Piatti(10, "Panino Hamburger", 7.90));


        }

        public void MenuCompleto()
        {
            Console.WriteLine("MENU");
            foreach (var piatto in PiattiDisponibili)
            {
                Console.WriteLine($"{piatto.Id} - {piatto.NomePiatto} ({piatto.Prezzo} euro) ");
            }

            Console.WriteLine("0 - Chiedi il conto");

            var scelta = Console.ReadLine();

            if (int.Parse(scelta) == 0)
            {
                double totale = 0;

                foreach (var piatto in ordine)
                {
                    Console.WriteLine($"{piatto.NomePiatto} - {piatto.Prezzo} euro");
                    totale += piatto.Prezzo;
                }

                totale += 3;

                Console.WriteLine($"Totale: {totale} euro");

                return;
            }
            foreach (var piatto in PiattiDisponibili)

            {
                if (piatto.Id == int.Parse(scelta))
                {

                    ordine.Add(piatto);
                }
            }
            MenuCompleto(); //metodo ricorsivo-- metodo che richiama se stesso

        }



    }
}

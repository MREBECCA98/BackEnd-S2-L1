// See https://aka.ms/new-console-template for more information
using BackEnd_S2_L1.Classi;
using System.ComponentModel;

Menu menu = new Menu();


Lista:
Console.WriteLine("""

    1: Menu
    

    """);



int scelta = int.Parse(Console.ReadLine());

switch (scelta)
{
    case 1:
        try
        {
            menu.MenuCompleto();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
}













goto Lista;
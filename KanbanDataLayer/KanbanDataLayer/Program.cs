using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanDataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                using (var db = new KanbanEntities())
                {
                    foreach (var list in db.Lists)
                    {

                        Console.WriteLine(list.Name + "\n");
                        foreach (var card in list.Cards)
                        {
                            Console.WriteLine("\t" + card.Text);
                        }
                        Console.WriteLine("\n");
                    }
                    Console.ReadLine();
                    Console.WriteLine("Would you like to add a card?");
                    Console.ReadLine();
                }
            }
        }
    }
}